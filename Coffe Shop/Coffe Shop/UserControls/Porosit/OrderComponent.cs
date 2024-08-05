namespace Coffe_Shop.UserControls.Porosit
{
    public partial class OrderComponent : UserControl
    {
        public int Id { get; set; }
        public string Ora { set => lblOra.Text = value; }
        public string Data { set => lblData.Text = value; }
        public string Tavolina { get => lblTable.Text; set => lblTable.Text = "Tavolina: " + value; }
        public string Puntori { get => lblWaiter.Text; set => lblWaiter.Text = value; }

        public EventHandler onButtonClick = null;

        public OrderComponent()
        {
            InitializeComponent();
        }

        private void OrderComponent_Load(object sender, EventArgs e)
        {
            lblTable.Location = new Point((ClientSize.Width - lblTable.Width) / 2, lblTable.Location.Y);
            lblWaiter.Location = new Point((ClientSize.Width - lblWaiter.Width) / 2, lblWaiter.Location.Y);
            MeShumeDetaje.Location = new Point((ClientSize.Width - MeShumeDetaje.Width) / 2, MeShumeDetaje.Location.Y);
        }

        private void MeShumeDetaje_Click(object sender, EventArgs e)
        {
            onButtonClick?.Invoke(sender, e);
        }
    }
}
