using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;
using System.Data.SqlClient;

namespace Coffe_Shop.UserControls.Punetoret
{
    public partial class EmployeeBaseControl : UserControl
    {

        byte[] image = null;

        public EmployeeBaseControl()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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
                    picProduct.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void EmployeeBaseControl_Load(object sender, EventArgs e)
        {
            image = VarClass.ConvertImageToByteArray(picProduct.Image, picProduct.Image.RawFormat);
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            FormParentElements.GoToBackControl();
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm())
                    return;

                InsertAsync();

                MessageBox.Show("Puntori u kriju me sukses", "Me sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            // Kontrollo nëse tekstbox-at janë bosh
            if (string.IsNullOrWhiteSpace(txtPuntori.Text))
            {
                MessageBox.Show("Ju lutem, plotësoni emrin e punëtorit.", "Validim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPuntori.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Ju lutem, plotësoni emailin.", "Validim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNumriTelefonit.Text))
            {
                MessageBox.Show("Ju lutem, plotësoni numrin e telefonit.", "Validim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumriTelefonit.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPagaBaze.Text))
            {
                MessageBox.Show("Ju lutem, plotësoni pagën bazë.", "Validim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPagaBaze.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtKohaefillimit.Text))
            {
                MessageBox.Show("Ju lutem, plotësoni kohën e fillimit.", "Validim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKohaefillimit.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtkohaeMbraimit.Text))
            {
                MessageBox.Show("Ju lutem, plotësoni kohën e mbarimit.", "Validim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtkohaeMbraimit.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtIdKarta.Text))
            {
                MessageBox.Show("Ju lutem, plotësoni ID e kartës.", "Validim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdKarta.Focus();
                return false;
            }
            else
            {
                if (txtIdKarta.Text.Length < 4)
                {
                    MessageBox.Show("Ju lutem, shënoni më shumë se 4 shifra në ID e kartës.", "Validim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIdKarta.Focus();
                    return false;
                }
            }

            try
            {
                var addr = new System.Net.Mail.MailAddress(txtEmail.Text);
                if (addr.Address != txtEmail.Text)
                {
                    MessageBox.Show("Ju lutem, plotësoni një email të vlefshëm.", "Validim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Ju lutem, plotësoni një email të vlefshëm.", "Validim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }


            // Kontrollo nëse paga bazë është numër decimal
            if (!decimal.TryParse(txtPagaBaze.Text, out _))
            {
                MessageBox.Show("Ju lutem, plotësoni një pagë të vlefshme.", "Validim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPagaBaze.Focus();
                return false;
            }

            // Validimi ka kaluar
            return true;
        }


        private async Task InsertAsync()
        {

            int status = (cbSatusi.Text == "Aktiv") ? 1 : 0;
            int roli = GetRoli(cbRoli.Text);
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmpName", txtPuntori.Text.Trim()),
                new SqlParameter("@EmpEmail", txtEmail.Text.Trim()),
                new SqlParameter("@EmpNumri", txtNumriTelefonit.Text.Trim()),
                new SqlParameter("@EmpMosha", int.Parse(cbMosha.Text)),
                new SqlParameter("@EmpGjinia", cbGjinia.Text),
                new SqlParameter("@EmpPaga", decimal.Parse(txtPagaBaze.Text??"0.00")),
                new SqlParameter("@Statusi", status),
                new SqlParameter("@KohaeFillimit", txtKohaefillimit.Text),
                new SqlParameter("@KohaeMbarimit", txtkohaeMbraimit.Text),
                new SqlParameter("@Pozita", roli),
                new SqlParameter("@DataeNisjes", dtNisjes.Value.Date),
                new SqlParameter("@IdKarta", int.Parse(txtIdKarta.Text)),
                new SqlParameter("@Pershkrimi", txtPershkrimi.Text),
                new SqlParameter("@DataeRegjistrimit", DateTime.Now.Date),
                new SqlParameter("@Profile", image)
            };


            await CRUDOperationsInterpretor.MethodAsync(new SQLDatabaseOperations().CRUDDataBaseWithParam, "InsertEmployee", parameters, "Po ngarkohen të dhënat...", this);
        }

        public static int GetRoli(string text)
        {
            switch (text)
            {

                case "Shankist":
                    return 4;
                    break;
                case "Kamarier":
                    return 3;
                    break;
                case "Shef kuzhiner":
                    return 2;
                    break;
                case "Menaxher":
                    return 1;
                    break;
                default:
                    break;
            }
            return 3;
        }
    }
}
