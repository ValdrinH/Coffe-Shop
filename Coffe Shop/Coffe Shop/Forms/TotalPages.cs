using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;
using System.Data;
using System.Data.SqlClient;

namespace Coffe_Shop.Forms
{
    public partial class TotalPages : Form
    {
        decimal total;
        decimal fromClient = 0.00m;
        decimal totOwe = -1;
        int TavolinaId = -1;
        string oraPorosis;
        DateTime dataeshitjes;
        int Puntori;

        public TotalPages()
        {
            InitializeComponent();
        }
        public TotalPages(int IdTavolina, decimal total, string Puntori, string tavolina, string ora, string Date, int PuntoriId)
        {
            InitializeComponent();
            lblPuntori.Text = "Puntori: " + Puntori;
            lblOra.Text = "Ora: " + ora;
            oraPorosis = ora;
            lblDate.Text = Date;
            lblTable.Text = tavolina;
            this.total = total;
            txtTotal.Text = total.ToString("0.00");
            TavolinaId = IdTavolina;
            this.Puntori = PuntoriId;
            dataeshitjes = Convert.ToDateTime(Date);
            Calaculate();
        }
        void Calaculate()
        {
            var tot = fromClient - total;
            totOwe = tot;
            if (totOwe > 0)
            {
                txtBorgji.BackColor = Color.Green;
                txtBorgji.ForeColor = Color.White;
            }
            else if (totOwe < 0)
            {
                txtBorgji.BackColor = Color.IndianRed;
                txtBorgji.ForeColor = Color.White;
            }
            else
            {
                txtBorgji.BackColor = Color.WhiteSmoke;
                txtBorgji.ForeColor = Color.Black;
            }
            txtBorgji.Text = "Borgji: " + tot.ToString("0.00");
        }
        private void TotalPages_Load(object sender, EventArgs e)
        {
            VarClass.PaymentSuccessfully = false;
        }

        private void txtPagesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Lejo vetëm një pikë dhe një presje decimale
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (sender as System.Windows.Forms.TextBox).Text.Contains(".") || (sender as System.Windows.Forms.TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void txtPagesa_TextChanged(object sender, EventArgs e)
        {
            fromClient = decimal.Parse(string.IsNullOrEmpty(txtPagesa.Text) ? "0.00" : txtPagesa.Text.Trim());
            Calaculate();
        }

        private async void button20_Click(object sender, EventArgs e)
        {
            try
            {
                if (totOwe < 0)
                {
                    MessageBox.Show("Pagesa nuk mund të kryhet përshkak se ka vlera negative!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                LoadingScreenDialog.ShowLoadingScreen(InsertAsync(), "Në proces...", this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task InsertAsync()
        {
            if (VarClass.Produktes.Count == 0)
            {
                MessageBox.Show("Diqka shkoj keq, ju lutem kontaktoni administratorin !", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            foreach (ProduktetEPorositura item in VarClass.Produktes)
            {
                await CRUDOperationsInterpretor.MethodAsync(new SQLDatabaseOperations().CRUDDataBaseWithParam, "ShtoShitje", new System.Data.SqlClient.SqlParameter[]
                {
                        new SqlParameter("@IdProdukti", SqlDbType.Int) { Value = item.IdProdukti },
                        new SqlParameter("@IdTavolina", SqlDbType.Int) { Value = TavolinaId },
                        new SqlParameter("@EmriProduktit", SqlDbType.NVarChar, 100) { Value = item.EmriProduktit },
                        new SqlParameter("@Sasia", SqlDbType.Int) { Value = item.Sasia },
                        new SqlParameter("@Cmimi", SqlDbType.Decimal) { Value = item.Qmimi },
                        new SqlParameter("@OraShitjes", SqlDbType.NVarChar, 20) { Value = oraPorosis },
                        new SqlParameter("@DataShitjes", SqlDbType.DateTime) { Value = dataeshitjes.Date },
                        new SqlParameter("@IdPuntori", SqlDbType.Int) { Value = Puntori },
                        new SqlParameter("@Pagesa", SqlDbType.Decimal) { Value = total },
                        new SqlParameter("@Kthimi", SqlDbType.Decimal) { Value = totOwe },
                        new SqlParameter("@InvoiceNumber", SqlDbType.NVarChar) { Value = item.InvoiceNumber }
                }, this);
            }

            VarClass.Produktes.Clear();
            VarClass.PaymentSuccessfully = true;
            DialogResult = DialogResult.OK;
        }
    }
}
