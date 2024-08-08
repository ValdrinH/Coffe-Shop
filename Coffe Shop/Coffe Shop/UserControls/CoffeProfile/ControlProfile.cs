using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;
using Coffe_Shop.Classes.Profile;
using System.Data;
using System.Data.SqlClient;

namespace Coffe_Shop.UserControls.CoffeProfile
{
    public partial class ControlProfile : UserControl
    {
        byte[] image = null;
        private int ProfileId = 0;
        public ControlProfile()
        {
            InitializeComponent();
        }

        bool ifExist = false;

        private void picLogo_Click(object sender, EventArgs e)
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
                    picLogo.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            ifProfileExist();

            base.OnLoad(e);
        }
        private async void ifProfileExist()
        {
            try
            {
                DataTable dt = await CRUDOperationsInterpretor.MethodAsyncTable(new SQLDatabaseOperations().SelectDataAsync, "Exec CheckIfProfileExist ", this);

                var first = dt.Rows[0];
                ifExist = first["Total"].ToString() == "0";

                if (!ifExist)
                {
                    lblDtReg.Visible = true;
                    DataTable profile = await CRUDOperationsInterpretor.MethodAsyncTable(new SQLDatabaseOperations().SelectDataAsync, "Exec GetProfile ", "Loading...", this);
                    foreach (DataRow row in profile.Rows)
                    {
                        ProfileId = int.Parse(row["Id"].ToString());
                        txtEmri.Text = row["CoffeName"].ToString();
                        txtEmail.Text = row["Email"].ToString();
                        txtAdresa.Text = row["Address"].ToString();
                        txtNumriTelefonit.Text = row["PhoneNumber"].ToString();
                        lblDtReg.Text = "Data e regjistrimit: " + DateTime.Parse(row["DataReg"].ToString()).ToString("dd MMM, yyyy");
                        picLogo.Image = VarClass.GetImageFromByte((byte[])row["Logo"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRuaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmri.Text == "" || txtEmail.Text == "" || txtAdresa.Text == "" || txtNumriTelefonit.Text == "")
                {
                    MessageBox.Show("Ju lutem plotesoni të gjitha fushat!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ifExist)
                {
                    CreateProfile();

                }
                else
                {
                    UpdateProfile();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        async Task UpdateProfile()
        {
            byte[] imgProfile = VarClass.ConvertImageToByteArray(picLogo.Image, picLogo.Image.RawFormat);
            await CRUDOperationsInterpretor.MethodAsync(new SQLDatabaseOperations().CRUDDataBaseWithParam, "AddProfile", new System.Data.SqlClient.SqlParameter[]
             {
                    new SqlParameter("@Id", ProfileId),
                    new SqlParameter("@Name", txtEmri.Text.Trim()),
                    new SqlParameter("@Address", txtAdresa.Text.Trim()),
                    new SqlParameter("@Phone", txtNumriTelefonit.Text.Trim()),
                    new SqlParameter("@Email", txtEmail.Text.Trim()),
                    new SqlParameter("@Lg",imgProfile),
                    new SqlParameter("@DataReg", DateTime.Now),
             }, "Në Proces...", this);

            MessageBox.Show("Profili u ruajt me sukses", "Me sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CoffeProfileValues.SetValues(ProfileId, txtEmri.Text, txtAdresa.Text, txtEmail.Text, txtNumriTelefonit.Text, imgProfile);
        }

        async Task CreateProfile()
        {
            byte[] imgProfile = VarClass.ConvertImageToByteArray(picLogo.Image, picLogo.Image.RawFormat);
            int LastId = await CRUDOperationsInterpretor.MethodAsyncGetLastIdAfterInsert(new SQLDatabaseOperations().InsertAndGetIdOf, "AddProfile", new System.Data.SqlClient.SqlParameter[]
             {
                    new SqlParameter("@Name", txtEmri.Text.Trim()),
                    new SqlParameter("@Address", txtAdresa.Text.Trim()),
                    new SqlParameter("@Phone", txtNumriTelefonit.Text.Trim()),
                    new SqlParameter("@Email", txtEmail.Text.Trim()),
                    new SqlParameter("@Lg",imgProfile),
                    new SqlParameter("@DataReg", DateTime.Now),
             }, this);

            ifExist = true;
            ProfileId = LastId;
            MessageBox.Show("Profili u ruajt me sukses", "Me sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CoffeProfileValues.SetValues(ProfileId, txtEmri.Text, txtAdresa.Text, txtEmail.Text, txtNumriTelefonit.Text, imgProfile);
        }
    }
}
