using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;
using Coffe_Shop.Classes.Employee;
using System.Data;
using System.Data.SqlClient;

namespace Coffe_Shop.UserControls.Punetoret
{
    public partial class EmployeeDetails : UserControl
    {
        private byte[] image = null;
        private int _id;
        public EmployeeDetails(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            GetEmployeeDetails();
            base.OnLoad(e);
        }
        private async Task GetEmployeeDetails()
        {
            try
            {
                if (_id == 0 || _id == null)
                {
                    MessageBox.Show("Diqka shkoj keq gjatë ekzekutimit, ju lutem provoni përsëri ose kontaktoni zhvilluesin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable dt = await CRUDOperationsInterpretor.MethodAsyncTable(new SQLDatabaseOperations().SelectDataAsync, $"Exec LoadEmployeeDetails @Id = {_id}", this);
                if (dt == null || dt.Rows.Count == 0)
                {
                    return;
                }
                foreach (DataRow dr in dt.Rows)
                {
                    txtPuntori.Text = dr.Field<string>("EmpName");
                    lblTitle.Text = $"Të dhënat e '{dr.Field<string>("EmpName")}'";
                    txtEmail.Text = dr.Field<string>("EmpEmil");
                    txtNumriTelefonit.Text = dr.Field<string>("EmpNumri");
                    cbMosha.Text = dr.Field<int>("EmpMosha").ToString();
                    cbGjinia.Text = dr.Field<string>("EmpGjinia");
                    txtPagaBaze.Text = dr.Field<decimal>("EmpPaga").ToString("0.00");
                    picProduct.Image = VarClass.GetImageFromByte(dr.Field<byte[]>("Profili"));
                    image = dr.Field<byte[]>("Profili");
                    txtKohaefillimit.Text = dr.Field<string>("KohaeFillimit");
                    txtkohaeMbraimit.Text = dr.Field<string>("KohaeMbarimit");
                    cbSatusi.Text = (dr.Field<int>("Statusi") == 1) ? "Aktiv" : "Jo Aktiv";
                    cbRoli.Text = GetRoli(dr.Field<int>("Pozita"));
                    dtNisjes.Value = dr.Field<DateTime>("DataeNisjes");
                    txtIdKarta.Text = dr.Field<int>("IdKarta").ToString();
                    txtPershkrimi.Text = dr.Field<string>("Pershkrimi");
                    lblDataReg.Text = "Data e Regjistrimit: " + dr.Field<DateTime>("DataeRegjistrimit").ToString("dd MMM, yyyy");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetRoli(int num)
        {
            switch (num)
            {

                case 4:
                    return "Shankist";
                    break;
                case 3:
                    return "Kamarier";
                    break;
                case 2:
                    return "Shef kuzhiner";
                    break;
                case 1:
                    return "Menaxher";
                    break;
                default:
                    return "Kamarier";
                    break;
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

        private void picBack_Click(object sender, EventArgs e)
        {
            FormParentElements.GoToBackControl();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult drs = MessageBox.Show("Dëshiron të fshish nga sistemi këtë puntorë ?", "Keni kujdes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (drs == DialogResult.Yes)
            {
                DeleteUser();
            }
        }
        private async Task DeleteUser()
        {
            try
            {
                await CRUDOperationsInterpretor.MethodAsync(new SQLDatabaseOperations().CRUDDataBaseWithParam, "DeleteEmployee", new SqlParameter[]
                {
                    new SqlParameter("@Id", _id),
                }, this);

                FormParentElements.GoToBackControl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

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
            var ifExist = await CheckIfExist();

            if (ifExist == true)
            {
                MessageBox.Show("Nuk mund të ndryshohen të dhënat përshkak që një përdorues posedon disa nga të dhënat si: Email, Numri i Telefonit, ID Karat", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                await Task.CompletedTask;
            }

            await Task.Delay(100);

            byte[] imgProfile = VarClass.ConvertImageToByteArray(picProduct.Image, picProduct.Image.RawFormat);
            await CRUDOperationsInterpretor.MethodAsync(new SQLDatabaseOperations().CRUDDataBaseWithParam, "UpdateEmployee", new SqlParameter[]
            {
                    new SqlParameter("@Id", _id),
                    new SqlParameter("@Name", txtPuntori.Text.TrimEnd()),
                    new SqlParameter("@Email", txtEmail.Text.TrimEnd()),
                    new SqlParameter("@Numri", txtNumriTelefonit.Text.TrimEnd()),
                    new SqlParameter("@Mosha", int.Parse(cbMosha.Text)),
                    new SqlParameter("@Gjinia", cbGjinia.Text),
                    new SqlParameter("@Paga", decimal.Parse(txtPagaBaze.Text)),
                    new SqlParameter("@Statusi", cbSatusi.Text =="Aktiv"?1:0),
                    new SqlParameter("@KhFillimit", txtKohaefillimit.Text),
                    new SqlParameter("@KhMbarimit", txtkohaeMbraimit.Text),
                    new SqlParameter("@Pozita", EmployeeBaseControl.GetRoli(cbRoli.Text)),
                    new SqlParameter("@IdKarta", int.Parse(txtIdKarta.Text)),
                    new SqlParameter("@Pershkrimi", txtPershkrimi.Text.TrimEnd()),
                    new SqlParameter("@Profili", imgProfile)
            }
            , this);

            if (_id == EmployDetails.GetId)
            {
                //If User Change his profile then change date in real time
                EmployDetails.SetValues(_id, txtPuntori.Text.TrimEnd(), txtEmail.Text.Trim(), int.Parse(txtIdKarta.Text.Trim()), EmployeeBaseControl.GetRoli(cbRoli.Text));
            }

            MessageBox.Show("Përdoruesi u përditësua me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private async Task<bool> CheckIfExist()
        {
            try
            {
                DataTable dt = await CRUDOperationsInterpretor.MethodAsyncTable(new SQLDatabaseOperations().SelectDataAsync, $"Exec CheckIfIdCardExist @Id = {int.Parse(txtIdKarta.Text.Trim())}," +
                    $" @UserId={_id}, @Email='{txtEmail.Text.Trim()}', @Nr='{txtNumriTelefonit.Text.Trim()}'", this);
                if (dt == null)
                    return true;

                var firstRow = dt.AsEnumerable().FirstOrDefault();

                return (firstRow.Field<int>("Count") > 1 ? true : false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
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
    }
}
