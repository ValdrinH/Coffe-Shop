
using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;
using Coffe_Shop.UserControls.DashboardElementsControl.ElementControl;
using System.Data;

namespace Coffe_Shop.UserControls.DashboardElementsControl
{
    public partial class ExpiredProducts : UserControl
    {
        public ExpiredProducts()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            lblWarnging.Text = $"Siguro që të gjitha datat të jenë më të më se : {DateTime.Now.ToString("dd MMM, yyyy")}\r\nNdryshe nuk do të ruhen të dhënat";
            LoadAllProduct();
            base.OnLoad(e);
        }
        private async Task LoadAllProduct()
        {
            try
            {
                DataTable dt = await CRUDOperationsInterpretor.MethodAsyncTable(new SQLDatabaseOperations().SelectDataAsync, "Exec LoadExpiredProducts", this);
                foreach (DataRow row in dt.Rows)
                {
                    var element = new ExpiredProductElement()
                    {
                        IdProduct = int.Parse(row[0].ToString()),
                        ProductName = row[1].ToString(),
                        OriginalElementName = row[1].ToString(),
                        DataSkadimit = DateTime.Parse(row[2].ToString()).ToString("dd MMM, yyyy"),
                        dateExpired = DateTime.Parse(row[2].ToString()),
                    };

                    Body.Controls.Add(element);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void txtTextCalculator_TextChanged(object sender, EventArgs e)
        {
            if (Body.Controls.Count <= 0)
                return;


            //Ben filtrimin sipas emrit te elementit
            Body.Controls.OfType<ExpiredProductElement>()
                                  .ToList()
                                  .ForEach(x => x.Visible = x.OriginalElementName.ToLower().Contains(txtTextCalculator.Text.ToLower().Trim()));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadingScreenDialog.ShowLoadingScreen(SelectAndUpdate(), "Në proces...", this);

            ReturnParetnDialog(DialogResult.OK);
        }
        async Task SelectAndUpdate()
        {
            foreach (Control row in Body.Controls)
            {
                if (row is ExpiredProductElement exp)
                {
                    if (exp.hasBeenChenged && exp.chengedDate > DateTime.Now)
                    {
                        await TaskUpdateProduct(exp.IdProduct, exp.chengedDate);
                    }
                }
            }

            await Task.CompletedTask;
        }
        async Task TaskUpdateProduct(int id, DateTime date)
        {
            await CRUDOperationsInterpretor.MethodAsync(new SQLDatabaseOperations().CRUDDataBaseWithParam, "ChangeDateExpiredProduct", new System.Data.SqlClient.SqlParameter[]
            {
                new System.Data.SqlClient.SqlParameter("@Id",id),
                new System.Data.SqlClient.SqlParameter("@DateTime",date),
            }, this);
        }
    }
}
