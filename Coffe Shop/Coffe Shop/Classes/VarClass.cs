using Coffe_Shop.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Coffe_Shop.Classes
{
    public class VarClass
    {
        //Per te marr ne list per cdo kategori qe selektohet per produktin 
        public static Dictionary<int, string> categoriesPerProduct = new Dictionary<int, string>();
        public static int TableSelected = -1;

        /// <summary>
        /// Nese pagesa e shte kryer me sukses
        /// </summary>
        public static bool PaymentSuccessfully = false;
        public static decimal Payment, Returns;


        /// <summary>
        /// Lista e produkteve te porositura nga klienti
        /// </summary>
        public static List<ProduktetEPorositura> Produktes = new List<ProduktetEPorositura>();


        /// <summary>
        /// Paraqitja e formes ndihmese
        /// </summary>
        /// <param name="userControl"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public static DialogResult ShowUseForm(UserControl userControl, string title)
        {
            var frm = new UseForm(userControl, title);
            return frm.ShowDialog();
        }



        /// <summary>
        /// Paraqitja e forms per pages
        /// </summary>
        /// <param name="IdTavolina"></param>
        /// <param name="total"></param>
        /// <param name="Puntori"></param>
        /// <param name="tavolina"></param>
        /// <param name="ora"></param>
        /// <param name="Date"></param>
        /// <param name="IdPuntori"></param>
        /// <returns></returns>
        public static DialogResult ShowOweForm(int IdTavolina, decimal total, string Puntori, string tavolina, string ora, string Date, int IdPuntori)
        {
            var owe = new TotalPages(IdTavolina, total, Puntori, tavolina, ora, Date, IdPuntori);
            return owe.ShowDialog();
        }




        //
        public static void ChangeControlsSize(UserControl user)
        {
            // Përcaktoni madhësinë e tekstit bazuar në madhësinë e ekranit
            float newSize = user.Width / 30; // Mund ta ndryshoni formulan bazuar në preferencat tuaja

            // Parandaloni madhësinë të bëhet shumë e vogël ose shumë e madhe
            newSize = Math.Max(newSize, 6); // Madhësia minimale e tekstit
            newSize = Math.Min(newSize, 24); // Madhësia maksimale e tekstit

            // Përditësoni madhësinë e tekstit në label
            foreach (Control control in user.Controls)
            {
                if (control is TextBox txt)
                {
                    txt.Font = new System.Drawing.Font(txt.Font.FontFamily, newSize);
                }
                else if (control is Label lbl)
                {
                    lbl.Font = new System.Drawing.Font(lbl.Font.FontFamily, newSize);
                }
            }
        }


        /// <summary>
        /// Ndryshimi i size te kolones specifike ne listen e parametrave dhe ndryshimi ne auto size te kolonave  te tjera
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="columnName"></param>
        /// <param name="fixedWidth"></param>
        public static void ResizeDatagrideViewColumns(DataGridView dataGridView, string columnName, int fixedWidth)
        {
            // Përditësoj kolonën e caktuar për "wrap mode"
            //DataGridViewColumn targetColumn = dataGridView.Columns[columnName];
            //targetColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            //// Itero nëpër kolonat dhe përditësoj vetëm kolonën e caktuar
            //foreach (DataGridViewColumn column in dataGridView.Columns)
            //{
            //    if (column == targetColumn)
            //    {
            //        //column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //        //column.MinimumWidth = Math.Min(fixedWidth, column.Width);
            //        //column.FillWeight = 1;
            //    }
            //    else
            //    {
            //        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //    }
            //}

            //// Përditëso DataGridView
            //dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            //// Rikthej kolonën e caktuar në "Fill" mode
            //targetColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }




        /// <summary>
        /// Mundeson qe formen ta bej me bukur me corner te lakuara
        /// </summary>
        /// <param name="pictureBox"></param>
        /// <param name="cornerRadius"></param>
        public static void SetCornerRadius(PictureBox pictureBox, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(pictureBox.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(pictureBox.Width - cornerRadius, pictureBox.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, pictureBox.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseFigure();

            pictureBox.Region = new Region(path);
        }

        /// <summary>
        /// Merr fotografin nga byte array
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static System.Drawing.Image GetImageFromByte(byte[] bytes)
        {
            using (MemoryStream stream = new MemoryStream(bytes))
            {
                return System.Drawing.Image.FromStream(stream);
            }
        }


        /// <summary>
        /// Konverton fotografin ne byte array
        /// </summary>
        /// <param name="image"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static byte[] ConvertImageToByteArray(Image image, ImageFormat format)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, format);
                return memoryStream.ToArray();
            }
        }

        public struct ElementsItem
        {
            public static int IdElement;
            //public static string ProductName;
            //public static string Supplier;
            //public static int Qty;
            //public static string Unit;
            //public static decimal SalePrice;
            //public static decimal PurchasePrice;
            //public static DateTime ExpDate;
            //public static DateTime DtRegistration;
            //public static string Ora;
            //public static string Status;
            //public static string ProductDescription;
            //public static byte[] blob;
        }
    }
    public class ProduktetEPorositura
    {
        public string EmriProduktit;
        public int IdProdukti;
        public decimal Qmimi;
        public int Sasia;
        public string InvoiceNumber;
    }
}
