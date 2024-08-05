using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;
using System.Data;
using static Coffe_Shop.Classes.VarClass;

namespace Coffe_Shop.UserControls.Porosit
{
    public partial class ListofOrders : UserControl
    {
        public ListofOrders()
        {
            InitializeComponent();
        }

        public async Task GetTaskAsync()
        {
            try
            {
                DataTable dt = await CRUDOperationsInterpretor.MethodAsyncTable(new SQLDatabaseOperations().SelectDataAsync, "Exec LoadAllOrders @WichSection = -1", this);

                if (dt == null || dt.Rows.Count == 0)
                {
                    pnlMessage.Visible = true;
                    return;
                }

                var element = dt.AsEnumerable().Select(x =>
                {
                    var order = new OrderComponent()
                    {
                        Id = x.Field<int>("IdTavolina"),
                        Ora = x.Field<string>("Ora"),
                        Data = x.Field<DateTime>("Data").ToString("dd MMM, yyyy"),
                        Tavolina = x.Field<string>("Tavolina"),
                        Puntori = x.Field<string>("Puntori")

                    };

                    order.onButtonClick += (ee, ss) =>
                    {
                        ElementsItem.IdElement = order.Id;
                        FormParentElements.GoToControl(new OrdersDetails());
                    };

                    return order;

                }).ToArray();

                BodyComponent.Controls.AddRange(element);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            lblMessage.Location = new Point((ClientSize.Width - lblMessage.Width) / 2, lblMessage.Location.Y);
            GetTaskAsync();
            base.OnLoad(e);
        }
        private void ListofOrders_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" || BodyComponent.Controls.Count == 0)
            {
                BodyComponent.Controls.OfType<OrderComponent>()
                            .ToList()
                            .ForEach(x => x.Visible = true);
                return;
            }

            BodyComponent.Controls.OfType<OrderComponent>()
                              .ToList()
                              .ForEach(x => x.Visible = x.Tavolina.ToLower().Contains(txtSearch.Text.ToLower().Trim())
                              || x.Puntori.ToLower().Contains(txtSearch.Text.ToLower().Trim()));
        }

        private void BodyComponent_ControlAdded(object sender, ControlEventArgs e)
        {
            lblTotal.Text = "Total Porosi: " + BodyComponent.Controls.Count;
        }

        private void BodyComponent_ControlRemoved(object sender, ControlEventArgs e)
        {
            lblTotal.Text = "Total Porosi: " + BodyComponent.Controls.Count;
        }
    }
}
