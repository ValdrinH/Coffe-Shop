using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;
using System.Data;
using static Coffe_Shop.Classes.VarClass;

namespace Coffe_Shop.UserControls.StockElements
{
    public partial class StockList : UserControl
    {
        DatagridviewControl datagridviewContro;
        public StockList()
        {
            InitializeComponent();
            Action<int> action = (int Id) =>
            {
                // Kodi që do të kryhet me parameterin 'Id'
                ElementsItem.IdElement = Id;
                FormParentElements.GoToControl(new EditItems());
            };

            datagridviewContro = new DatagridviewControl(new DataTable(), DatagridviewControl.Buttonat.Delte, action, "Exec LoadAllStock @IdElement = -1", new int[] { 0 }, "Produkti", 20);
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
            datagridviewContro.gridView.DataSource = await CRUDOperationsInterpretor.MethodAsyncTable(new SQLDatabaseOperations().SelectDataAsync, "Exec LoadAllStock @IdElement = -1", "Po ngarkohen...", this);
            datagridviewContro.gridView.Columns[0].Visible = false;
            datagridviewContro.gridView.Columns[2].Visible = false;
            datagridviewContro.gridView.Columns[4].Visible = false;

            VarClass.ResizeDatagrideViewColumns(datagridviewContro.gridView, "Produkti", 20);

        }

        private void button20_Click(object sender, EventArgs e)
        {
            FormParentElements.GoToControl(new StockControl());
        }
    }
}
