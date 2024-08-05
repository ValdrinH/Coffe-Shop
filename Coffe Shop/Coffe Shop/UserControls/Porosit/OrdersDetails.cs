using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;
using Coffe_Shop.Forms;
using System.Data;
using static Coffe_Shop.Classes.VarClass;

namespace Coffe_Shop.UserControls.Porosit
{
    public partial class OrdersDetails : UserControl
    {
        string tableName = "";
        int IdPuntori = -1;
        DataTable Orders = new DataTable();
        public OrdersDetails()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            GetTaskAsync();
            base.OnLoad(e);
        }
        private async Task GetTaskAsync()
        {
            try
            {
                DataTable dt = await CRUDOperationsInterpretor.MethodAsyncTable(new SQLDatabaseOperations().SelectDataAsync, "Exec OrderSelected @IdTable = '" + ElementsItem.IdElement + "'", "Po ngarkohet...", this);
                DataRow firtstRow = dt.AsEnumerable().First();
                Orders = dt;
                lblName.Text = firtstRow.Field<string>("EmpName");
                lblTitle.Text = $"Porosia në '{firtstRow.Field<string>("TableName")}'";
                lblDate.Text = firtstRow.Field<DateTime>("DataeRegjistrimit").ToString("dd MMM yyyy");
                lblOra.Text = firtstRow.Field<string>("Ora");
                tableName = firtstRow.Field<string>("TableName");
                IdPuntori = firtstRow.Field<int>("IdPuntori");
                decimal totalSum = dt.Rows.Cast<DataRow>()
                .Sum(row => Convert.ToDecimal(row["Total"] ?? 0));
                lblTotal.Text = totalSum.ToString("0.00") + "€";
                lblInvoice.Text = firtstRow.Field<string>("InvoiceNumber");


                foreach (DataRow row in dt.Rows)
                {
                    dataGridView.Rows.Add(row["IdProdukti"], row["EmriProduktit"], row["Sasia"], row["QmimiSh"], row["Total"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView.Columns["btnLargo"].Index)
            {
                // Largo rreshtin e përzgjedhur
                DialogResult drs = MessageBox.Show("Dëshironi ta largoni këtë rresht nga lista e porosive ?!", "Kujdes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (drs != DialogResult.Yes)
                    return;

                Action deleteAction = async () =>
                {
                    try
                    {
                        await CRUDOperationsInterpretor.MethodAsync(new SQLDatabaseOperations().CRUDDataBaseWithParam, "RemoveSepcificRowFromOrder",
                                new System.Data.SqlClient.SqlParameter[]
                                {
                                    new System.Data.SqlClient.SqlParameter("@IdTable",ElementsItem.IdElement),
                                    new System.Data.SqlClient.SqlParameter("@IdProduct",dataGridView.Rows[e.RowIndex].Cells["Id"].Value),
                                },
                                "Duke u larguar...", this
                            );
                        await Task.Delay(20);
                        dataGridView.Rows.Clear();
                        GetTaskAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                };

                deleteAction.Invoke();
            }
        }

        private async Task DeleteIfRowEqualZero()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            VarClass.Produktes.AddRange(from DataRow row in Orders.Rows
                                        where row != null
                                        select new ProduktetEPorositura
                                        {
                                            EmriProduktit = row.Field<string>("EmriProduktit") ?? string.Empty,
                                            IdProdukti = row["IdProdukti"] != DBNull.Value ? Convert.ToInt32(row["IdProdukti"]) : 0,
                                            Qmimi = row["QmimiSh"] != DBNull.Value ? Convert.ToDecimal(row["QmimiSh"]) : 0,
                                            Sasia = row["Sasia"] != DBNull.Value ? Convert.ToInt32(row["Sasia"]) : 0,
                                            InvoiceNumber = row.Field<string>("InvoiceNumber") ?? string.Empty
                                        });


            DialogResult drs = VarClass.ShowOweForm(
                                  ElementsItem.IdElement,
                                   Convert.ToDecimal(lblTotal.Text.Replace("€", "")),
                                   lblName.Text,
                                   tableName,
                                  lblOra.Text,
                                   Convert.ToDateTime(lblDate.Text).ToString("dd MMM yyyy"),
                                   IdPuntori
                                   );

            if (drs == DialogResult.OK && VarClass.PaymentSuccessfully)
            {
                VarClass.PaymentSuccessfully = false;
                FormParentElements.GoToBackControl();
            }
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            FormParentElements.GoToBackControl();
        }

        private void btnFshije_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult drs = MessageBox.Show("Dëshiron të fshish këtë porosi ?", "Pyetje/Kujdes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drs != DialogResult.Yes)
                {
                    return;
                }
                DialogResult dialog = new FshiPorosin(lblInvoice.Text, tableName, lblDate.Text + " | " + lblOra.Text).ShowDialog();
                if (dialog == DialogResult.OK)
                    FormParentElements.GoToBackControl();
            }
            catch (Exception)
            {
                MessageBox.Show("Diqka shkoj keq ne sistem", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
