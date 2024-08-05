using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;
using Coffe_Shop.Classes.Employee;
using Coffe_Shop.UserControls;
using Coffe_Shop.UserControls.CategoryControlElements;
using Coffe_Shop.UserControls.DashboardElementsControl;
using Coffe_Shop.UserControls.DashboardElementsControl.ElementControl;
using Coffe_Shop.UserControls.Porosit;
using Coffe_Shop.UserControls.Punetoret;
using Coffe_Shop.UserControls.SalesElement;
using Coffe_Shop.UserControls.StockElements;
using Coffe_Shop.UserControls.Tavolinat;
using System.Data;

namespace Coffe_Shop
{
    public partial class Form1 : Form
    {
        //Controls
        Dashboard dashboard = new Dashboard();
        CategoryControlList controlList = new CategoryControlList();
        StockList stockList = new StockList();
        EmployeeBaseControl baseControl = new EmployeeBaseControl();
        ListofOrders listofOrders = new ListofOrders();
        SaleControl saleControl = new SaleControl();
        ListofEmployees employees = new ListofEmployees();
        RrethSistemit about = new RrethSistemit();

        string total = "";
        bool firsTime = true;

        bool eventClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Maximized;
        }
        protected override void OnLoad(EventArgs e)
        {
            DatagridviewOrder.Order = dataGridView;
            FormParentElements.ParentForm = this;
            FormParentElements.lblTavolina = lblTavolina;
            FormParentElements.pnls = new List<Panel>()
            {
                pnlKategorit,pnlTop,TicketPanel
            };
            FormParentElements.LoginIntoSystem(false);
            CallUserControl(new AlertControls());
            CategoriesLeftPanelControls.SetLeftPanel(BodyCategory);
            CategoriesLeftPanelControls.SetDashboardPanel(Body);
            CategoriesLeftPanelControls.AddButtons("Të Gjitha", 0);
            EmployDetails.lblNameEmployee = lblPuntori;


            LoadAllButtons();

            base.OnLoad(e);
        }

        private async Task LoadAllButtons()
        {
            DataTable dt = await CRUDOperationsInterpretor.MethodAsyncTable(new SQLDatabaseOperations().SelectDataAsync, "LoadAllCategories", this);

            foreach (DataRow dr in dt.Rows)
            {
                CategoriesLeftPanelControls.AddButtons(dr[1].ToString(), int.Parse(dr[0].ToString()));
            }
            firsTime = false;
        }

        private void CalculatorNumber(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            if (txtTextCalculator.Text.Length == 1 && txtTextCalculator.Text == "0")
            {
                txtTextCalculator.Text = "";
            }

            txtTextCalculator.Text += btn.Text.ToString();
            eventClicked = true;
        }

