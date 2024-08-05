namespace Coffe_Shop.Forms
{
    public partial class PrintFormDialog : Form
    {
        public PrintFormDialog()
        {
            InitializeComponent();
        }

        private void PrintFormDialog_Load(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            label1.Location = new Point((ClientSize.Width - label1.Width) / 2, label1.Location.Y);
            pictureBox1.Location = new Point((ClientSize.Width - pictureBox1.Width) / 2, pictureBox1.Location.Y);
            base.OnLoad(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Continue;
        }
    }
}
