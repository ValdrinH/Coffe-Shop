namespace Coffe_Shop.UserControls.StockElements
{
    partial class EditItems
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
            cbNjesia = new ComboBox();
            label11 = new Label();
            txtFunrizuesi = new TextBox();
            txtSasia = new MaskedTextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label13 = new Label();
            label4 = new Label();
            btnRuaj = new Button();
            txtQmimiB = new TextBox();
            txtQmimiSh = new TextBox();
            label10 = new Label();
            cbStatusi = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtSkadimit = new DateTimePicker();
            txtPershkrimi = new TextBox();
            label8 = new Label();
            picProduct = new PictureBox();
            lblCategories = new Label();
            button1 = new Button();
            txtEmri = new TextBox();
            label1 = new Label();
            button2 = new Button();
            lblDateRegister = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)picBack).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            SuspendLayout();
            // 
            // picBack
            // 
            picBack.Cursor = Cursors.Hand;
            picBack.Image = Properties.Resources.icons8_back_35;
            picBack.Location = new Point(11, 22);
            picBack.Name = "picBack";
            picBack.Size = new Size(35, 35);
            picBack.SizeMode = PictureBoxSizeMode.AutoSize;
            picBack.TabIndex = 29;
            picBack.TabStop = false;
            picBack.Click += picBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(52, 22);
            label2.Name = "label2";
            label2.Size = new Size(212, 37);
            label2.TabIndex = 28;
            label2.Text = "Detajet e produktit";
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
            cbNjesia.KeyPress += cbStatusi_KeyPress;
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
            tableLayoutPanel2.Location = new Point(13, 218);
            tableLayoutPanel2.MaximumSize = new Size(525, 67);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(525, 67);
            tableLayoutPanel2.TabIndex = 57;
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
            // btnRuaj
            // 
            btnRuaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRuaj.BackColor = Color.FromArgb(0, 64, 0);
            btnRuaj.Cursor = Cursors.Hand;
            btnRuaj.FlatStyle = FlatStyle.Flat;
            btnRuaj.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRuaj.ForeColor = Color.White;
            btnRuaj.Location = new Point(624, 651);
            btnRuaj.Name = "btnRuaj";
            btnRuaj.Size = new Size(136, 39);
            btnRuaj.TabIndex = 56;
            btnRuaj.Tag = "";
            btnRuaj.Text = "Ruaj";
            btnRuaj.TextImageRelation = TextImageRelation.TextAboveImage;
            btnRuaj.UseVisualStyleBackColor = false;
            btnRuaj.Click += btnRuaj_Click;
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
            txtQmimiB.KeyPress += txtQmimiB_KeyPress;
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
            txtQmimiSh.KeyPress += txtQmimiB_KeyPress;
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
            cbStatusi.KeyPress += cbStatusi_KeyPress;
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
            tableLayoutPanel1.Location = new Point(13, 301);
            tableLayoutPanel1.MaximumSize = new Size(750, 67);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(750, 67);
            tableLayoutPanel1.TabIndex = 55;
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
            // txtPershkrimi
            // 
            txtPershkrimi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPershkrimi.BackColor = Color.FromArgb(148, 128, 203);
            txtPershkrimi.BorderStyle = BorderStyle.None;
            txtPershkrimi.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPershkrimi.ForeColor = Color.White;
            txtPershkrimi.Location = new Point(13, 408);
            txtPershkrimi.Multiline = true;
            txtPershkrimi.Name = "txtPershkrimi";
            txtPershkrimi.PlaceholderText = "Përshkimi";
            txtPershkrimi.ScrollBars = ScrollBars.Vertical;
            txtPershkrimi.Size = new Size(750, 225);
            txtPershkrimi.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(13, 380);
            label8.Name = "label8";
            label8.Size = new Size(105, 30);
            label8.TabIndex = 52;
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
            picProduct.TabIndex = 53;
            picProduct.TabStop = false;
            picProduct.Click += picProduct_Click;
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategories.ForeColor = Color.White;
            lblCategories.Location = new Point(72, 160);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(109, 30);
            lblCategories.TabIndex = 50;
            lblCategories.Text = "Kategorit: 0";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(16, 158);
            button1.Name = "button1";
            button1.Size = new Size(50, 34);
            button1.TabIndex = 49;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtEmri
            // 
            txtEmri.BackColor = Color.FromArgb(148, 128, 203);
            txtEmri.BorderStyle = BorderStyle.None;
            txtEmri.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmri.ForeColor = Color.White;
            txtEmri.Location = new Point(16, 113);
            txtEmri.MaximumSize = new Size(413, 24);
            txtEmri.Name = "txtEmri";
            txtEmri.PlaceholderText = "Emri i Produktit";
            txtEmri.Size = new Size(345, 24);
            txtEmri.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 80);
            label1.Name = "label1";
            label1.Size = new Size(133, 30);
            label1.TabIndex = 48;
            label1.Text = "Emri Produktit:";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Maroon;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(485, 651);
            button2.Name = "button2";
            button2.Size = new Size(136, 39);
            button2.TabIndex = 58;
            button2.Tag = "";
            button2.Text = "Fshije";
            button2.TextImageRelation = TextImageRelation.TextAboveImage;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblDateRegister
            // 
            lblDateRegister.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDateRegister.AutoSize = true;
            lblDateRegister.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateRegister.ForeColor = Color.White;
            lblDateRegister.Location = new Point(16, 655);
            lblDateRegister.Name = "lblDateRegister";
            lblDateRegister.Size = new Size(160, 30);
            lblDateRegister.TabIndex = 59;
            lblDateRegister.Text = "27 Dec 2022, 9:25";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(601, 218);
            label12.Name = "label12";
            label12.Size = new Size(99, 30);
            label12.TabIndex = 60;
            label12.Text = "Fotografia";
            // 
            // EditItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 43, 134);
            Controls.Add(label12);
            Controls.Add(lblDateRegister);
            Controls.Add(button2);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(btnRuaj);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(txtPershkrimi);
            Controls.Add(label8);
            Controls.Add(picProduct);
            Controls.Add(lblCategories);
            Controls.Add(button1);
            Controls.Add(txtEmri);
            Controls.Add(label1);
            Controls.Add(picBack);
            Controls.Add(label2);
            Name = "EditItems";
            Size = new Size(789, 712);
            Load += EditItems_Load;
            SizeChanged += EditItems_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)picBack).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBack;
        private Label label2;
        private ComboBox cbNjesia;
        private Label label11;
        private TextBox txtFunrizuesi;
        private MaskedTextBox txtSasia;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label13;
        private Label label4;
        private Button btnRuaj;
        private TextBox txtQmimiB;
        private TextBox txtQmimiSh;
        private Label label10;
        private ComboBox cbStatusi;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtSkadimit;
        private Label label9;
        private TextBox txtPershkrimi;
        private Label label8;
        private PictureBox picProduct;
        private Label lblCategories;
        private Button button1;
        private TextBox txtEmri;
        private Label label1;
        private Button button2;
        private Label lblDateRegister;
        private Label label12;
    }
}
