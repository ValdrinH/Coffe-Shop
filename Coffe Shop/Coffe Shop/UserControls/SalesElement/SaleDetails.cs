using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;
using System.Data;

namespace Coffe_Shop.UserControls.SalesElement
{
    public partial class SaleDetails : UserControl
    {
        private readonly int _id;
        private readonly DateTime _date;
        private DataTable originalDataTable = new DataTable(); // Ruani të dhënat origjinale

        public SaleDetails(int userID, DateTime date)
        {
            InitializeComponent();
            _id = userID;
            _date = date;
        }

        protected override void OnLoad(EventArgs e)
        {
            GetTaskAsync();
            base.OnLoad(e);
        }

        private async Task GetTaskAsync()
        {
            try
            {
                DataTable dt = await CRUDOperationsInterpretor.MethodAsyncTable(new SQLDatabaseOperations().SelectDataAsync, $"Exec LoadSales @Id = {_id}, @Date ='{_date.Date}'", "Po ngarkohen...", this);
                originalDataTable = dt.Copy(); // Ruani të dhënat origjinale
                LoadDataIntoGridView(dt);

                DataRow firstRow = dt.AsEnumerable().First();
                string totalSum = dt.AsEnumerable()
                          .Sum(row => row.Field<decimal>("Cmimi")).ToString() + "€";
                lblPini.Text = firstRow.Field<int>("Kartela").ToString();
                lblPuntori.Text = firstRow.Field<string>("Employee");
                lblTotal.Text = totalSum;
                lblTitle.Text = "Shitjet e " + firstRow.Field<string>("Employee") + " me datën " + _date.ToString("dd MMM, yyyy");
                decimal kusuriSum = dt.AsEnumerable()
                               .Sum(row => row.Field<decimal>("Kusuri"));

                lblKusuri.Text = "Total Kusur: " + kusuriSum.ToString("0.00") + "€";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadDataIntoGridView(DataTable dt)
        {
            dataGridView.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dataGridView.Rows.Add(row["#Id"], row["Fatura"], row["EmriProduktit"], row["Sasia"], row["TableName"], row["OraShitjes"], row["Cmimi"], row["TotalPrice"], row["Kusuri"]);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                // Kur TextBox është zbrazët, kthe të dhënat origjinale
                LoadDataIntoGridView(originalDataTable);
            }
            else
            {
                // Filtroni DataTable sipas TextBox
                DataTable filteredTable = originalDataTable.Clone(); // Kopjoni strukturën e tabelës origjinale
                string filterExpression = string.Join(" OR ", originalDataTable.Columns.Cast<DataColumn>()
                    .Select(col => $"Convert([{col.ColumnName}], 'System.String') LIKE '%{searchText}%'"));

                // Apliko filtrimin në DefaultView
                originalDataTable.DefaultView.RowFilter = filterExpression;

                // Kopjoni të dhënat e filtruar në tabelën e filtruar
                foreach (DataRowView rowView in originalDataTable.DefaultView)
                {
                    filteredTable.ImportRow(rowView.Row);
                }

                // Rifreskoni DataGridView me të dhënat e filtruar
                LoadDataIntoGridView(filteredTable);
            }
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            FormParentElements.GoToBackControl();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void btnFshije_Click(object sender, EventArgs e)
        {

        }
    }
}
