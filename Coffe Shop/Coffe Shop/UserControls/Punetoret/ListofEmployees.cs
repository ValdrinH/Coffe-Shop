using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;
using System.Data;

namespace Coffe_Shop.UserControls.Punetoret
{
    public partial class ListofEmployees : UserControl
    {
        public ListofEmployees()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            lblMessage.Location = new Point((ClientSize.Width - lblMessage.Width) / 2, lblMessage.Location.Y);
            GetTaskAsync();
            base.OnLoad(e);
        }
        public async Task GetTaskAsync()
        {
            try
            {
                DataTable dt = await CRUDOperationsInterpretor.MethodAsyncTable(new SQLDatabaseOperations().SelectDataAsync, "Exec LoadAllEmployees ", this);

                if (dt == null || dt.Rows.Count == 0)
                {
                    pnlMessage.Visible = true;
                    return;
                }

                var element = dt.AsEnumerable().Select(x =>
                {
                    var employe = new EmployeCard()
                    {
                        Id = x.Field<int>("EmpId"),
                        EmployeeName = x.Field<string>("EmpName"),
                        OriginalElementName = x.Field<string>("EmpName"),
                        NumriTelefonit = x.Field<string>("EmpNumri"),
                        Roli = x.Field<string>("Roli"),
                        pic = VarClass.GetImageFromByte(x.Field<byte[]>("Profili")),
                    };

                    employe.EmployeDetails += (ee, ss) =>
                    {
                        FormParentElements.GoToControl(new EmployeeDetails(x.Field<int>("EmpId")));
                    };

                    return employe;

                }).ToArray();

                bodyElement.Controls.AddRange(element);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListofEmployees_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNewEmployees_Click(object sender, EventArgs e)
        {
            FormParentElements.GoToControl(new EmployeeBaseControl());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (bodyElement.Controls.Count <= 0)
                return;


            //Ben filtrimin sipas emrit te elementit
            bodyElement.Controls.OfType<EmployeCard>()
                                  .ToList()
                                  .ForEach(x => x.Visible = x.OriginalElementName.ToLower().Contains(txtSearch.Text.ToLower().Trim()));
        }
    }
}