        private void EventsCalculator(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            Events(int.Parse(btn.Tag.ToString()));
        }
        public void Events(int Tag)
        {
            if (txtTextCalculator.Text == "")
                return;

            switch (Tag)
            {
                case 1:
                    DataTable table = new DataTable();
                    var result = table.Compute(txtTextCalculator.Text, "");
                    txtTextCalculator.Text = result.ToString();
                    break;
                case 2:
                    if (eventClicked)
                    {
                        txtTextCalculator.Text += "+";
                        eventClicked = false; // NÃ«se Ã«shtÃ« shtuar njÃ« numÃ«r mÃ« parÃ«, pÃ«rcaktoni numeriShtuar nÃ« false
                    }
                    break;
                case 3:
                    if (eventClicked)
                    {
                        txtTextCalculator.Text += "-";
                        eventClicked = false; // NÃ«se Ã«shtÃ« shtuar njÃ« numÃ«r mÃ« parÃ«, pÃ«rcaktoni numeriShtuar nÃ« false
                    }
                    break;
                case 4:
                    if (eventClicked)
                    {
                        txtTextCalculator.Text += "*";
                        eventClicked = false; // NÃ«se Ã«shtÃ« shtuar njÃ« numÃ«r mÃ« parÃ«, pÃ«rcaktoni numeriShtuar nÃ« false
                    }
                    break;
                case 5:
                    if (EmployDetails.inSystem)
                    {
                        FormParentElements.GoToControl(new TableControl(false));
                    }
                    else
                    {
                        MessageBox.Show("Ju lutem kyquni në sistem...", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 6:
                    txtTextCalculator.Text = "0";
                    eventClicked = false;
                    break;
            }
        }
        public void CallUserControl(UserControl uc)
        {
            Body.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            Body.Controls.Add(uc);
        }
        private void ElementsDashboard(object sender, EventArgs e)
        {
            var lbl = (Label)sender;

            if (int.Parse(lbl.Tag.ToString()) <= 8)
            {
                Line.Width = lbl.Width;
                Line.Location = new Point(lbl.Location.X, Line.Location.Y);
            }
            else
            {
                Line.Width = lblTjera.Width;
                Line.Location = new Point(lblTjera.Location.X, Line.Location.Y);
            }
            LoadUser(int.Parse(lbl.Tag.ToString()));
        }
        private void LoadUser(int IdUser)
        {
            if (IdUser != 8)
                pnlMenuDrop.Visible = false;

            switch (IdUser)
            {
                case 1:
                    dashboard = new Dashboard();
                    updateElementsIfExistAnyRow(dashboard);
                    CallUserControl(dashboard);
                    FormParentElements.LastControl = dashboard;
                    break;
                case 2:
                    controlList = new CategoryControlList();
                    CallUserControl(controlList);
                    FormParentElements.LastControl = controlList;
                    break;
                case 3:
                    stockList = new StockList();
                    CallUserControl(stockList);
                    FormParentElements.LastControl = stockList;
                    break;

                case 5:
                    listofOrders = new ListofOrders();
                    CallUserControl(listofOrders);
                    FormParentElements.LastControl = listofOrders;
                    break;
                case 6:
                    saleControl = new SaleControl();
                    CallUserControl(saleControl);
                    FormParentElements.LastControl = saleControl;
                    break;
                case 7:
                    employees = new ListofEmployees();
                    CallUserControl(employees);
                    FormParentElements.LastControl = employees;
                    break;
                case 8:
                    pnlMenuDrop.Location = new Point(lblTjera.Location.X, pnlMenuDrop.Location.Y);
                    pnlMenuDrop.Visible = !pnlMenuDrop.Visible;
                    break;
                case 9:

                    break;
                case 10:

                    break;
                case 11:
                    about = new RrethSistemit();
                    CallUserControl(about);
                    break;
            }
        }
        void updateElementsIfExistAnyRow(Dashboard dsh)
        {
            if (dataGridView.Rows.Count > 0)
            {
                Task.Run(() =>
                {
                    // Prisni derisa të ngarkohen të dhënat
                    while (!dsh.isLoaded)
                    {
                        Thread.Sleep(100); // Kontrollo çdo 100 ms
                    }

                    // Kjo pjesë e kodit duhet të ekzekutohet në thread-in kryesor UI
                    dataGridView.Invoke(new Action(() =>
                    {
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            var product = dsh.flowLayoutPanel.Controls.OfType<Elements>().FirstOrDefault(x => x.Id == int.Parse(row.Cells["Id"].Value.ToString()));
                            if (product != null)
                            {
                                product.isSelected = true;
                            }
                        }
                    }));
                });
            }
        }
        private void txtTextCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            pnlTotalRows.Visible = false;
            TotalPagesa();
        }

