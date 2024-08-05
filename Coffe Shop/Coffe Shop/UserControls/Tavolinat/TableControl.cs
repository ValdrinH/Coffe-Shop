using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;

namespace Coffe_Shop.UserControls.Tavolinat
{
    public partial class TableControl : UserControl
    {
        bool isforSelected = false;
        public TableControl(bool isSelected)
        {
            InitializeComponent();
            isforSelected = isSelected;
            lblTitle.Text = (isforSelected) ? "Zgjedh Tavolinën" : "Merre Porosin";
            picBack.Visible = isforSelected;
            btnFshije.Visible = btnNdrysho.Visible = btnRuaj.Visible = isforSelected;
        }

        private void btnShtoTavolinen_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtEmri.Text == "")
                {
                    MessageBox.Show("Ju lutem plotësoni fushat!!!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                LoadingScreenDialog.ShowLoadingScreen(InsertAsync(), "Po ngarkohet...", this);
                LoadingScreenDialog.ShowLoadingScreen(GetTaskAsync(), "Po ngarkohet tabelat...", this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async Task InsertAsync()
        {
            try
            {
                await CRUDOperationsInterpretor.MethodAsync(new SQLDatabaseOperations().CRUDDataBaseWithParam, "AddNewTables", new SqlParameter[]
                {
                    new SqlParameter("@TableName",txtEmri.Text.Trim()),
                    new SqlParameter("@TblTime",DateTime.Now.ToShortTimeString()),

                }, this);

                await Task.Delay(200);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async Task GetTaskAsync()
        {
            flowLayoutPanel.Controls.Clear();
            try
            {
                DataTable dt = await CRUDOperationsInterpretor.MethodAsyncTable(new SQLDatabaseOperations().SelectDataAsync, "Exec Tables", this);

                foreach (DataRow item in dt.Rows)
                {
                    var obj = new TableElements()
                    {
                        IdTable = item.Field<int>("TableId"),
                        NameTable = item.Field<string>("TableName"),
                        OriginalNameTable = item.Field<string>("TableName"),
                        VisibleFlag = (VarClass.TableSelected == item.Field<int>("TableId")),
                        VisibleFlagUse = (item.Field<int>("Count") > 0),
                        statusTable = (item.Field<int>("Count") > 0 ? 1 : 0),
                        Time = item.Field<string>("Ora")
                    };

                    obj.RuajNdryshimin += (ss, ee) =>
                    {
                        try
                        {
                            obj.ShowButtons(TableElements.Buttons.UnVisible);
                            obj.SetValueNameAsync();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    };
                    obj.LargoTabelen += (ss, ee) =>
                    {

                        if (obj.VisibleFlagUse)
                        {
                            MessageBox.Show("Kjo tavolin nuk mund të largohet sepse ekziton në listën e porosive !!!", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        DialogResult drs = MessageBox.Show("Dëshironi ta largoni këtë tabelë nga sistemi ?", "Pyetje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (drs != DialogResult.Yes)
                            return;

                        if (obj.statusTable == 1)
                        {
                            MessageBox.Show("Kjo tabelë nuk mund të largohet nga sistemi përderisa statusi është 'E nxën '.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (VarClass.TableSelected == obj.IdTable)
                        {
                            VarClass.TableSelected = -1;
                            FormParentElements.lblTavolina.Text = "Nuk ka tavolinë";
                        }
                        DeleteTable(obj);
                    };
                    obj.SelektoTabelen_ += (ss, ee) =>
                    {
                        if (isforSelected)
                        {
                            if (obj.VisibleFlagUse)
                            {
                                MessageBox.Show("Kjo tavolin nuk mund të selektohet sepse ekziton në listën e porosive !!!", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            if (obj.statusTable == 1)
                            {
                                MessageBox.Show("Tavolina është e nxën dhe nuk mund të seletohet!", "Kujdes/Njoftim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            FormParentElements.lblTavolina.Text = obj.OriginalNameTable;
                            VarClass.TableSelected = obj.IdTable;
                            obj.VisibleFlag = true;
                            FormParentElements.GoToBackControl();
                        }
                        else
                        {
                            if (!obj.VisibleFlagUse)
                            {
                                MessageBox.Show("Nuk ka Porosi të regjistruar në tavolin", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            GetOrderDetails(obj.IdTable, obj);
                        }
                    };

                    flowLayoutPanel.Controls.Add(obj);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async Task GetOrderDetails(int idTable, TableElements objekt)
        {
            try
            {

                DataTable dt = await CRUDOperationsInterpretor.MethodAsyncTable(new SQLDatabaseOperations().SelectDataAsync, "Exec OrderSelected @IdTable = '" + idTable + "'", "Prisni...", this);
                DataRow firstRow = dt.Rows.Count > 0 ? dt.AsEnumerable().First() : null;
                if (firstRow != null)
                {
                    VarClass.Produktes.AddRange(from DataRow row in dt.Rows
                                                where row != null
                                                select new ProduktetEPorositura
                                                {
                                                    EmriProduktit = row.Field<string>("EmriProduktit") ?? string.Empty,
                                                    IdProdukti = row["IdProdukti"] != DBNull.Value ? Convert.ToInt32(row["IdProdukti"]) : 0,
                                                    Qmimi = row["QmimiSh"] != DBNull.Value ? Convert.ToDecimal(row["QmimiSh"]) : 0,
                                                    Sasia = row["Sasia"] != DBNull.Value ? Convert.ToInt32(row["Sasia"]) : 0,
                                                    InvoiceNumber = row.Field<string>("InvoiceNumber") ?? string.Empty
                                                });
                    decimal totalQmimi = dt.AsEnumerable().Sum(row => row.Field<decimal>("Total"));
                    DialogResult drs = VarClass.ShowOweForm(
                                         firstRow.Field<int>("IdTavolina"),
                                         totalQmimi,
                                         firstRow.Field<string>("EmpName"),
                                         firstRow.Field<string>("TableName"),
                                         firstRow.Field<string>("Ora"),
                                         firstRow.Field<DateTime>("DataeRegjistrimit").ToString("dd MMM yyyy"),
                                         firstRow.Field<int>("IdPuntori")
                                         );
                    if (drs == DialogResult.OK && VarClass.PaymentSuccessfully)
                    {
                        objekt.statusTable = 0;
                        objekt.VisibleFlagUse = false;
                        objekt.SetStatus();
                        VarClass.PaymentSuccessfully = false;
                    }

                }
                else
                {
                    MessageBox.Show("Diqka shkoj keq!!!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task DeleteTable(TableElements tableElements)
        {
            try
            {
                await CRUDOperationsInterpretor.MethodAsync(new SQLDatabaseOperations().CRUDDataBaseWithParam, "DeleteTables", new SqlParameter[]
                {
                    new System.Data.SqlClient.SqlParameter("@TableId",tableElements.IdTable),
                }, "Duke u fshirë", this);

                flowLayoutPanel.Controls.Remove(tableElements);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TableControl_Load(object sender, EventArgs e)
        {
            LoadingScreenDialog.ShowLoadingScreen(GetTaskAsync(), "Po ngarkohet tabelat...", this);
            ShowPanel();
        }
        void ShowPanel()
        {
            if (flowLayoutPanel.Controls.Count == 0)
            {
                panelError.Visible = true;
            }
            else
            {
                panelError.Visible = false;
            }
        }
        private void picBack_Click(object sender, EventArgs e)
        {
            FormParentElements.GoToBackControl();
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void btnNdrysho_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnNdrysho.Text == "Ndrysho")
                {
                    btnNdrysho.Text = "Kthehu";
                    SetButtons(1);
                }
                else
                {
                    btnNdrysho.Text = "Ndrysho";
                    foreach (TableElements item in flowLayoutPanel.Controls)
                    {
                        item.ShowButtons(TableElements.Buttons.UnVisible);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SetButtons(int button)
        {

            foreach (TableElements item in flowLayoutPanel.Controls)
            {
                item.ShowButtons(TableElements.Buttons.UnVisible);
            }

            foreach (TableElements item in flowLayoutPanel.Controls)
            {
                item.ShowButtons(((button == 1) ? TableElements.Buttons.Save : TableElements.Buttons.Delete));
            }
        }

        private void btnFshije_Click(object sender, EventArgs e)
        {
            try
            {

                if (btnFshije.Text == "Fshij")
                {
                    btnFshije.Text = "Kthehu";
                    SetButtons(2);
                }
                else
                {
                    btnFshije.Text = "Fshij";
                    foreach (TableElements item in flowLayoutPanel.Controls)
                    {
                        item.ShowButtons(TableElements.Buttons.UnVisible);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void flowLayoutPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            ShowPanel();
        }

        private void flowLayoutPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            ShowPanel();
        }

        private void txtTextCalculator_TextChanged(object sender, EventArgs e)
        {
            if (txtTextCalculator.Text == "" || flowLayoutPanel.Controls.Count == 0)
            {
                flowLayoutPanel.Controls.OfType<TableElements>()
                            .ToList()
                            .ForEach(x => x.Visible = true);
                return;
            }

            flowLayoutPanel.Controls.OfType<TableElements>()
                              .ToList()
                              .ForEach(x => x.Visible = x.OriginalNameTable.ToLower().Contains(txtTextCalculator.Text.ToLower().Trim()));
        }
    }
}
