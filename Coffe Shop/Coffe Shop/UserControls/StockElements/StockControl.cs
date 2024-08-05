using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;
using Coffe_Shop.Forms.FormUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffe_Shop.UserControls.StockElements
{
    public partial class StockControl : UserControl
    {

        byte[] image = null;
        public StockControl()
        {
            InitializeComponent();
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            if (txtEmri.Text == "" || txtSasia.Text == "" || txtQmimiB.Text == "" || txtQmimiSh.Text == "" || txtFunrizuesi.Text == "" || VarClass.categoriesPerProduct.Count == 0)
            {
                MessageBox.Show("Ju lutem plotësoni të gjitha fushat e nevojshme !!!", "Gabimi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadingScreenDialog.ShowLoadingScreen(TaskAsync(), "Po vendosen të dhënat...", this);
            Clear();
            MessageBox.Show("Produkti u krijua me sukses.", "Me Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private async Task TaskAsync()
        {
            try
            {
                int LastId = await CRUDOperationsInterpretor.MethodAsyncGetLastIdAfterInsert(new SQLDatabaseOperations().InsertAndGetIdOf, "AddNewProducts", new System.Data.SqlClient.SqlParameter[]
                {
                    new SqlParameter("@EmriP", txtEmri.Text.Trim()),
                    new SqlParameter("@EmriF", txtFunrizuesi.Text.Trim()),
                    new SqlParameter("@Sasia", int.Parse(txtSasia.Text)),
                    new SqlParameter("@Njesia", GetUnit(cbNjesia.Text)),
                    new SqlParameter("@QmimiB", decimal.Parse(txtQmimiB.Text)),
                    new SqlParameter("@QmimiSH", decimal.Parse(txtQmimiSh.Text)),
                    new SqlParameter("@DtSkadimit", dtSkadimit.Value.Date),
                    new SqlParameter("@DtRegjistrimit", DateTime.Now.Date),
                    new SqlParameter("@Ora", DateTime.Now.ToString("HH:mm")),
                    new SqlParameter("@Statusi", GetUnit(cbStatusi.Text)),
                    new SqlParameter("@Pershkrim", txtPershkrimi.Text),
                    new SqlParameter("@Img", image),

                }, this);
                await Task.Delay(50);


                var categoryTask = VarClass.categoriesPerProduct.AsEnumerable()
                      .Select(item => AddCategories(new SQLDatabaseOperations(), item, LastId));
                // Prit deri sa të përfundojnë të gjitha thirrjet e asinkrona (nëse ka thirrje)
                await Task.WhenAll(categoryTask);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void Clear()
        {
            txtFunrizuesi.Text = txtEmri.Text = txtPershkrimi.Text = txtQmimiB.Text = txtQmimiSh.Text = txtSasia.Text = "";
            picProduct.Image = Properties.Resources.Screenshot_2023_12_16_163657;
            VarClass.categoriesPerProduct.Clear();
            lblCategories.Text = "Kategorit: 0";
        }

        private async Task AddCategories(SQLDatabaseOperations commandDB, KeyValuePair<int, string> item, int lastId)
        {
            await CRUDOperationsInterpretor.MethodAsync(new SQLDatabaseOperations().CRUDDataBaseWithParam, "AddCategoriesPerProducts", new SqlParameter[]
                 {
                     new SqlParameter("@IdProduct", lastId),
                     new SqlParameter("@IdCategories", item.Key),
                 }, this);

            await Task.Delay(50); // Pret 20 milliseconda deri te fillon tasku tjeter
        }

        public static int GetUnit(string Value)
        {
            switch (Value)
            {
                case "Copa":
                case "Aktiv":
                    return 1;
                    break;
                case "Litra":
                case "Jo Aktiv":
                    return 2;
                    break;
                case "Kg":
                    return 3;
                    break;
                default:
                    break;
            }
            return -1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (VarClass.ShowUseForm(new AddCategoriesPerProduct(), "Shto kategori për produktin") == DialogResult.OK)
            {
                lblCategories.Text = "Kategorit: " + VarClass.categoriesPerProduct.Count;
            }
        }

        private void cbNjesia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void StockControl_Load(object sender, EventArgs e)
        {
            VarClass.SetCornerRadius(picProduct, 20);
            image = VarClass.ConvertImageToByteArray(picProduct.Image, picProduct.Image.RawFormat);
            VarClass.categoriesPerProduct.Clear();

        }

        private void picProduct_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Fotografi |*.jpg;*.jpeg;*.png;" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (BinaryReader br = new BinaryReader(fs))
                        {
                            image = br.ReadBytes((int)fs.Length);
                        }
                    }
                    picProduct.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Lejo vetëm një pikë dhe një presje decimale
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (sender as TextBox).Text.Contains(".") || (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            FormParentElements.GoToBackControl();
        }
    }
}
