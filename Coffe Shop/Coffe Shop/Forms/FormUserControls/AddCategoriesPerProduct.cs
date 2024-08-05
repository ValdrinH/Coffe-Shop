using Coffe_Shop.Classes;
using Coffe_Shop.Classes.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Coffe_Shop.Forms.FormUserControls
{
    public partial class AddCategoriesPerProduct : UserControl
    {
        public AddCategoriesPerProduct()
        {
            InitializeComponent();
        }

        private void AddCategoriesPerProduct_Load(object sender, EventArgs e)
        {
            LoadAllCategories();
        }

        private async Task LoadAllCategories()
        {
            try
            {
                DataTable dt = await CRUDOperationsInterpretor.MethodAsyncTable(new SQLDatabaseOperations().SelectDataAsync, "LoadAllCategories", "Po ngarkohen të dhënat...", this);

                foreach (DataRow dr in dt.Rows)
                {
                    var createLabel = () =>
                    {
                        var lbl = new Label()
                        {
                            Text = dr[1].ToString(),
                            Font = new Font("Poppins", 15, FontStyle.Regular),
                            FlatStyle = FlatStyle.Flat, // Përcakton stilin flat të Button
                            BackColor = Color.White,    // Përcakton ngjyrën e sfondit të Button (ndryshoni sipas dëshirës)
                            ForeColor = Color.Black,    // Përcakton ngjyrën e tekstit të Button (ndryshoni sipas dëshirës)
                            AutoSize = true,            // Bën që madhësia e Button të përshtatet automatikisht bazuar në tekst
                            Tag = int.Parse(dr[0].ToString()),
                            Cursor = Cursors.Hand,
                        };
                        lbl.Click += Lbl_Click;
                        return lbl;
                    };
                    Label label = createLabel();

                    //Kontrollohet nese ka ne list 
                    if (VarClass.categoriesPerProduct.Count > 0)
                    {
                        foreach (int item in VarClass.categoriesPerProduct.Keys)
                        {
                            if (item == int.Parse(label.Tag.ToString()))
                            {
                                label.BackColor = Color.FromArgb(148, 128, 203);
                                label.ForeColor = Color.White;
                            }
                        }
                    }

                    flowLayoutPanel.Controls.Add(label);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Lbl_Click(object? sender, EventArgs e)
        {
            var lbl = (Label)sender;

            var result = VarClass.categoriesPerProduct.FirstOrDefault(pair => pair.Key == int.Parse(lbl.Tag.ToString()));
            if (result.Key == int.Parse(lbl.Tag.ToString()))
            {
                lbl.BackColor = Color.White; // Përcakton ngjyrën e sfondit të Button (ndryshoni sipas dëshirës)
                lbl.ForeColor = Color.Black;
                VarClass.categoriesPerProduct.Remove(int.Parse(lbl.Tag.ToString()));

                return;
            }

            lbl.BackColor = Color.FromArgb(148, 128, 203);
            lbl.ForeColor = Color.White;

            VarClass.categoriesPerProduct.Add(int.Parse(lbl.Tag.ToString()), lbl.Text);
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            this.Parent.FindForm().DialogResult = DialogResult.OK;
        }

        private void txtKerkimi_TextChanged(object sender, EventArgs e)
        {
            var list = flowLayoutPanel.Controls.OfType<Label>().ToList();
            if (txtKerkimi.Text == "")
            {
                list.ForEach(label =>
                {
                    Visible = true;
                });
                return;
            }
            list.ForEach(label =>
            {
                Visible = (label.Text.ToLower().Contains(txtKerkimi.Text.ToLower()));
            });
        }
    }
}
