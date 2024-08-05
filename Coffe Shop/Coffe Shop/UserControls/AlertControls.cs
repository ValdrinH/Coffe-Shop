using Coffe_Shop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffe_Shop.UserControls
{
    public partial class AlertControls : UserControl
    {
        public AlertControls()
        {
            InitializeComponent();
        }

        private void AlertControls_Load(object sender, EventArgs e)
        {
            VarClass.ChangeControlsSize(this);
            foreach (Control item in this.Controls)
            {
                item.Location = new Point((this.Width - item.Width) / 2, item.Location.Y);
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            DatagridviewOrder.Order.Rows.Clear();
            FormParentElements.lblTavolina.Text = "Nuk ka tavolinë";
            VarClass.TableSelected = -1;
            timer.Start();
            base.OnLoad(e);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH : mm : ss");
        }

        private void AlertControls_SizeChanged(object sender, EventArgs e)
        {
            VarClass.ChangeControlsSize(this);
        }
       
    }
}
