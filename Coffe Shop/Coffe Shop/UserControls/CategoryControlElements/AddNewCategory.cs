using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffe_Shop.UserControls.CategoryControlElements
{
    public partial class AddNewCategory : UserControl
    {
        public AddNewCategory()
        {
            InitializeComponent();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            FormParentElements.GoToBackControl();
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmriPershkrimit.Text == "")
                {
                    MessageBox.Show("Ju lutem plotësoni të gjitha fushat !!!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LoadingScreenDialog.ShowLoadingScreen(Inserting(),"Po shtohet kategoria...",this);

                txtEmriPershkrimit.Text = txtPershkrimi.Text = "";
                MessageBox.Show("U krijua me sukses", "Me sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task Inserting()
        {
            int ID = await CRUDOperationsInterpretor.MethodAsyncGetLastIdAfterInsert(new SQLDatabaseOperations().InsertAndGetIdOf, "InsertCategories",
                new SqlParameter[]
                {
                    new SqlParameter("@Name",txtEmriPershkrimit.Text.Trim()),
                    new SqlParameter("@Pershkrim",txtPershkrimi.Text.Trim())

                }, this);


            //Shto nje button te re ne listen e kategorive per cdo kategori qe vendoset ne databaze
            CategoriesLeftPanelControls.AddButtons(txtEmriPershkrimit.Text.Trim(), ID);
        }
    }
}
