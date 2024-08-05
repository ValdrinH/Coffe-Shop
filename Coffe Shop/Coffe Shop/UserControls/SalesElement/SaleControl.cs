using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;
using System.Data;

namespace Coffe_Shop.UserControls.SalesElement
{
    public partial class SaleControl : UserControl
    {
        DatagridviewControl datagridviewContro;

        public SaleControl()
        {
            InitializeComponent();

            Action<int, DateTime> action = (int Id, DateTime time) =>
            {

                FormParentElements.GoToControl(new SaleDetails(Id, time));
            };

            datagridviewContro = new DatagridviewControl(new DataTable(), DatagridviewControl.Buttonat.Delte, action, "Exec LoadSales @Id = -1, @Date = '2023-12-23'", new int[] { 0 }, "Puntori", 50);
        }

        private void SaleControl_Load(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            Body.Controls.Clear();
            datagridviewContro.Dock = DockStyle.Fill;
            Body.Controls.Add(datagridviewContro);

            LoadAllCategories();
            base.OnLoad(e);
        }
        private async Task LoadAllCategories()
        {
            datagridviewContro.gridView.DataSource = await CRUDOperationsInterpretor.MethodAsyncTable(new SQLDatabaseOperations().SelectDataAsync, "Exec LoadSales @Id = -1, @Date = '2023-12-23'", "Po ngarkohen...", this);
            datagridviewContro.gridView.Columns[0].Visible = false;

        }
    }
}
