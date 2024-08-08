using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;
using System.Data;

namespace Coffe_Shop.UserControls.CategoryControlElements
{
    public partial class CategoryControlList : UserControl
    {
        DatagridviewControl datagridviewContro;
        DataGridView gridView;
        public CategoryControlList()
        {
            InitializeComponent();

            Action<int> action = (int Id) =>
            {
                DataGridViewRow row = datagridviewContro.gridView.Rows
               .Cast<DataGridViewRow>()
               .FirstOrDefault(r => r.Cells["IdCategory"].Value != null && (int)r.Cells["IdCategory"].Value == Id);
                VarClass.ShowUseForm(new CategoriesDetails(Id, row.Cells["Kategoria"].Value.ToString(), row.Cells["Përshkrimi"].Value.ToString()), "Detajet e Kategoris");
                RefreshGridView();
            };

            datagridviewContro = new DatagridviewControl(new DataTable(), DatagridviewControl.Buttonat.Delte, action, "Exec LoadAllCategories");
            gridView = datagridviewContro.gridView;
        }
        private void RefreshGridView()
        {
            datagridviewContro.RefreshRows();
        }

        private void CategoryControlList_Load(object sender, EventArgs e)
        {
            body.Controls.Clear();
            datagridviewContro.Dock = DockStyle.Fill;
            body.Controls.Add(datagridviewContro);

            LoadAllCategories();
        }
        private async Task LoadAllCategories()
        {
            datagridviewContro.gridView.DataSource = await CRUDOperationsInterpretor.MethodAsyncTable(new SQLDatabaseOperations().SelectDataAsync, "LoadAllCategories", "Po ngarkohen...", this);
            datagridviewContro.gridView.Columns[0].Visible = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            FormParentElements.GoToControl(new AddNewCategory());
        }
    }
}
