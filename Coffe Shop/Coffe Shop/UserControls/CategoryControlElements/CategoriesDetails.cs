using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;
using System.Data.SqlClient;

namespace Coffe_Shop.UserControls.CategoryControlElements
{
    public partial class CategoriesDetails : UserControl
    {
        private int _id;
        public CategoriesDetails(int id, string kategoria, string pershrimi)
        {
            InitializeComponent();
            _id = id;
            txtEmriPershkrimit.Text = kategoria;
            txtPershkrimi.Text = pershrimi;
        }

        private void ReturnParetnDialog(DialogResult drs)
        {
            var parentPanel = Parent as Panel;
            if (parentPanel != null)
            {
                if (parentPanel.Parent is Form frm)
                {
                    frm.DialogResult = drs;
                }
            }
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmriPershkrimit.Text) || string.IsNullOrEmpty(txtPershkrimi.Text))
            {
                MessageBox.Show("Ju lutem plotësoni të gjitha fushat!", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UpdateCategory();
        }

        private void btnFshije_Click(object sender, EventArgs e)
        {
            DialogResult drs = MessageBox.Show("Dëshiron të fshish këtë kategori ?\nKeni kujdes cdo produkt që ka këtë kategori do të ju hiqet!", "Pyetje/Kujdes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drs != DialogResult.Yes)
                return;

            DeleteCategory();
        }
        private async Task DeleteCategory()
        {
            await CRUDOperationsInterpretor.MethodAsync(new SQLDatabaseOperations().CRUDDataBaseWithParam, "DeleteCategories", new System.Data.SqlClient.SqlParameter[]
            {
                    new SqlParameter("@Id", _id),
            }, "Në Proces...", this);

            //Largo buttonin nga paneli i majte
            CategoriesLeftPanelControls.RemoveButtons(_id);
            ReturnParetnDialog(DialogResult.OK);

            MessageBox.Show("Profili u ruajt me sukses", "Me sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async Task UpdateCategory()
        {
            await CRUDOperationsInterpretor.MethodAsync(new SQLDatabaseOperations().CRUDDataBaseWithParam, "UpdateCategory", new System.Data.SqlClient.SqlParameter[]
            {
                    new SqlParameter("@Id", _id),
                    new SqlParameter("@Name", txtEmriPershkrimit.Text.Trim()),
                    new SqlParameter("@Pershkrimi", txtPershkrimi.Text.Trim()),

            }, "Në Proces...", this);

            //Ndrysho tekstin e buttonit specifik ne panelin e majt
            CategoriesLeftPanelControls.UpdateButtonName(txtEmriPershkrimit.Text.Trim(), _id);

            MessageBox.Show("Kategoria u ruajt me sukses", "Me sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
