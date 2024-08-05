using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                // Kodi që do të kryhet me parameterin 'Id'
                
            };


            datagridviewContro = new DatagridviewControl(new DataTable(), DatagridviewControl.Buttonat.Delte, action);
            gridView = datagridviewContro.gridView;
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
            datagridviewContro.gridView.DataSource = await CRUDOperationsInterpretor.MethodAsyncTable(new SQLDatabaseOperations().SelectDataAsync, "LoadAllCategories","Po ngarkohen...", this);
            datagridviewContro.gridView.Columns[0].Visible = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            FormParentElements.GoToControl(new AddNewCategory());
        }
    }
}
