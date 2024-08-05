using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe_Shop.Classes
{
    public class LoadingScreenDialog
    {
        static LoadingScreenControl screen;
        public static async Task ShowLoadingScreen(Task task, string Title, Control parent)
        {
            parent.Enabled = false;
            Form parentForm = parent.FindForm();
            // Nëse është Form, shfaq loading screen si dialog
            screen = new LoadingScreenControl(task, Title, parent);
            screen.ShowDialog(parentForm);
            parent.Enabled = true;

        }
    }
}
