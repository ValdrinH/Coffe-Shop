using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;
using Coffe_Shop.Forms.FormUserControls;
using System.Data;
using System.Data.SqlClient;
using static Coffe_Shop.Classes.VarClass;

namespace Coffe_Shop.UserControls.StockElements
{
    public partial class EditItems : UserControl
    {

        public EditItems()
        {
            InitializeComponent();
            VarClass.categoriesPerProduct.Clear();
        }

        private void EditItems_Load(object sender, EventArgs e)
        {
            VarClass.SetCornerRadius(picProduct, 20);
            LoadingScreenDialog.ShowLoadingScreen(GetTaskAsync(), "Po ngarkohet...", this);
        }
        private async Task GetTaskAsync()
        {
            VarClass.categoriesPerProduct.Clear();
            try
            {
                DataTable dt = await CRUDOperationsInterpretor.MethodAsyncTable(new SQLDatabaseOperations().SelectDataAsync, "Exec LoadAllStock @IdElement = '" + ElementsItem.IdElement + "'", this);

                DataRow firstRow = dt.AsEnumerable().First();

                if (firstRow != null)
                {
                    txtEmri.Text = firstRow.Field<string>("Produkti");
                    txtFunrizuesi.Text = firstRow.Field<string>("Furnizuesi");
                    txtSasia.Text = firstRow.Field<int>("Sasia").ToString();
                    cbNjesia.Text = firstRow.Field<string>("Njësia");
                    txtQmimiB.Text = firstRow.Field<decimal>("Qmimi B.").ToString("0.00");
                    txtQmimiSh.Text = firstRow.Field<decimal>("Qmimi Sh.").ToString("0.00");
                    cbStatusi.Text = firstRow.Field<string>("Statusi");
                    lblCategories.Text = "Kategorit: " + firstRow.Field<int>("Count").ToString();
                    dtSkadimit.Value = firstRow.Field<DateTime>("DataSkadimit");
                    lblDateRegister.Text = firstRow.Field<DateTime>("DataSkadimit").ToString("dd MMM yyyy") + ", " + firstRow.Field<string>("OraeRegjistrimit");
                    txtPershkrimi.Text = firstRow.Field<string>("Pershkrimi");
                    picProduct.Image = VarClass.GetImageFromByte(firstRow.Field<byte[]>("Fotografia"));
                }

                await Task.Delay(100);
                DataTable dtCategories = await CRUDOperationsInterpretor.MethodAsyncTable(new SQLDatabaseOperations().SelectDataAsync, "Exec LoadAllForProduct @Id = '" + ElementsItem.IdElement + "'", this);
                foreach (DataRow dr in dtCategories.Rows)
                {
                    VarClass.categoriesPerProduct.Add(dr.Field<int>("IdCategory"), dr.Field<string>("Kategoria"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbStatusi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtQmimiB_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (VarClass.ShowUseForm(new AddCategoriesPerProduct(), "Shto kategori për produktin") == DialogResult.OK)
            {
                lblCategories.Text = "Kategorit: " + VarClass.categoriesPerProduct.Count;
            }
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            if (txtEmri.Text == "" || txtFunrizuesi.Text == "" || txtSasia.Text == "" || txtQmimiB.Text == "" || txtQmimiSh.Text == "" || txtPershkrimi.Text == "" || VarClass.categoriesPerProduct.Count == 0)
            {
                MessageBox.Show("Ju lutem plotësoni të gjitha fushat !!!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                LoadingScreenDialog.ShowLoadingScreen(UpdateElements(), "Duke u përditësuar...", this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task UpdateElements()
        {
            byte[] imageProduct = VarClass.ConvertImageToByteArray(picProduct.Image, picProduct.Image.RawFormat);
            await CRUDOperationsInterpretor.MethodAsync(new SQLDatabaseOperations().CRUDDataBaseWithParam, "UpdateStock", new SqlParameter[]
            {
                        new SqlParameter("@Id",ElementsItem.IdElement),
                        new SqlParameter("@ProductName", txtEmri.Text.Trim()),
                        new SqlParameter("@Supplier", txtFunrizuesi.Text.Trim()),
                        new SqlParameter("@Sasia", int.Parse(txtSasia.Text)),
                        new SqlParameter("@Njesia", StockControl.GetUnit(cbNjesia.Text)),
                        new SqlParameter("@QmimiB", decimal.Parse(txtQmimiB.Text)),
                        new SqlParameter("@QmimiSh", decimal.Parse(txtQmimiSh.Text)),
                        new SqlParameter("@DtSkd", dtSkadimit.Value.Date),
                        new SqlParameter("@Statusi", StockControl.GetUnit(cbStatusi.Text)),
                        new SqlParameter("@Desc", txtPershkrimi.Text.Trim()),
                        new SqlParameter("@ProductImage", imageProduct)
            }
            , this);

            await Task.Delay(100);

            var categoryTask = VarClass.categoriesPerProduct.AsEnumerable()
                   .Select(item => AddCategories(new SQLDatabaseOperations(), item, ElementsItem.IdElement));
            // Prit deri sa të përfundojnë të gjitha thirrjet e asinkrona (nëse ka thirrje)
            await Task.WhenAll(categoryTask);

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
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deshiron ta largoni nga stoku produktin '" + txtEmri.Text + "' ?\nVëmendje nëse produkti gjindet tek pjesa e porosive nuk mund të largohet !!!", "Pyetje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Action deleteAction = async () =>
                {
                    try
                    {
                        await CRUDOperationsInterpretor.MethodAsync(new SQLDatabaseOperations().CRUDDataBaseWithParam, "DeleteProduct", new System.Data.SqlClient.SqlParameter[] { new System.Data.SqlClient.SqlParameter("@Id", ElementsItem.IdElement) }, "Duke u larguar...", this);
                        FormParentElements.GoToBackControl();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };
                deleteAction.Invoke();
            }
        }

        private void picProduct_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Fotografi |*.jpg;*.jpeg;*.png;" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    //using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    //{
                    //    using (BinaryReader br = new BinaryReader(fs))
                    //    {
                    //        image = br.ReadBytes((int)fs.Length);
                    //    }
                    //}
                    picProduct.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void EditItems_SizeChanged(object sender, EventArgs e)
        {
        }
    }
}
