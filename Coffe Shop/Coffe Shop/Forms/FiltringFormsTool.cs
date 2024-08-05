using System.Data;

namespace Coffe_Shop.Forms
{
    public partial class FiltringFormsTool : Form
    {

        DataTable dataTable;
        public DataGridView gridView = new DataGridView();
        public static int IsShow = 0;

        public FiltringFormsTool(DataGridView dataGrid)
        {
            InitializeComponent();
            dataTable = new DataTable();
            dataTable = (DataTable)dataGrid.DataSource;
            gridView = dataGrid;
        }

        private void FiltringFormsTool_Load(object sender, EventArgs e)
        {
            CheckfortypeOf();
        }
        void CheckfortypeOf()
        {
            // To get all columns in combobox depends of their datatype
            comboDate.Items.Clear();
            cb2date.Items.Clear();
            cb2Date1.Items.Clear();
            try
            {
                foreach (DataColumn col in dataTable.Columns)
                {
                    if (gridView.Columns[col.ColumnName.ToString()].Visible == false)
                        continue;

                    if (col.DataType == typeof(DateTime))
                    {
                        comboDate.Items.Add(col.ColumnName.ToString());
                        cb2date.Items.Add(col.ColumnName.ToString());
                        cb2Date1.Items.Add(col.ColumnName.ToString());
                    }
                    else if (col.DataType == typeof(string) && col.ColumnName != "Password")
                    {
                        cbGroup.Items.Add(col.ColumnName.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                SetDefaultValue();
                return;
            }

            if (gridView.DataSource != null && gridView.DataSource is DataTable)
            {
                DataTable tabela = (DataTable)gridView.DataSource;

                //Get Value for filtring
                string filterValue = txtName.Text;


                //Create list to get all the columns
                List<string> colHaders = new List<string>();

                foreach (DataColumn col in tabela.Columns)
                {
                    if (col.DataType != typeof(DateTime))
                    {
                        // Forech column get their name
                        colHaders.Add($"Convert([{col.ColumnName}], 'System.String') LIKE '%{filterValue}%'");
                    }
                }

                // Përdor String.Join për të krijuar shprehjen përgjithëse të filtrimi duke përdorur 'OR' operatorin
                string FilterApplied = string.Join(" OR ", colHaders);
                // Apliko filtrimin në DefaultView të DataTable
                tabela.DefaultView.RowFilter = FilterApplied;

                gridView.Refresh();
            }

        }
        void SetDefaultValue()
        {
            DataTable tabela = (DataTable)gridView.DataSource;
            tabela.DefaultView.RowFilter = string.Empty;
            gridView.Refresh();
        }

        private void setRowsByValues(string colName, object Values)
        {
            DataTable tabela = (DataTable)gridView.DataSource;

            string filter = $"Convert([{colName}], 'System.String') LIKE '%{Values.ToString()}%'";
            tabela.DefaultView.RowFilter = filter;

            gridView.Refresh();
        }
        private void FilterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Action action = () =>
            {
                SetDefaultValue();
            };
            action.Invoke();
        }

        private void cbGroup_TextChanged(object sender, EventArgs e)
        {
            if (cbGroup.Text == "----")
            {
                cbGValues.Items.Clear();
                cbGValues.Text = "----";
                SetDefaultValue();
                return;
            }


            //First clear all Values
            cbGValues.Items.Clear();


            //Then get all values from rows and check if they are not in cbGValues
            var valuesToAdd = dataTable.AsEnumerable()
                            .Select(row => row.Field<string>(cbGroup.Text.Trim()))
                            .Where(value => cbGValues.Items.Contains(value) == false)
                            .ToList();


            //Check Again for the values
            foreach (var value in valuesToAdd)
            {
                if (!cbGValues.Items.Contains(value))
                {
                    cbGValues.Items.Add(value);
                }
            }
        }
        private void cbGValues_TextChanged(object sender, EventArgs e)
        {
            if (cbGValues.Text == "----")
            {
                SetDefaultValue();
                return;
            }
            setRowsByValues(cbGroup.Text.Trim(), cbGValues.Text.Trim());// Set Rows Visible for specific Column
        }
        private void cbGroup_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void btnCheckBetweenTwoDates_Click(object sender, EventArgs e)
        {
            DataTable tabela = (DataTable)gridView.DataSource;

            if (cb2date.Text == "----" || cb2Date1.Text == "----")
            {
                MessageBox.Show("Ju lutem shikoni datat !!!", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetDefaultValue();
            }
            else
            {
                // Përditësojeni emrin e kolonës për të përshtatur me TextBox
                string FilterApplied = $"Convert([{cb2date.Text.Trim()}], 'System.DateTime') >= #{dtStart.Value.Date}# AND Convert([{cb2Date1.Text.Trim()}], 'System.DateTime') <= #{dtEnd.Value.Date}#";

                // Apliko filtrimin në DefaultView të DataTable
                tabela.DefaultView.RowFilter = FilterApplied;
            }

            // Rifresko DataGridView për të pasqyruar rezultatin e filtrimit
            gridView.Refresh();
        }

        private void btnktheu_Click(object sender, EventArgs e)
        {
            SetDefaultValue();
            comboDate.Text = cbGroup.Text = cb2date.Text = cb2Date1.Text = "----";
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            DataTable tabela = (DataTable)gridView.DataSource;

            if (comboDate.Text == "----")
            {
                MessageBox.Show("Ju lutem shikoni datat !!!", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetDefaultValue();
                return;
            }

            // Përditësojeni emrin e kolonës për të përshtatur me TextBox
            string FilterApplied = getQuerry(cbUnit.Text);
            // Apliko filtrimin në DefaultView të DataTable
            tabela.DefaultView.RowFilter = FilterApplied;
            // Rifresko DataGridView për të pasqyruar rezultatin e filtrimit
            gridView.Refresh();
        }
        private string getQuerry(string text)
        {
            switch (text)
            {
                case "=":
                    return $"Convert([{comboDate.Text.Trim()}], 'System.DateTime') = #{dateTimePicker3.Value.Date}#";
                    break;
                case ">":
                    return $"Convert([{comboDate.Text.Trim()}], 'System.DateTime') > #{dateTimePicker3.Value.Date}#";
                    break;
                case "<":
                    return $"Convert([{comboDate.Text.Trim()}], 'System.DateTime') < #{dateTimePicker3.Value.Date}#";
                    break;
                case ">=":
                    return $"Convert([{comboDate.Text.Trim()}], 'System.DateTime') >= #{dateTimePicker3.Value.Date}#";
                    break;
                case "<=":
                    return $"Convert([{comboDate.Text.Trim()}], 'System.DateTime') <= #{dateTimePicker3.Value.Date}#";
                    break;
            }
            return "";
        }
    }
}
