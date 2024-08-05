using Coffe_Shop.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe_Shop.Classes
{
    public static class ShowFiltringFormTool
    {
        /// <summary>
        /// Show Filter dialog in form when button clicked
        /// </summary>
        /// <param name="btnFilter"></param>
        /// <returns></returns>
        /// 
        private static FiltringFormsTool activeFilterForm;
        public static void ShowFiltringFormDialog(Button btnFilter, DataGridView gridView)
        {
            Point koordinatatButton = btnFilter.PointToScreen(new Point(0, 0));

            // Nëse ka një formë aktive, mbylleni atë
            //if (activeFilterForm != null && !activeFilterForm.IsDisposed && activeFilterForm.Visible)
            //{
            //    activeFilterForm.Close();
            //}

            // Krijo një formë të re nqs nuk është shfaqur tashmë
            if (activeFilterForm == null || activeFilterForm.IsDisposed || activeFilterForm.gridView != gridView)
            {
                CloseFormWithForce();
                var newFilterForm = new FiltringFormsTool(gridView);
                activeFilterForm = newFilterForm;

                // Vendos pozicionin e formës duke përdorur koordinatat relative
                newFilterForm.Location = new System.Drawing.Point(koordinatatButton.X - newFilterForm.Width, koordinatatButton.Y + btnFilter.Height);

                // Thirr formën si një dialog
                newFilterForm.Show();
            }
            else
            {
                // Nëse forma është shfaqur, bëni BringToFront
                activeFilterForm.BringToFront();
            }
        }
        public static void CloseFormWithForce()
        {
            if (activeFilterForm != null && !activeFilterForm.IsDisposed)
            {
                activeFilterForm.Close();
            }
        }
    }
}
