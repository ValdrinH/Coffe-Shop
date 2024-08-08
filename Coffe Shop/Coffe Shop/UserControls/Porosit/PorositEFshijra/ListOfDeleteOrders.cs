using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;
using Coffe_Shop.Forms;
using System.Data;

namespace Coffe_Shop.UserControls.Porosit.PorositEFshijra
{
    public partial class ListOfDeleteOrders : UserControl
    {
        DatagridviewControl datagridviewContro;
        public ListOfDeleteOrders()
        {
            InitializeComponent();

            Action<int> action = (int Id) =>
            {
                DataGridViewRow row = datagridviewContro.gridView.Rows
               .Cast<DataGridViewRow>()
               .FirstOrDefault(r => r.Cells["Id"].Value != null && (int)r.Cells["Id"].Value == Id);

                if (row != null)
                {

                    DialogResult drs = new FshiPorosin(Id, row.Cells["Puntori"].Value.ToString(), row.Cells["Tiketa"].Value.ToString(), row.Cells["Tavolina"].Value.ToString(),
                        row.Cells["Data e Porosis"].Value.ToString(), DateTime.Parse(row.Cells["Data e Fshirjes"].Value.ToString()), row.Cells["Detajet"].Value.ToString()).ShowDialog();

                    if (drs == DialogResult.OK)
                    {
                        datagridviewContro.gridView.Rows.Remove(row);
                    }

                    return;
                }
                MessageBox.Show("Diqka shkoj keq në sistem, ju lutem provoni të restartoni programin!", "Gabiim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            datagridviewContro = new DatagridviewControl(new DataTable(), DatagridviewControl.Buttonat.Delte, action, "Exec LoadDeletedOrders", new int[] { 0 }, "Tiketa", 20);
        }
        protected override void OnLoad(EventArgs e)
        {
            Body.Controls.Clear();
            datagridviewContro.Dock = DockStyle.Fill;
            Body.Controls.Add(datagridviewContro);

            LoadAllDeleteOreders();
            base.OnLoad(e);
        }
        private async Task LoadAllDeleteOreders()
        {
            datagridviewContro.gridView.DataSource = await CRUDOperationsInterpretor.MethodAsyncTable(new SQLDatabaseOperations().SelectDataAsync, "Exec LoadDeletedOrders", "Po ngarkohen...", this);
            datagridviewContro.gridView.Columns[0].Visible = false;
            datagridviewContro.gridView.Columns[6].Visible = false;
        }
    }
}
