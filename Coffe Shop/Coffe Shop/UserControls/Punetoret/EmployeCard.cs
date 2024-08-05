
using Coffe_Shop.Classes;

namespace Coffe_Shop.UserControls.Punetoret
{
    public partial class EmployeCard : UserControl
    {
        public int Id;
        public string EmployeeName { get => lblTitle.Text; set => lblTitle.Text = "EM: " + value; }
        public string OriginalElementName { get; set; }
        public string NumriTelefonit { set => lblNumri.Text = "NR: " + value; }
        public string Roli { set => lblRoli.Text = "R: " + value; }
        public Image pic { get => picElement.Image; set => picElement.Image = value; }

        public EventHandler EmployeDetails = null;
        public EmployeCard()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            toolTip1.SetToolTip(this, OriginalElementName);
            SetLabelWidth(lblNumri);
            SetLabelWidth(lblRoli);
            SetLabelWidth(lblTitle);
            VarClass.SetCornerRadius(picElement, 20);

            base.OnLoad(e);
        }

        private void SetLabelWidth(Label lbl)
        {
            string teksti = lbl.Text;
            bool eKalonMadhesine = (TextRenderer.MeasureText(teksti, lbl.Font).Width > tableLayoutPanel.Width);
            if (eKalonMadhesine)
            {
                while (TextRenderer.MeasureText(teksti + "...", lbl.Font).Width > tableLayoutPanel.Width)
                {
                    teksti = teksti.Substring(0, teksti.Length - 1);
                }

                lbl.Text = teksti + "...";
            }
            else
            {
                lbl.Text = teksti;
            }
        }

        private void EmployeCard_Click(object sender, EventArgs e)
        {
            EmployeDetails?.Invoke(Id, e);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void EmployeCard_Load(object sender, EventArgs e)
        {

        }
    }
}
