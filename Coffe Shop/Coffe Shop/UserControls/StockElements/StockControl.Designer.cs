namespace Coffe_Shop.UserControls.StockElements
{
    partial class StockControl
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
            picBack = new PictureBox();
            label2 = new Label();
            txtEmri = new TextBox();
            label1 = new Label();
            button1 = new Button();
            lblCategories = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtSkadimit = new DateTimePicker();
            label7 = new Label();
            txtPershkrimi = new TextBox();
            label8 = new Label();
            picProduct = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtQmimiB = new TextBox();
            txtQmimiSh = new TextBox();
            label10 = new Label();
            cbStatusi = new ComboBox();
            btnRuaj = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            cbNjesia = new ComboBox();
            label11 = new Label();
            txtFunrizuesi = new TextBox();
            label13 = new Label();
            txtSasia = new MaskedTextBox();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)picBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // picBack
            // 
            picBack.Cursor = Cursors.Hand;
            picBack.Image = Properties.Resources.icons8_back_35;
            picBack.Location = new Point(13, 22);
            picBack.Name = "picBack";
            picBack.Size = new Size(35, 35);
            picBack.SizeMode = PictureBoxSizeMode.AutoSize;
            picBack.TabIndex = 27;
            picBack.TabStop = false;
            picBack.Click += picBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 22);
            label2.Name = "label2";
            label2.Size = new Size(236, 37);
            label2.TabIndex = 26;
            label2.Text = "Shto produkte të reja\r\n";
            // 
            // txtEmri
            // 
            txtEmri.BackColor = Color.FromArgb(148, 128, 203);
            txtEmri.BorderStyle = BorderStyle.None;
            txtEmri.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmri.ForeColor = Color.White;
            txtEmri.Location = new Point(16, 120);
            txtEmri.MaximumSize = new Size(413, 24);
            txtEmri.Name = "txtEmri";
            txtEmri.PlaceholderText = "Emri i Produktit";
            txtEmri.Size = new Size(345, 24);
            txtEmri.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 87);
            label1.Name = "label1";
            label1.Size = new Size(133, 30);
            label1.TabIndex = 29;
            label1.Text = "Emri Produktit:";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(16, 165);
            button1.Name = "button1";
            button1.Size = new Size(50, 34);
            button1.TabIndex = 30;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategories.ForeColor = Color.White;
            lblCategories.Location = new Point(72, 167);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(109, 30);
            lblCategories.TabIndex = 31;
            lblCategories.Text = "Kategorit: 0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(149, 25);
            label4.TabIndex = 33;
            label4.Text = "Emri Furnizuesit:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(135, 25);
            label5.TabIndex = 35;
            label5.Text = "Qmimi blerjes:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(169, 0);
            label6.Name = "label6";
            label6.Size = new Size(133, 25);
            label6.TabIndex = 37;
            label6.Text = "Qmimi shitjes:";
            // 
            // dtSkadimit
            // 
            dtSkadimit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtSkadimit.CalendarFont = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtSkadimit.CustomFormat = "dd MMM yyyy";
            dtSkadimit.Format = DateTimePickerFormat.Custom;
            dtSkadimit.Location = new Point(335, 28);
            dtSkadimit.Name = "dtSkadimit";
            dtSkadimit.Size = new Size(193, 23);
            dtSkadimit.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(335, 0);
            label7.Name = "label7";
            label7.Size = new Size(150, 25);
            label7.TabIndex = 39;
            label7.Text = "Data e skadimit:";
            // 
            // txtPershkrimi
            // 
            txtPershkrimi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPershkrimi.BackColor = Color.FromArgb(148, 128, 203);
            txtPershkrimi.BorderStyle = BorderStyle.None;
            txtPershkrimi.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPershkrimi.ForeColor = Color.White;
            txtPershkrimi.Location = new Point(13, 415);
            txtPershkrimi.Multiline = true;
            txtPershkrimi.Name = "txtPershkrimi";
            txtPershkrimi.PlaceholderText = "Përshkimi";
            txtPershkrimi.ScrollBars = ScrollBars.Vertical;
            txtPershkrimi.Size = new Size(750, 210);
            txtPershkrimi.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(13, 387);
            label8.Name = "label8";
            label8.Size = new Size(105, 30);
            label8.TabIndex = 41;
            label8.Text = "Përshkrimi:";
            // 
            // picProduct
            // 
            picProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picProduct.BorderStyle = BorderStyle.FixedSingle;
            picProduct.Cursor = Cursors.Hand;
            picProduct.Image = Properties.Resources.Screenshot_2023_12_16_163657;
            picProduct.Location = new Point(547, 22);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(205, 193);
            picProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            picProduct.TabIndex = 42;
            picProduct.TabStop = false;
            picProduct.Click += picProduct_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222176F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222233F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.0666676F));
            tableLayoutPanel1.Controls.Add(txtQmimiB, 0, 1);
            tableLayoutPanel1.Controls.Add(txtQmimiSh, 1, 1);
            tableLayoutPanel1.Controls.Add(label10, 3, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Controls.Add(label6, 1, 0);
            tableLayoutPanel1.Controls.Add(label7, 2, 0);
            tableLayoutPanel1.Controls.Add(dtSkadimit, 2, 1);
            tableLayoutPanel1.Controls.Add(cbStatusi, 3, 1);
            tableLayoutPanel1.Location = new Point(13, 308);
            tableLayoutPanel1.MaximumSize = new Size(750, 67);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(750, 67);
            tableLayoutPanel1.TabIndex = 44;
            // 
            // txtQmimiB
            // 
            txtQmimiB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtQmimiB.BackColor = Color.FromArgb(148, 128, 203);
            txtQmimiB.BorderStyle = BorderStyle.None;
            txtQmimiB.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQmimiB.ForeColor = Color.White;
            txtQmimiB.Location = new Point(3, 28);
            txtQmimiB.MaximumSize = new Size(413, 24);
            txtQmimiB.Name = "txtQmimiB";
            txtQmimiB.PlaceholderText = "0.00";
            txtQmimiB.Size = new Size(160, 24);
            txtQmimiB.TabIndex = 48;
            txtQmimiB.TextAlign = HorizontalAlignment.Center;
            txtQmimiB.KeyPress += textBox1_KeyPress;
            // 
            // txtQmimiSh
            // 
            txtQmimiSh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtQmimiSh.BackColor = Color.FromArgb(148, 128, 203);
            txtQmimiSh.BorderStyle = BorderStyle.None;
            txtQmimiSh.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQmimiSh.ForeColor = Color.White;
            txtQmimiSh.Location = new Point(169, 28);
            txtQmimiSh.MaximumSize = new Size(413, 24);
            txtQmimiSh.Name = "txtQmimiSh";
            txtQmimiSh.PlaceholderText = "0.00";
            txtQmimiSh.Size = new Size(160, 24);
            txtQmimiSh.TabIndex = 47;
            txtQmimiSh.TextAlign = HorizontalAlignment.Center;
            txtQmimiSh.KeyPress += textBox1_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(534, 0);
            label10.Name = "label10";
            label10.Size = new Size(74, 25);
            label10.TabIndex = 45;
            label10.Text = "Statusi:";
            // 
            // cbStatusi
            // 
            cbStatusi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbStatusi.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStatusi.FormattingEnabled = true;
            cbStatusi.Items.AddRange(new object[] { "Aktiv", "Jo Aktiv" });
            cbStatusi.Location = new Point(534, 28);
            cbStatusi.Name = "cbStatusi";
            cbStatusi.Size = new Size(213, 36);
            cbStatusi.TabIndex = 46;
            cbStatusi.Text = "Aktiv";
            cbStatusi.KeyPress += cbNjesia_KeyPress;
            // 
            // btnRuaj
            // 
            btnRuaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRuaj.BackColor = Color.FromArgb(28, 209, 123);
            btnRuaj.Cursor = Cursors.Hand;
            btnRuaj.FlatStyle = FlatStyle.Flat;
            btnRuaj.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRuaj.ForeColor = Color.White;
            btnRuaj.Location = new Point(616, 649);
            btnRuaj.Name = "btnRuaj";
            btnRuaj.Size = new Size(144, 48);
            btnRuaj.TabIndex = 45;
            btnRuaj.Tag = "";
            btnRuaj.Text = "Ruaj";
            btnRuaj.TextImageRelation = TextImageRelation.TextAboveImage;
            btnRuaj.UseVisualStyleBackColor = false;
            btnRuaj.Click += btnRuaj_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.9170036F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.9047623F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.1904755F));
            tableLayoutPanel2.Controls.Add(cbNjesia, 2, 1);
            tableLayoutPanel2.Controls.Add(label11, 2, 0);
            tableLayoutPanel2.Controls.Add(txtFunrizuesi, 0, 1);
            tableLayoutPanel2.Controls.Add(label13, 1, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(txtSasia, 1, 1);
            tableLayoutPanel2.Location = new Point(13, 225);
            tableLayoutPanel2.MaximumSize = new Size(525, 67);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(525, 67);
            tableLayoutPanel2.TabIndex = 46;
            // 
            // cbNjesia
            // 
            cbNjesia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbNjesia.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbNjesia.FormattingEnabled = true;
            cbNjesia.Items.AddRange(new object[] { "Copa", "Kg", "Litra" });
            cbNjesia.Location = new Point(379, 28);
            cbNjesia.Name = "cbNjesia";
            cbNjesia.Size = new Size(143, 30);
            cbNjesia.TabIndex = 47;
            cbNjesia.Text = "Copa";
            cbNjesia.KeyPress += cbNjesia_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(379, 0);
            label11.Name = "label11";
            label11.Size = new Size(68, 25);
            label11.TabIndex = 47;
            label11.Text = "Njësia:";
            // 
            // txtFunrizuesi
            // 
            txtFunrizuesi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFunrizuesi.BackColor = Color.FromArgb(148, 128, 203);
            txtFunrizuesi.BorderStyle = BorderStyle.None;
            txtFunrizuesi.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFunrizuesi.ForeColor = Color.White;
            txtFunrizuesi.Location = new Point(3, 28);
            txtFunrizuesi.MaximumSize = new Size(413, 24);
            txtFunrizuesi.Name = "txtFunrizuesi";
            txtFunrizuesi.PlaceholderText = "Furnizuesi";
            txtFunrizuesi.Size = new Size(235, 24);
            txtFunrizuesi.TabIndex = 34;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(244, 0);
            label13.Name = "label13";
            label13.Size = new Size(62, 25);
            label13.TabIndex = 37;
            label13.Text = "Sasia:";
            // 
            // txtSasia
            // 
            txtSasia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSasia.BackColor = Color.FromArgb(148, 128, 203);
            txtSasia.BorderStyle = BorderStyle.None;
            txtSasia.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSasia.ForeColor = Color.White;
            txtSasia.Location = new Point(244, 28);
            txtSasia.Mask = "0000000000";
            txtSasia.Name = "txtSasia";
            txtSasia.Size = new Size(129, 24);
            txtSasia.TabIndex = 38;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(606, 218);
            label12.Name = "label12";
            label12.Size = new Size(99, 30);
            label12.TabIndex = 49;
            label12.Text = "Fotografia";
            // 
            // StockControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 43, 134);
            Controls.Add(label12);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(btnRuaj);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(picProduct);
            Controls.Add(txtPershkrimi);
            Controls.Add(label8);
            Controls.Add(lblCategories);
            Controls.Add(button1);
            Controls.Add(txtEmri);
            Controls.Add(label1);
            Controls.Add(picBack);
            Controls.Add(label2);
            Name = "StockControl";
            Size = new Size(804, 712);
            Load += StockControl_Load;
            ((System.ComponentModel.ISupportInitialize)picBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBack;
        private Label label2;
        private TextBox txtEmri;
        private Label label1;
        private Button button1;
        private Label lblCategories;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtSkadimit;
        private Label label7;
        private TextBox txtPershkrimi;
        private Label label8;
        private PictureBox picProduct;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label10;
        private ComboBox cbStatusi;
        private Button btnRuaj;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtFunrizuesi;
        private Label label13;
        private MaskedTextBox txtSasia;
        private ComboBox cbNjesia;
        private Label label11;
        private TextBox txtQmimiB;
        private TextBox txtQmimiSh;
        private Label label12;
    }
}
