using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;

namespace Coffe_Shop.UserControls.Tavolinat
{
    public partial class TableElements : UserControl
    {
        public int IdTable { get; set; }
        public string NameTable { set => lblTitle.Text = value; }
        public string OriginalNameTable { get; set; }
        public int statusTable { get; set; }
        public string Time { get => lblCost.Text; set => lblCost.Text = value; }
        public bool VisibleFlag { get => Selected.Visible; set => Selected.Visible = value; }
        public bool VisibleFlagUse { get => picInUse.Visible; set => picInUse.Visible = value; }
        public string OpenClose { set => lblCost.Text = value; }
        public Color ForeColorOC { set => lblCost.ForeColor = value; }

        public EventHandler LargoTabelen = null;
        public EventHandler RuajNdryshimin = null;
        public EventHandler SelektoTabelen_ = null;

        public enum Buttons
        {
            Save,
            Delete,
            UnVisible
        }

        public TableElements()
        {
            InitializeComponent();
        }

        private void TableElements_Load(object sender, EventArgs e)
        {
            SetStatus();
            TextLength();
            foreach (Control item in Controls)
            {
                if (item.Name == "Selected")
                {
                    return;
                }
                item.Location = new Point((Width - item.Width) / 2, item.Location.Y);
            }
        }
        public void ShowButtons(Buttons buttons)
        {
            txtName.Visible = false;

            switch (buttons)
            {
                case Buttons.Save:
                    btnRuajes.Visible = true;
                    btnRuajes.Location = btnFshije.Location;
                    txtName.Text = OriginalNameTable;
                    txtName.Visible = true;
                    break;
                case Buttons.Delete:
                    btnFshije.Visible = true;
                    break;
                case Buttons.UnVisible:
                    btnRuajes.Visible = btnFshije.Visible = false;
                    break;
            }
        }
        public void SetStatus()
        {
            if (statusTable == 1)
            {
                lblCost.Text = "E nxën - " + Time;
                lblCost.ForeColor = Color.Red;
                picElement.Image = Properties.Resources.icons8_restaurant_table_100__1_;
            }
            else
            {
                lblCost.Text = "E Hapur";
                lblCost.ForeColor = Color.FromName("GreenYellow");
                picElement.Image = Properties.Resources.icons8_restaurant_table_100;
            }
        }
        void TextLength()
        {
            string teksti = lblTitle.Text;
            bool eKalonMadhesine = (TextRenderer.MeasureText(teksti, lblTitle.Font).Width > tableLayoutPanel.Width);
            if (eKalonMadhesine)
            {
                while (TextRenderer.MeasureText(teksti + "...", lblTitle.Font).Width > tableLayoutPanel.Width)
                {
                    teksti = teksti.Substring(0, teksti.Length - 1);
                }

                lblTitle.Text = teksti + "...";
            }
            else
            {
                lblTitle.Text = teksti;
            }
        }
        private void btnFshije_Click(object sender, EventArgs e)
        {
            LargoTabelen?.Invoke(sender, e);
        }
        public async Task SetValueNameAsync()
        {
            if (txtName.Text == "")
                return;

            await UpdateAsync();

            lblTitle.Text = txtName.Text.Trim();
            OriginalNameTable = txtName.Text.Trim();
            TextLength();
        }
        private async Task UpdateAsync()
        {
            try
            {
                await CRUDOperationsInterpretor.MethodAsync(new SQLDatabaseOperations().CRUDDataBaseWithParam, "UpdateTables", new System.Data.SqlClient.SqlParameter[]
                {
                    new System.Data.SqlClient.SqlParameter("@TableId",IdTable),
                    new System.Data.SqlClient.SqlParameter("@TableName",txtName.Text.Trim())
                }, "Duke u ndryshuar...", Parent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRuajes_Click(object sender, EventArgs e)
        {
            RuajNdryshimin?.Invoke(sender, e);
        }

        private void SelektoTabelen(object sender, EventArgs e)
        {
            SelektoTabelen_?.Invoke(sender, e);
        }

        private void RemoveTableFromSelected(object sender, EventArgs e)
        {

        }
    }
}
