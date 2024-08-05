using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffe_Shop.Forms
{
    public partial class UseForm : Form
    {
        Control control;
        public UseForm(UserControl userControl,string title)
        {
            InitializeComponent();
            control = userControl;
            lblTitle.Text = title;
        }

        private void UseForm_Load(object sender, EventArgs e)
        {
            lblTitle.Location = new Point((this.Width - lblTitle.Width)/2,lblTitle.Location.Y);
            CallUserControl();
        }
        void CallUserControl()
        {
            Body.Controls.Clear();
            control.Dock = DockStyle.Fill;
            Body.Controls.Add(control);
        }

        private void UseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
