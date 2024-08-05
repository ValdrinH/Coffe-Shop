using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;
using Coffe_Shop.UserControls.DashboardElementsControl.ElementControl;
using System.Data;

namespace Coffe_Shop.UserControls.DashboardElementsControl
{
    public partial class Dashboard : UserControl
    {
        public bool isLoaded = false;
        public Dashboard()
        {
            InitializeComponent();
            isLoaded = false;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadingScreenDialog.ShowLoadingScreen(GetTaskAsync(), "Po ngarkohen të dhënat", this);
        }
        private async Task GetTaskAsync()
        {
            try
            {

                DataTable ids = await CRUDOperationsInterpretor.MethodAsyncTable(new SQLDatabaseOperations().SelectDataAsync, "LoadAllCategoriesPerProduct", this);

                await Task.Delay(50);
                DataTable dt = await CRUDOperationsInterpretor.MethodAsyncTable(new SQLDatabaseOperations().SelectDataAsync, "Exec LoadStock @WichForm = 1", this);

                foreach (DataRow row in dt.Rows)
                {
                    var element = new Elements()
                    {
                        Id = int.Parse(row[0].ToString()),
                        Cost = decimal.Parse(row[4].ToString()),
                        ElementName = row[1].ToString(),
                        OriginalElementName = row[1].ToString(),
                        Furnizuesi = row[2].ToString(),
                        Sasia = int.Parse(row[3].ToString()),
                        pic = VarClass.GetImageFromByte((byte[])row[5]),
                        Attributes = GetDictionary(int.Parse(row[0].ToString()), ids)
                    };
                    element.PutintoList += (ss, ee) =>
                    {
                        DatagridviewOrder.AddRowsToGridview(element.Id, element.OriginalElementName, element.Cost);
                    };
                    flowLayoutPanel.Controls.Add(element);
                }
                isLoaded = true; //After load all elements to the control
                await Task.Delay(50);
                flowLayoutPanel.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Categories> GetDictionary(int v, DataTable ids)
        {

            //Kthen list me objekte te klases Categories e cila permban dy properti me Id e Kategoris dhe Emrin e kategoris 
            return ids.AsEnumerable()
                .Where(row => row.Field<int>("IdPorduct") == v).Select(row => new Categories()
                {
                    ID = row.Field<int>("IdCategory"),
                    CategoryName = row.Field<string>("Kategoria")
                }).ToList();
        }

        private void txtTextCalculator_TextChanged(object sender, EventArgs e)
        {
            if (flowLayoutPanel.Controls.Count <= 0)
                return;


            //Ben filtrimin sipas emrit te elementit
            flowLayoutPanel.Controls.OfType<Elements>()
                                  .ToList()
                                  .ForEach(x => x.Visible = x.OriginalElementName.ToLower().Contains(txtTextCalculator.Text.ToLower().Trim()));
        }
    }
}
