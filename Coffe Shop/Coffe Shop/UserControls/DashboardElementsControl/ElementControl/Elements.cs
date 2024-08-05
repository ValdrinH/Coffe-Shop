using Coffe_Shop.Classes;

namespace Coffe_Shop.UserControls.DashboardElementsControl.ElementControl
{
    public partial class Elements : UserControl
    {
        public int Id;
        public string ElementName { get => lblTitle.Text; set => lblTitle.Text = value; }
        public string OriginalElementName { get; set; }
        public string Furnizuesi { get; set; }
        public List<Categories> Attributes { get; set; }
        public decimal Cost { get; set; } = decimal.Zero;
        public Image pic { get => picElement.Image; set => picElement.Image = value; }
        public int Sasia { get; set; }
        public bool isSelected { get => pnlSelected.Visible; set => pnlSelected.Visible = value; }


        public EventHandler PutintoList = null;
        public Elements()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
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
            VarClass.SetCornerRadius(picElement, 20);

            base.OnLoad(e);
        }

        private void Elements_Load(object sender, EventArgs e)
        {

            lblCost.Text = Cost.ToString("0.00") + "€";
        }

        private void ElementClick(object sender, EventArgs e)
        {
            isSelected = true;
            PutintoList?.Invoke(sender, e);
        }
    }
    public class Categories
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }

    }
}
