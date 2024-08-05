namespace Coffe_Shop.UserControls.SalesElement
{
    partial class SaleDetails
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblTotal = new Label();
            lblInvoice = new Label();
            lblPini = new Label();
            label2 = new Label();
            picBack = new PictureBox();
            lblTitle = new Label();
            lblPuntori = new Label();
            label3 = new Label();
            dataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Fatura = new DataGridViewTextBoxColumn();
            Table = new DataGridViewTextBoxColumn();
            Sasia = new DataGridViewTextBoxColumn();
            Product = new DataGridViewTextBoxColumn();
            Ora = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Change = new DataGridViewTextBoxColumn();
            label7 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblKusuri = new Label();
            btnFshije = new Button();
            txtSearch = new TextBox();
            picRefresh = new PictureBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRefresh).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(lblTotal);
            flowLayoutPanel1.Controls.Add(lblInvoice);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(427, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(374, 146);
            flowLayoutPanel1.TabIndex = 32;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Poppins", 35.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.SeaGreen;
            lblTotal.Location = new Point(197, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(174, 84);
            lblTotal.TabIndex = 30;
            lblTotal.Text = "0.00€";
            // 
            // lblInvoice
            // 
            lblInvoice.AutoSize = true;
            lblInvoice.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInvoice.ForeColor = Color.IndianRed;
            lblInvoice.Location = new Point(191, 0);
            lblInvoice.Name = "lblInvoice";
            lblInvoice.Size = new Size(0, 37);
            lblInvoice.TabIndex = 31;
            // 
            // lblPini
            // 
            lblPini.AutoSize = true;
            lblPini.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPini.ForeColor = Color.White;
            lblPini.Location = new Point(164, 190);
            lblPini.Name = "lblPini";
            lblPini.Size = new Size(24, 30);
            lblPini.TabIndex = 41;
            lblPini.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(163, 156);
            label2.Name = "label2";
            label2.Size = new Size(116, 30);
            label2.TabIndex = 40;
            label2.Text = "Pini Puntorit:";
            // 
            // picBack
            // 
            picBack.Cursor = Cursors.Hand;
            picBack.Image = Properties.Resources.icons8_back_35;
            picBack.Location = new Point(10, 19);
            picBack.Name = "picBack";
            picBack.Size = new Size(35, 35);
            picBack.SizeMode = PictureBoxSizeMode.AutoSize;
            picBack.TabIndex = 43;
            picBack.TabStop = false;
            picBack.Click += picBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(168, 37);
            lblTitle.TabIndex = 42;
            lblTitle.Text = "Shitja '#Table1'";
            // 
            // lblPuntori
            // 
            lblPuntori.AutoSize = true;
            lblPuntori.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPuntori.ForeColor = Color.White;
            lblPuntori.Location = new Point(11, 190);
            lblPuntori.Name = "lblPuntori";
            lblPuntori.Size = new Size(117, 30);
            lblPuntori.TabIndex = 45;
            lblPuntori.Text = "------ -----";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 156);
            label3.Name = "label3";
            label3.Size = new Size(124, 30);
            label3.TabIndex = 44;
            label3.Text = "Emri Puntorit:";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(148, 128, 203);
            dataGridViewCellStyle1.Font = new Font("Poppins", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(148, 128, 203);
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.FromArgb(69, 43, 134);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(69, 43, 134);
            dataGridViewCellStyle2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(69, 43, 134);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Fatura, Table, Sasia, Product, Ora, Price, Total, Change });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(69, 43, 134);
            dataGridViewCellStyle3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(69, 43, 134);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.GridColor = Color.FromArgb(69, 43, 134);
            dataGridView.Location = new Point(0, 296);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(69, 43, 134);
            dataGridViewCellStyle4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(69, 43, 134);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(69, 43, 134);
            dataGridViewCellStyle5.Font = new Font("Poppins", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(69, 43, 134);
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(801, 360);
            dataGridView.TabIndex = 47;
            // 
            // Id
            // 
            Id.HeaderText = "Num";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // Fatura
            // 
            Fatura.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Fatura.HeaderText = "Fatura";
            Fatura.Name = "Fatura";
            Fatura.Width = 200;
            // 
            // Table
            // 
            Table.HeaderText = "Produkti";
            Table.Name = "Table";
            // 
            // Sasia
            // 
            Sasia.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Sasia.HeaderText = "Sasia";
            Sasia.Name = "Sasia";
            Sasia.Width = 80;
            // 
            // Product
            // 
            Product.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Product.HeaderText = "Tavolina";
            Product.Name = "Product";
            Product.Width = 80;
            // 
            // Ora
            // 
            Ora.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Ora.HeaderText = "Ora";
            Ora.Name = "Ora";
            Ora.Width = 50;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Price.HeaderText = "Cmimi";
            Price.Name = "Price";
            Price.Width = 80;
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.Width = 80;
            // 
            // Change
            // 
            Change.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Change.HeaderText = "Kusuri";
            Change.Name = "Change";
            Change.Width = 80;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(2, 263);
            label7.Name = "label7";
            label7.Size = new Size(171, 30);
            label7.TabIndex = 46;
            label7.Text = "Lista e Produkteve:";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel2.Controls.Add(lblKusuri);
            flowLayoutPanel2.Location = new Point(3, 667);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(563, 31);
            flowLayoutPanel2.TabIndex = 50;
            // 
            // lblKusuri
            // 
            lblKusuri.AutoSize = true;
            lblKusuri.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblKusuri.ForeColor = Color.White;
            lblKusuri.Location = new Point(3, 0);
            lblKusuri.Name = "lblKusuri";
            lblKusuri.Size = new Size(148, 30);
            lblKusuri.TabIndex = 49;
            lblKusuri.Text = "Total Kusur: 000";
            // 
            // btnFshije
            // 
            btnFshije.Anchor = AnchorStyles.Bottom;
            btnFshije.BackColor = Color.FromArgb(192, 0, 0);
            btnFshije.Cursor = Cursors.Hand;
            btnFshije.FlatStyle = FlatStyle.Flat;
            btnFshije.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFshije.ForeColor = Color.White;
            btnFshije.Location = new Point(711, 662);
            btnFshije.Name = "btnFshije";
            btnFshije.Size = new Size(87, 40);
            btnFshije.TabIndex = 51;
            btnFshije.Tag = "1";
            btnFshije.Text = "Fshije";
            btnFshije.TextImageRelation = TextImageRelation.TextAboveImage;
            btnFshije.UseVisualStyleBackColor = false;
            btnFshije.Visible = false;
            btnFshije.Click += btnFshije_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(527, 265);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search...";
            txtSearch.Size = new Size(247, 23);
            txtSearch.TabIndex = 52;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // picRefresh
            // 
            picRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picRefresh.Cursor = Cursors.Hand;
            picRefresh.Image = Properties.Resources.icons8_refresh_38;
            picRefresh.Location = new Point(775, 263);
            picRefresh.Name = "picRefresh";
            picRefresh.Size = new Size(26, 26);
            picRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            picRefresh.TabIndex = 53;
            picRefresh.TabStop = false;
            picRefresh.Click += picRefresh_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel3.Controls.Add(lblTitle);
            flowLayoutPanel3.Location = new Point(51, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(374, 146);
            flowLayoutPanel3.TabIndex = 54;
            // 
            // SaleDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 43, 134);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(picRefresh);
            Controls.Add(txtSearch);
            Controls.Add(btnFshije);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(dataGridView);
            Controls.Add(label7);
            Controls.Add(lblPuntori);
            Controls.Add(label3);
            Controls.Add(picBack);
            Controls.Add(lblPini);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Name = "SaleDetails";
            Size = new Size(804, 712);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRefresh).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblTotal;
        private Label lblInvoice;
        private Label lblPini;
        private Label label2;
        private PictureBox picBack;
        private Label lblTitle;
        private Label lblPuntori;
        private Label label3;
        private DataGridView dataGridView;
        private Label label7;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label4;
        private Button btnFshije;
        private Label lblKusuri;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Fatura;
        private DataGridViewTextBoxColumn Table;
        private DataGridViewTextBoxColumn Sasia;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Ora;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Change;
        private TextBox txtSearch;
        private PictureBox picRefresh;
        private FlowLayoutPanel flowLayoutPanel3;
    }
}