        private void dataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TotalPagesa();
            if (dataGridView.Rows.Count == 0)
            {
                pnlTotalRows.Visible = true;
            }
        }
        void TotalPagesa()
        {
            if (dataGridView.Rows.Count > 0)
            {

                decimal sum = dataGridView.Rows
                 .Cast<DataGridViewRow>()
                 .Sum(row => Convert.ToDecimal(row.Cells["Total"].Value));

                lblTotal.Text = "Totali: " + sum.ToString("0.00") + "€";
                total = sum.ToString("0.00") + "€";
            }
            else
            {
                lblTotal.Text = "Totali: 0.00€";
                total = "0.00€";

            }
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dataGridView.Columns[e.ColumnIndex].Name == "Total")
            {
                TotalPagesa();
            }

        }

        private void btnPastroTiketen_Click(object sender, EventArgs e)
        {
            foreach (Control control in dashboard.flowLayoutPanel.Controls)
            {
                if (control is Elements el)
                {
                    el.isSelected = false;
                }
            }

            dataGridView.Rows.Clear();
            FormParentElements.lblTavolina.Text = "Nuk ka tavolinë";
            VarClass.TableSelected = -1;
        }

        private void BodyCategory_ControlAdded(object sender, ControlEventArgs e)
        {
            lblNgarkimi.Visible = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            FormParentElements.LastControl = dashboard;
            FormParentElements.GoToControl(new TableControl(true));
        }

        private void btnKyqu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTextCalculator.Text == "0")
                {
                    MessageBox.Show("Ju lutem kontrolloni fushën e ID-s.", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (btnKyqu.Text == "Shkyqu")
                {
                    EmployDetails.GetOut();
                    btnKyqu.Text = "Kyqu";
                    btnKyqu.BackColor = Color.OliveDrab;
                    Body.Controls.Add(dashboard);
                    FormParentElements.LoginIntoSystem(false);
                    CallUserControl(new AlertControls());
                    return;
                }

                GetEmployId();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task GetEmployId()
        {
            try
            {
                DataTable dt = await CRUDOperationsInterpretor.MethodAsyncTable(new SQLDatabaseOperations().SelectDataAsync, "Exec LoginInfo @IdCard = '" + txtTextCalculator.Text + "'", "Duke u kotrolluar...", this);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Puntori me këtë ID Kart nuk ekziston. Ju lutem kotaktojeni Administratorin", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataRow dr = dt.AsEnumerable().FirstOrDefault();

                if (dr.Field<int>("Statusi") == 0)
                {
                    MessageBox.Show("Puntori me këtë ID Kart është deaktiv. Ju lutem kotaktojeni Administratorin", "Llogaria Deaktive", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                EmployDetails.SetValues(dr.Field<int>("EmpId"), dr.Field<string>("EmpName"), dr.Field<string>("EmpEmil"), dr.Field<int>("IdKarta"), dr.Field<int>("Pozita"));
                ChangeVisibleNavbarItems(dr.Field<int>("Pozita"));
                btnKyqu.Text = "Shkyqu";
                btnKyqu.BackColor = Color.Red;
                FormParentElements.LoginIntoSystem(true);
                CallUserControl(dashboard);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeVisibleNavbarItems(int roli)
        {


            switch (roli)
            {
                case 3:
                case 4:
                    lblCategory.Enabled = false;
                    lblStoku.Enabled = false;
                    lblPuntoret.Enabled = false;
                    break;

                default:
                    lblCategory.Enabled = true;
                    lblStoku.Enabled = true;
                    lblPuntoret.Enabled = true;
                    break;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                var ord = new OrderClass();
                ord.TotalPagesa = total;
                LoadingScreenDialog.ShowLoadingScreen(ord.InsertOrederData(), "Po ngarkohet...", this);
                DatagridviewOrder.ClearRows();
                VarClass.TableSelected = -1;
                FormParentElements.lblTavolina.Text = "Nuk ka tavolinë";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            DialogResult drs = MessageBox.Show("Dëshiron të mbyllësh aplikacionin ?", "Pyetje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drs != DialogResult.Yes)
                return;


            Application.Exit();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "btnLargo" && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                int columnValue = int.Parse(row.Cells["Quantity"].Value.ToString());
                if (columnValue > 1)
                {
                    columnValue -= 1;
                    row.Cells["Quantity"].Value = columnValue.ToString();
                    row.Cells["Total"].Value = decimal.Parse(row.Cells["Price"].Value.ToString()) * columnValue;
                }
                else
                {
                    int id = int.Parse(row.Cells["Id"].Value.ToString());
                    var element = Body.Controls.OfType<Dashboard>().FirstOrDefault();

                    if (element != null)
                    {
                        var product = element.flowLayoutPanel.Controls.OfType<Elements>().FirstOrDefault(x => x.Id == id);
                        product.isSelected = false;
                    }
                    else
                    {
                        var product = dashboard.flowLayoutPanel.Controls.OfType<Elements>().FirstOrDefault(x => x.Id == id);
                        product.isSelected = false;
                    }

                    dataGridView.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
