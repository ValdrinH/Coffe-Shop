namespace Coffe_Shop.UserControls.Punetoret
{
    partial class EmployeeBaseControl
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
            tableLayoutPanel2 = new TableLayoutPanel();
            label5 = new Label();
            txtEmail = new TextBox();
            txtPuntori = new TextBox();
            label4 = new Label();
            cbGjinia = new ComboBox();
            label11 = new Label();
            btnRuaj = new Button();
            label9 = new Label();
            picProduct = new PictureBox();
            txtPershkrimi = new TextBox();
            label8 = new Label();
            picBack = new PictureBox();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            cbMosha = new ComboBox();
            label3 = new Label();
            txtNumriTelefonit = new MaskedTextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtPagaBaze = new TextBox();
            txtkohaeMbraimit = new MaskedTextBox();
            txtKohaefillimit = new MaskedTextBox();
            label12 = new Label();
            label6 = new Label();
            cbSatusi = new ComboBox();
            label7 = new Label();
            label10 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            txtIdKarta = new MaskedTextBox();
            label15 = new Label();
            dtNisjes = new DateTimePicker();
            label13 = new Label();
            label14 = new Label();
            cbRoli = new ComboBox();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBack).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.8571434F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.1428566F));
            tableLayoutPanel2.Controls.Add(label5, 1, 0);
            tableLayoutPanel2.Controls.Add(txtEmail, 1, 1);
            tableLayoutPanel2.Controls.Add(txtPuntori, 0, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Location = new Point(21, 108);
            tableLayoutPanel2.MaximumSize = new Size(525, 67);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(525, 67);
            tableLayoutPanel2.TabIndex = 56;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(249, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 58;
            label5.Text = "Emaili:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.FromArgb(148, 128, 203);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(249, 28);
            txtEmail.MaximumSize = new Size(413, 24);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(273, 24);
            txtEmail.TabIndex = 58;
            // 
            // txtPuntori
            // 
            txtPuntori.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPuntori.BackColor = Color.FromArgb(148, 128, 203);
            txtPuntori.BorderStyle = BorderStyle.None;
            txtPuntori.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPuntori.ForeColor = Color.White;
            txtPuntori.Location = new Point(3, 28);
            txtPuntori.MaximumSize = new Size(413, 24);
            txtPuntori.Name = "txtPuntori";
            txtPuntori.PlaceholderText = "Puntori";
            txtPuntori.Size = new Size(240, 24);
            txtPuntori.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(166, 25);
            label4.TabIndex = 33;
            label4.Text = "Emri dhe Mbiemri:\r\n";
            // 
            // cbGjinia
            // 
            cbGjinia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbGjinia.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbGjinia.FormattingEnabled = true;
            cbGjinia.Items.AddRange(new object[] { "Mashkull", "Femer" });
            cbGjinia.Location = new Point(353, 28);
            cbGjinia.Name = "cbGjinia";
            cbGjinia.Size = new Size(169, 30);
            cbGjinia.TabIndex = 47;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(353, 0);
            label11.Name = "label11";
            label11.Size = new Size(64, 25);
            label11.TabIndex = 47;
            label11.Text = "Gjinia:";
            // 
            // btnRuaj
            // 
            btnRuaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRuaj.BackColor = Color.FromArgb(0, 64, 0);
            btnRuaj.Cursor = Cursors.Hand;
            btnRuaj.FlatStyle = FlatStyle.Flat;
            btnRuaj.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRuaj.ForeColor = Color.White;
            btnRuaj.Location = new Point(624, 646);
            btnRuaj.Name = "btnRuaj";
            btnRuaj.Size = new Size(144, 48);
            btnRuaj.TabIndex = 55;
            btnRuaj.Tag = "";
            btnRuaj.Text = "Ruaj";
            btnRuaj.TextImageRelation = TextImageRelation.TextAboveImage;
            btnRuaj.UseVisualStyleBackColor = false;
            btnRuaj.Click += btnRuaj_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(632, 222);
            label9.Name = "label9";
            label9.Size = new Size(99, 30);
            label9.TabIndex = 54;
            label9.Text = "Fotografia";
            // 
            // picProduct
            // 
            picProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picProduct.BorderStyle = BorderStyle.FixedSingle;
            picProduct.Cursor = Cursors.Hand;
            picProduct.Image = Properties.Resources.Screenshot_2023_12_22_133437;
            picProduct.Location = new Point(579, 26);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(205, 193);
            picProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            picProduct.TabIndex = 53;
            picProduct.TabStop = false;
            picProduct.Click += picProduct_Click;
            // 
            // txtPershkrimi
            // 
            txtPershkrimi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPershkrimi.BackColor = Color.FromArgb(148, 128, 203);
            txtPershkrimi.BorderStyle = BorderStyle.None;
            txtPershkrimi.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPershkrimi.ForeColor = Color.White;
            txtPershkrimi.Location = new Point(21, 493);
            txtPershkrimi.Multiline = true;
            txtPershkrimi.Name = "txtPershkrimi";
            txtPershkrimi.PlaceholderText = "Përshkimi";
            txtPershkrimi.ScrollBars = ScrollBars.Vertical;
            txtPershkrimi.Size = new Size(750, 115);
            txtPershkrimi.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(21, 465);
            label8.Name = "label8";
            label8.Size = new Size(200, 30);
            label8.TabIndex = 52;
            label8.Text = "Përshkrimi (Opsional):";
            // 
            // picBack
            // 
            picBack.Cursor = Cursors.Hand;
            picBack.Image = Properties.Resources.icons8_back_35;
            picBack.Location = new Point(21, 19);
            picBack.Name = "picBack";
            picBack.Size = new Size(35, 35);
            picBack.SizeMode = PictureBoxSizeMode.AutoSize;
            picBack.TabIndex = 48;
            picBack.TabStop = false;
            picBack.Click += picBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(62, 19);
            label2.Name = "label2";
            label2.Size = new Size(228, 37);
            label2.TabIndex = 47;
            label2.Text = "Shto punëtor të rinjë\r\n";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(cbMosha, 1, 1);
            tableLayoutPanel1.Controls.Add(cbGjinia, 2, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(label11, 2, 0);
            tableLayoutPanel1.Controls.Add(txtNumriTelefonit, 0, 1);
            tableLayoutPanel1.Location = new Point(21, 192);
            tableLayoutPanel1.MaximumSize = new Size(525, 67);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(525, 67);
            tableLayoutPanel1.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 33;
            label1.Text = "Numri i Telefonit:";
            // 
            // cbMosha
            // 
            cbMosha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbMosha.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbMosha.FormattingEnabled = true;
            cbMosha.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100" });
            cbMosha.Location = new Point(178, 28);
            cbMosha.Name = "cbMosha";
            cbMosha.Size = new Size(169, 30);
            cbMosha.TabIndex = 47;
            cbMosha.Text = "16";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(178, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 47;
            label3.Text = "Mosha:";
            // 
            // txtNumriTelefonit
            // 
            txtNumriTelefonit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNumriTelefonit.BackColor = Color.FromArgb(148, 128, 203);
            txtNumriTelefonit.BeepOnError = true;
            txtNumriTelefonit.BorderStyle = BorderStyle.None;
            txtNumriTelefonit.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumriTelefonit.ForeColor = Color.White;
            txtNumriTelefonit.Location = new Point(3, 28);
            txtNumriTelefonit.Mask = "(999) 000-0000";
            txtNumriTelefonit.Name = "txtNumriTelefonit";
            txtNumriTelefonit.Size = new Size(169, 24);
            txtNumriTelefonit.TabIndex = 48;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(txtPagaBaze, 0, 1);
            tableLayoutPanel3.Controls.Add(txtkohaeMbraimit, 3, 1);
            tableLayoutPanel3.Controls.Add(txtKohaefillimit, 2, 1);
            tableLayoutPanel3.Controls.Add(label12, 3, 0);
            tableLayoutPanel3.Controls.Add(label6, 0, 0);
            tableLayoutPanel3.Controls.Add(cbSatusi, 1, 1);
            tableLayoutPanel3.Controls.Add(label7, 1, 0);
            tableLayoutPanel3.Controls.Add(label10, 2, 0);
            tableLayoutPanel3.Location = new Point(24, 279);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(760, 67);
            tableLayoutPanel3.TabIndex = 58;
            // 
            // txtPagaBaze
            // 
            txtPagaBaze.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPagaBaze.BackColor = Color.FromArgb(148, 128, 203);
            txtPagaBaze.BorderStyle = BorderStyle.None;
            txtPagaBaze.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPagaBaze.ForeColor = Color.White;
            txtPagaBaze.Location = new Point(3, 28);
            txtPagaBaze.MaximumSize = new Size(413, 24);
            txtPagaBaze.Name = "txtPagaBaze";
            txtPagaBaze.PlaceholderText = "0.00";
            txtPagaBaze.Size = new Size(184, 24);
            txtPagaBaze.TabIndex = 60;
            txtPagaBaze.TextAlign = HorizontalAlignment.Center;
            txtPagaBaze.KeyPress += textBox2_KeyPress;
            // 
            // txtkohaeMbraimit
            // 
            txtkohaeMbraimit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtkohaeMbraimit.BackColor = Color.FromArgb(148, 128, 203);
            txtkohaeMbraimit.BeepOnError = true;
            txtkohaeMbraimit.BorderStyle = BorderStyle.None;
            txtkohaeMbraimit.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtkohaeMbraimit.ForeColor = Color.White;
            txtkohaeMbraimit.Location = new Point(573, 28);
            txtkohaeMbraimit.Mask = "00:00";
            txtkohaeMbraimit.Name = "txtkohaeMbraimit";
            txtkohaeMbraimit.Size = new Size(184, 24);
            txtkohaeMbraimit.TabIndex = 61;
            txtkohaeMbraimit.ValidatingType = typeof(DateTime);
            // 
            // txtKohaefillimit
            // 
            txtKohaefillimit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtKohaefillimit.BackColor = Color.FromArgb(148, 128, 203);
            txtKohaefillimit.BeepOnError = true;
            txtKohaefillimit.BorderStyle = BorderStyle.None;
            txtKohaefillimit.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtKohaefillimit.ForeColor = Color.White;
            txtKohaefillimit.Location = new Point(383, 28);
            txtKohaefillimit.Mask = "00:00";
            txtKohaefillimit.Name = "txtKohaefillimit";
            txtKohaefillimit.Size = new Size(184, 24);
            txtKohaefillimit.TabIndex = 60;
            txtKohaefillimit.ValidatingType = typeof(DateTime);
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(573, 0);
            label12.Name = "label12";
            label12.Size = new Size(159, 25);
            label12.TabIndex = 59;
            label12.Text = "Koha e mbarimit:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 33;
            label6.Text = "Paga bazë:";
            // 
            // cbSatusi
            // 
            cbSatusi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbSatusi.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbSatusi.FormattingEnabled = true;
            cbSatusi.Items.AddRange(new object[] { "Aktiv", "Jo Aktiv" });
            cbSatusi.Location = new Point(193, 28);
            cbSatusi.Name = "cbSatusi";
            cbSatusi.Size = new Size(184, 30);
            cbSatusi.TabIndex = 47;
            cbSatusi.Text = "Aktiv";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(193, 0);
            label7.Name = "label7";
            label7.Size = new Size(141, 25);
            label7.TabIndex = 47;
            label7.Text = "Statusi i punës:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(383, 0);
            label10.Name = "label10";
            label10.Size = new Size(131, 25);
            label10.TabIndex = 47;
            label10.Text = "Koha e fillimit:";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(txtIdKarta, 2, 1);
            tableLayoutPanel4.Controls.Add(label15, 2, 0);
            tableLayoutPanel4.Controls.Add(dtNisjes, 1, 1);
            tableLayoutPanel4.Controls.Add(label13, 0, 0);
            tableLayoutPanel4.Controls.Add(label14, 1, 0);
            tableLayoutPanel4.Controls.Add(cbRoli, 0, 1);
            tableLayoutPanel4.Location = new Point(21, 369);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(760, 67);
            tableLayoutPanel4.TabIndex = 59;
            // 
            // txtIdKarta
            // 
            txtIdKarta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIdKarta.BackColor = Color.FromArgb(148, 128, 203);
            txtIdKarta.BeepOnError = true;
            txtIdKarta.BorderStyle = BorderStyle.None;
            txtIdKarta.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdKarta.ForeColor = Color.White;
            txtIdKarta.Location = new Point(509, 28);
            txtIdKarta.Mask = "0000000000";
            txtIdKarta.Name = "txtIdKarta";
            txtIdKarta.Size = new Size(248, 24);
            txtIdKarta.TabIndex = 60;
            txtIdKarta.ValidatingType = typeof(int);
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(509, 0);
            label15.Name = "label15";
            label15.Size = new Size(82, 25);
            label15.TabIndex = 60;
            label15.Text = "ID Karta:";
            // 
            // dtNisjes
            // 
            dtNisjes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtNisjes.CustomFormat = "dd MMM yyyy";
            dtNisjes.Format = DateTimePickerFormat.Custom;
            dtNisjes.Location = new Point(256, 28);
            dtNisjes.Name = "dtNisjes";
            dtNisjes.Size = new Size(247, 23);
            dtNisjes.TabIndex = 60;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(3, 0);
            label13.Name = "label13";
            label13.Size = new Size(139, 25);
            label13.TabIndex = 33;
            label13.Text = "Pozita apo Roli:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(256, 0);
            label14.Name = "label14";
            label14.Size = new Size(126, 25);
            label14.TabIndex = 47;
            label14.Text = "Data e nisjes:";
            // 
            // cbRoli
            // 
            cbRoli.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbRoli.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbRoli.FormattingEnabled = true;
            cbRoli.Items.AddRange(new object[] { "Shankist", "Kamarier", "Shef kuzhiner", "Menaxher" });
            cbRoli.Location = new Point(3, 28);
            cbRoli.Name = "cbRoli";
            cbRoli.Size = new Size(247, 30);
            cbRoli.TabIndex = 47;
            // 
            // EmployeeBaseControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 43, 134);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(btnRuaj);
            Controls.Add(label9);
            Controls.Add(picProduct);
            Controls.Add(txtPershkrimi);
            Controls.Add(label8);
            Controls.Add(picBack);
            Controls.Add(label2);
            Name = "EmployeeBaseControl";
            Size = new Size(804, 712);
            Load += EmployeeBaseControl_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBack).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtPuntori;
        private Label label4;
        private ComboBox cbGjinia;
        private Label label11;
        private Button btnRuaj;
        private Label label9;
        private PictureBox picProduct;
        private TextBox txtPershkrimi;
        private Label label8;
        private PictureBox picBack;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private ComboBox cbMosha;
        private Label label3;
        private MaskedTextBox txtNumriTelefonit;
        private Label label5;
        private TextBox txtEmail;
        private TableLayoutPanel tableLayoutPanel3;
        private MaskedTextBox txtkohaeMbraimit;
        private MaskedTextBox txtKohaefillimit;
        private Label label12;
        private Label label6;
        private ComboBox cbSatusi;
        private Label label7;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel4;
        private DateTimePicker dtNisjes;
        private Label label13;
        private Label label14;
        private ComboBox cbRoli;
        private TextBox txtPagaBaze;
        private Label label15;
        private MaskedTextBox txtIdKarta;
    }
}
