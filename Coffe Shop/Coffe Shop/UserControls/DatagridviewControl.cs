using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;
using System.Data;

namespace Coffe_Shop.UserControls
{
    public partial class DatagridviewControl : UserControl
    {
        public enum Buttonat
        {
            Save, Delte, Both, Unvisible
        }
        string querry = "";
        string colName = "";
        int size = 0;
        int[] rowIndexHide = null;
        public Action<int> action = null;
        public Action<int, DateTime> selectSale = null;
        public DatagridviewControl(DataTable source, Buttonat buttonat, Action<int> action)
        {
            InitializeComponent();
            dataGridView.DataSource = source;
            GetVisibleButtons(buttonat);
            this.action = action;
        }
        public DatagridviewControl(DataTable source, Buttonat buttonat, Action<int> action, string Querry, int[] rowIndexHide, string colName, int fixSize)
        {
            InitializeComponent();
            dataGridView.DataSource = source;
            GetVisibleButtons(buttonat);
            this.action = action;
            querry = Querry;
            this.rowIndexHide = rowIndexHide;
            this.colName = colName;
            size = fixSize;
        }
        public DatagridviewControl(DataTable source, Buttonat buttonat, Action<int, DateTime> action, string Querry, int[] rowIndexHide, string colName, int fixSize)
        {
            InitializeComponent();
            dataGridView.DataSource = source;
            GetVisibleButtons(buttonat);
            selectSale = action;
            querry = Querry;
            this.rowIndexHide = rowIndexHide;
            this.colName = colName;
            size = fixSize;
        }

        private void GetVisibleButtons(Buttonat buttonat)
        {
            switch (buttonat)
            {
                case Buttonat.Save:
                    btnRuaj.Visible = true;
                    btnRuaj.Location = btnFshije.Location;
                    btnFshije.Visible = false;
                    break;
                case Buttonat.Delte:
                    btnRuaj.Visible = false;
                    btnFshije.Visible = true;
                    break;
                case Buttonat.Both:
                    btnRuaj.Visible = true;
                    btnFshije.Visible = true;
                    break;
                case Buttonat.Unvisible:
                    btnRuaj.Visible = false;
                    btnFshije.Visible = false;
                    break;
                default:
                    break;
            }
        }

        public DataGridView gridView { get => dataGridView; }
        private void DatagridviewControl_Load(object sender, EventArgs e)
        {
            ShowPanel();

        }
        public void SetColumnsSize(string columnName, int fixedWidth)
        {
            VarClass.ResizeDatagrideViewColumns(dataGridView, columnName, fixedWidth);
        }
        void ShowPanel()
        {
            if (dataGridView.Rows.Count == 0)
            {
                panelError.Visible = true;
            }
            else
            {
                panelError.Visible = false;
            }
        }

        private void dataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTotal.Text = "Total Rreshta: " + dataGridView.Rows.Count;
            ShowPanel();
        }

        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTotal.Text = "Total Rreshta: " + dataGridView.Rows.Count;
            ShowPanel();
        }

        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView.Rows[e.RowIndex].Height = 40;
        }

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == -1)
            {
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kontrollo se a është klikuar rreshti dhe jo ndonjë header ose kolonë tjetër
            if (e.RowIndex >= 0)
            {
                // Merr vlerat e të gjitha kolonave në rreshtin e zgjedhur
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];


                if (selectSale != null)
                {
                    selectSale?.Invoke((int)selectedRow.Cells[0].Value, (DateTime)selectedRow.Cells[2].Value);
                }
                else
                {
                    action?.Invoke((int)selectedRow.Cells[0].Value);
                }
            }
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            if (querry != "")
            {
                try
                {
                    TaskAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private async Task TaskAsync()
        {
            gridView.DataSource = await CRUDOperationsInterpretor.MethodAsyncTable(new SQLDatabaseOperations().SelectDataAsync, querry, "Po ngarkohen...", this);
            foreach (int item in rowIndexHide)
            {
                gridView.Columns[item].Visible = false;
            }
            SetColumnsSize(colName, size);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowFiltringFormTool.ShowFiltringFormDialog(button1, dataGridView);
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {

        }
    }
}
