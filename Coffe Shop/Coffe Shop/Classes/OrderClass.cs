using Coffe_Shop.Classes.DataBase;
using Coffe_Shop.Classes.Employee;
using Coffe_Shop.Classes.Profile;
using Coffe_Shop.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace Coffe_Shop.Classes
{
    public class OrderClass
    {
        private PrintDocument printDocument;
        public string TotalPagesa { get; set; }
        ~OrderClass()
        {
        }
        string invoiceNumber = "INV_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
        public async Task InsertOrederData()
        {
            try
            {
                if (DatagridviewOrder.Order.Rows.Count == 0)
                {
                    throw new Exception("Ju lutem shtoni produktet në listën e prosive");
                    return;
                }

                if (VarClass.TableSelected == -1)
                {
                    throw new Exception("Ju lutem zgjidheni një tavolinë për porosi");
                    return;
                }



                foreach (DataGridViewRow item in DatagridviewOrder.Order.Rows)
                {
                    var param = new SqlParameter[]
                    {
                        new SqlParameter("@IdTavolina", VarClass.TableSelected),
                        new SqlParameter("@IdProdukti", int.Parse(item.Cells["Id"].Value.ToString())),
                        new SqlParameter("@Sasia", Convert.ToInt32(item.Cells["Quantity"].Value)),
                        new SqlParameter("@Ora", DateTime.Now.ToString("HH:mm")),
                        new SqlParameter("@IdPuntori", EmployDetails.GetId),
                        new SqlParameter("@Invoice",invoiceNumber)

                    };

                    await Task.Run(async () =>
                    {
                        await CRUDOperationsInterpretor.MethodAsync(new SQLDatabaseOperations().CRUDDataBaseWithParam, "AddNewOrders", param, FormParentElements.ParentForm);
                    });

                    await Task.Delay(100);
                }



                printDocument = new PrintDocument();
                printDocument.PrintPage += PrintDocument_PrintPage;

                string receiptName = $"RECEIPT-{DateTime.Now:ddMMyyyy-hhmmss}";
                printDocument.DocumentName = receiptName;

                PaperSize paperSize = new PaperSize("Statement", 550, 850);
                printDocument.DefaultPageSettings.PaperSize = paperSize;

                PrintFormDialog printFormDialog = new PrintFormDialog();
                if (printFormDialog.ShowDialog() != DialogResult.Yes)
                    return;

                // Kjo do të hapë dialogun e printimit
                PrintDialog printDialog = new PrintDialog
                {
                    Document = printDocument
                };


                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Define variables
            // Define variables
            string shopName = string.IsNullOrEmpty(CoffeProfileValues.Name) ? "COFFEE SHOP" : CoffeProfileValues.Name.ToUpper();
            string address = string.IsNullOrEmpty(CoffeProfileValues.Address) ? "N/A" : CoffeProfileValues.Address.ToUpper();
            string telFax = string.IsNullOrEmpty(CoffeProfileValues.Phone) ? "N/A" : CoffeProfileValues.Phone;
            string cashier = EmployDetails.EmpName;
            string receiptNo = invoiceNumber;
            string dateTime = DateTime.Now.ToString("dd/MM/yy | hh:mm tt");

            // Fonts and Brushes
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font subheaderFont = new Font("Arial", 11, FontStyle.Bold);
            Font font = new Font("Arial", 10);
            Font fontBold = new Font("Arial", 10, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 8, FontStyle.Italic);
            Brush brush = Brushes.Black;

            // Initial positions
            float y = 10;

            // Center align shop name
            SizeF shopNameSize = e.Graphics.MeasureString(shopName, headerFont);
            float centerX = (e.PageBounds.Width - shopNameSize.Width) / 2;
            e.Graphics.DrawString(shopName, headerFont, brush, centerX, y);
            y += shopNameSize.Height + 7;

            // Center align address
            SizeF addressSize = e.Graphics.MeasureString(address, font);
            centerX = (e.PageBounds.Width - addressSize.Width) / 2;
            e.Graphics.DrawString(address, font, brush, centerX, y);
            y += addressSize.Height;

            // Center align tel/fax
            SizeF telFaxSize = e.Graphics.MeasureString(telFax, font);
            centerX = (e.PageBounds.Width - telFaxSize.Width) / 2;
            e.Graphics.DrawString(telFax, font, brush, centerX, y);
            y += telFaxSize.Height + 10;

            // Center align receipt title
            SizeF receiptSize = e.Graphics.MeasureString("RECEIPT", subheaderFont);
            centerX = (e.PageBounds.Width - receiptSize.Width) / 2;
            e.Graphics.DrawString("RECEIPT", subheaderFont, brush, centerX, y);
            y += receiptSize.Height + 10;

            // Left align receipt details
            float x = 10;
            e.Graphics.DrawString($"Rcpt No: {receiptNo}", font, brush, x, y);

            SizeF cashierSize = e.Graphics.MeasureString($"Puntori: {cashier}", font);
            e.Graphics.DrawString($"Puntori: {cashier}", font, brush, e.PageBounds.Width - cashierSize.Width - 10, y);

            y += e.Graphics.MeasureString("Rcpt No: " + receiptNo, font).Height;
            e.Graphics.DrawString($"Data: {dateTime}", font, brush, x, y);
            y += e.Graphics.MeasureString("Data: " + dateTime, font).Height + 10;

            // Table headers
            e.Graphics.DrawString("Produkti", fontBold, brush, x, y);
            e.Graphics.DrawString("Sasia", fontBold, brush, x + 200, y);
            e.Graphics.DrawString("Qmimi", fontBold, brush, x + 300, y);
            y += e.Graphics.MeasureString("Produkti", fontBold).Height + 5;

            // Drawing the products data
            int sasiaTotal = 0;
            for (int i = 0; i < DatagridviewOrder.Order.Rows.Count; i++)
            {
                if (DatagridviewOrder.Order.Rows[i].Cells["Order"].Value != null &&
                    DatagridviewOrder.Order.Rows[i].Cells["Price"].Value != null)
                {
                    string order = DatagridviewOrder.Order.Rows[i].Cells["Order"].Value.ToString();
                    string quantity = DatagridviewOrder.Order.Rows[i].Cells["Quantity"].Value.ToString();
                    string price = DatagridviewOrder.Order.Rows[i].Cells["Price"].Value.ToString();

                    e.Graphics.DrawString(order, font, brush, x, y);
                    e.Graphics.DrawString(quantity, font, brush, x + 200, y);
                    e.Graphics.DrawString(price + "€", font, brush, x + 300, y);
                    y += e.Graphics.MeasureString(order, font).Height;
                    sasiaTotal += int.Parse(DatagridviewOrder.Order.Rows[i].Cells["Quantity"].Value.ToString());
                }
            }
            y += 20;

            // Drawing the totals and footer
            e.Graphics.DrawLine(Pens.Black, x, y, e.PageBounds.Width - 10, y);
            y += 5;
            e.Graphics.DrawString($"Total Sasia: {sasiaTotal}", font, brush, x, y);
            y += e.Graphics.MeasureString($"Total Quantity: {sasiaTotal}", font).Height;
            e.Graphics.DrawString($"Total: {TotalPagesa} ", font, brush, x, y);
            y += e.Graphics.MeasureString($"Total: {TotalPagesa}", font).Height;
            e.Graphics.DrawString($"TVSH: 0.00€", font, brush, x, y);
            y += e.Graphics.MeasureString("TVSH: 0.00€", font).Height;
            y += 20;

            // Thank you note
            SizeF thankYouSize = e.Graphics.MeasureString("Thank You!", subHeaderFont);
            centerX = (e.PageBounds.Width - thankYouSize.Width) / 2;
            e.Graphics.DrawString("Thank You!", subHeaderFont, brush, centerX, y);
            y += thankYouSize.Height;

            SizeF poweredBySize = e.Graphics.MeasureString("Powered by: V-Software", subHeaderFont);
            centerX = (e.PageBounds.Width - poweredBySize.Width) / 2;
            e.Graphics.DrawString("Powered by: V-Software", subHeaderFont, brush, centerX, y);
            y += poweredBySize.Height;

            SizeF contactSize = e.Graphics.MeasureString("Contact Us: desktopdevnet@gmail.com", subHeaderFont);
            centerX = (e.PageBounds.Width - contactSize.Width) / 2;
            e.Graphics.DrawString("Contact Us: desktopdevnet@gmail.com", subHeaderFont, brush, centerX, y);
            y += contactSize.Height;

            SizeF dateSize = e.Graphics.MeasureString(dateTime, subHeaderFont);
            centerX = (e.PageBounds.Width - dateSize.Width) / 2;
            e.Graphics.DrawString(dateTime, subHeaderFont, brush, centerX, y);
        }
    }
}
