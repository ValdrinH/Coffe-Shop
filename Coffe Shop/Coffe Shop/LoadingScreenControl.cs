using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffe_Shop
{
    public partial class LoadingScreenControl : Form
    {
        private Task onWorking;
        Control _control;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
     (
         int nLeftRect,     // x-coordinate of upper-left corner
         int nTopRect,      // y-coordinate of upper-left corner
         int nRightRect,    // x-coordinate of lower-right corner
         int nBottomRect,   // y-coordinate of lower-right corner
         int nWidthEllipse, // height of ellipse
         int nHeightEllipse // width of ellipse
     );
        public LoadingScreenControl(Task task, string tit, Control control)
        {
            InitializeComponent();
            onWorking = task;
            lblTitle.Text = tit;
            _control = control;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        protected override void OnLoad(EventArgs e)
        {
            foreach(Control item in this.Controls)
            {
                item.Location = new Point((this.Width - item.Width) / 2, item.Location.Y);
            }
            this.StartPosition = FormStartPosition.CenterParent;
            StartTaskAsync();

            base.OnLoad(e);
        }
        async Task StartTaskAsync()
        {
            var taskToRun = onWorking;  //Tasku Aktual

            var timeoutTask = Task.Delay(TimeSpan.FromMinutes(5));  // Vendos timeout-in në 5 minuta

            var completedTask = await Task.WhenAny(taskToRun, timeoutTask);

            if (completedTask == taskToRun)
            {
                await DelayAndSetResultAsync(DialogResult.OK, TimeSpan.FromSeconds(0.45));
            }
            else if (taskToRun.IsCanceled)
            {
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                // Tasku ka përfunduar me gabime ose ka kaluar timeout
                this.DialogResult = DialogResult.Retry;
                // Këtu mund të trajtoni gabimet ose timeout-in
                //MessageBox.Show("Procesi ka dështuar ju lutem provoni përsëri!", "Deshtoj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }
        async Task DelayAndSetResultAsync(DialogResult result, TimeSpan delay)
        {
            await Task.Delay(delay);
            this.DialogResult = result;
            this.Close();
        }
        private void LoadingScreenControl_Load(object sender, EventArgs e)
        {

        }
    }
}
