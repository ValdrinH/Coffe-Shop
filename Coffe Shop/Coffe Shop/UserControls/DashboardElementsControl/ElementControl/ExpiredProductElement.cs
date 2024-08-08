namespace Coffe_Shop.UserControls.DashboardElementsControl.ElementControl
{
    public partial class ExpiredProductElement : UserControl
    {
        public int IdProduct { get; set; }
        public string ProductName { set => lblTitle.Text = value; }
        public string DataSkadimit { set => lblDataeSkadimit.Text = "Data e Skadimit: " + value; }
        public string OriginalElementName { get; set; }
        public bool hasBeenChenged = false;
        public DateTime chengedDate { get => dateTimePicker.Value; }
        public DateTime dateExpired { get; set; }

        public ExpiredProductElement()
        {
            InitializeComponent();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            hasBeenChenged = true;
        }
    }
}
