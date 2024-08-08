using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;
using Coffe_Shop.Classes.Employee;
using static Coffe_Shop.Classes.VarClass;

namespace Coffe_Shop.Forms
{
    public partial class FshiPorosin : Form
    {
        private int _id;
        private string Tavolina { get; set; }
        private string Invoice { get; set; }
        private string DataOra { get; set; }
        bool forDelete = false;

        //Nese thirret konstruktori i pare atehere eshte per fshirjen e porosis aktuale
        public FshiPorosin(string invoice, string tavolina, string dataOra)
        {
            InitializeComponent();

            Invoice = invoice;
            DataOra = dataOra;
            Tavolina = tavolina;

            lblPuntori.Text = "Puntori: " + EmployDetails.EmpName;
            lblDataOra.Text = "Data/Ora e Porosis: " + dataOra;
            lblInvoice.Text = "Invoice: " + invoice;
            lblTavolina.Text = "Tavolina: " + Tavolina;
            lblTitle.Text = "Për të fshir porosin ju duhet të plotësoni \r\nkëto të dhëna më posht!";
            forDelete = false;
        }

        //Nese thirret konstruktori i dyte atehere eshte per fshirjen e porosis se fshire
        public FshiPorosin(int id, string Puntori, string invoice, string tavolina, string dataOra, DateTime dateTime, string detajet)
        {
            InitializeComponent();

            _id = id;
            Invoice = invoice;
            DataOra = dataOra;
            Tavolina = tavolina;
            lblPuntori.Text = "Puntori: " + Puntori;
            lblDataOra.Text = "Data/Ora e Porosis: " + dataOra;
            lblInvoice.Text = "Invoice: " + invoice;
            lblTavolina.Text = "Tavolina: " + Tavolina;
            lblTitle.Text = $"Fshirja e porosis me datë \r\n{dateTime.ToString("dd MMM, yyyy")}";
            txtDetajet.Text = detajet;
            txtDetajet.ReadOnly = true;
            forDelete = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            lblTitle.Location = new Point((Width - lblTitle.Width) / 2, lblTitle.Location.Y);
            base.OnLoad(e);
        }

        private void btnAnulo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FshiPorosin_Load(object sender, EventArgs e)
        {

        }

        private void btnFshije_Click(object sender, EventArgs e)
        {
            try
            {
                if (forDelete)
                {
                    RemoveDeleteOrder();
                    return;
                }

                if (txtDetajet.Text == "")
                {
                    MessageBox.Show("Ju lutem shkruani detajet e fshirjes!");
                    return;
                }


                DeleteOrder();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Diqka shkoj: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Per te larguar porosin e fshir nga databaza
        private async Task RemoveDeleteOrder()
        {
            await CRUDOperationsInterpretor.MethodAsync(new SQLDatabaseOperations().CRUDDataBaseWithParam, "RemoveDeletedOrder",
                         new System.Data.SqlClient.SqlParameter[]
                         {
                                new System.Data.SqlClient.SqlParameter("@Id",_id),

                         },
         "Duke u fshir...", this
                      );
            await Task.Delay(20);
            DialogResult = DialogResult.OK;
        }

        //Per te fshir porosin aktuale ne sistem
        private async Task DeleteOrder()
        {
            await CRUDOperationsInterpretor.MethodAsync(new SQLDatabaseOperations().CRUDDataBaseWithParam, "DeleteOrder",
                            new System.Data.SqlClient.SqlParameter[]
                            {
                                new System.Data.SqlClient.SqlParameter("@IdOrder", ElementsItem.IdElement),
                                new System.Data.SqlClient.SqlParameter("@IdP",  EmployDetails.GetId ),
                                new System.Data.SqlClient.SqlParameter("@Puntori", EmployDetails.EmpName ),
                                new System.Data.SqlClient.SqlParameter("@Invoice", Invoice),
                                new System.Data.SqlClient.SqlParameter("@Tavolina", Tavolina),
                                new System.Data.SqlClient.SqlParameter("@IdTav", ElementsItem.IdElement),
                                new System.Data.SqlClient.SqlParameter("@DtP", DataOra),
                                new System.Data.SqlClient.SqlParameter("@DtF", DateTime.Now),
                                new System.Data.SqlClient.SqlParameter("@Detajet", txtDetajet.Text)
                            },
            "Duke u fshir...", this
                         );
            await Task.Delay(20);
            DialogResult = DialogResult.OK;
        }

        private void FshiPorosin_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}