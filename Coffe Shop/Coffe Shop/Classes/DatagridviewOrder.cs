using System.Data;

namespace Coffe_Shop.Classes
{
    public class DatagridviewOrder
    {
        public static DataGridView Order { get; set; }
        public static void AddRowsToGridview(int Id, string OrderName, decimal Price)
        {
            DataGridViewRow existingRow = Order.Rows
               .Cast<DataGridViewRow>()
               .FirstOrDefault(row => Convert.ToInt32(row.Cells["Id"].Value) == Id);

            if (existingRow != null)
            {
                // Produkti ekziston, rrit sasinë dhe llogarit totalin
                int currentQty = Convert.ToInt32(existingRow.Cells["Quantity"].Value);
                decimal price = Convert.ToDecimal(existingRow.Cells["Price"].Value);

                existingRow.Cells["Quantity"].Value = currentQty + 1;
                existingRow.Cells["Total"].Value = (currentQty + 1) * price;
            }
            else
            {
                Order.Rows.Add(Id, OrderName, 1, Price, 1 * Price);
            }
        }
        public static void ClearRows()
        {
            Order.Rows.Clear();
        }

    }
}
