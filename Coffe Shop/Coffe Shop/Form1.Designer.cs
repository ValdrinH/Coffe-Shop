namespace Coffe_Shop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlTop = new Panel();
            pnlWarning = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            Line = new Panel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            lblDashboard = new Label();
            lblCategory = new Label();
            lblStoku = new Label();
            lblReport = new Label();
            lblPorosia = new Label();
            lblTavolinatControl = new Label();
            lblPuntoret = new Label();
            lblTjera = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            testToolStripMenuItem = new ToolStripMenuItem();
            porositEFshirjaToolStripMenuItem = new ToolStripMenuItem();
            rrethSistemitToolStripMenuItem = new ToolStripMenuItem();
            lokacioniIRuajtejsSeDokumentaveToolStripMenuItem = new ToolStripMenuItem();
            picMinimize = new PictureBox();
            picClose = new PictureBox();
            lblNgarkimi = new Label();
            lblPuntori = new Label();
            lblTime = new Label();
            label1 = new Label();
            pnlKategorit = new Panel();
            BodyCategory = new FlowLayoutPanel();
            panel6 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button17 = new Button();
            button16 = new Button();
            btnKyqu = new Button();
            txtTextCalculator = new TextBox();
            Body = new Panel();
            TicketPanel = new Panel();
            pnlTotalRows = new Panel();
            label8 = new Label();
            dataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Order = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btnLargo = new DataGridViewButtonColumn();
            panel1 = new Panel();
            lblTotal = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblTavolina = new Label();
            btnPastroTiketen = new Button();
            button20 = new Button();
            button19 = new Button();
            panel4 = new Panel();
            label10 = new Label();
            label3 = new Label();
            timer = new System.Windows.Forms.Timer(components);
            pnlTop.SuspendLayout();
            pnlWarning.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            pnlKategorit.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            TicketPanel.SuspendLayout();
            pnlTotalRows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(pnlWarning);
            pnlTop.Controls.Add(panel2);
            pnlTop.Controls.Add(flowLayoutPanel3);
            pnlTop.Controls.Add(picMinimize);
            pnlTop.Controls.Add(picClose);
            pnlTop.Controls.Add(lblNgarkimi);
            pnlTop.Controls.Add(lblPuntori);
            pnlTop.Controls.Add(lblTime);
            pnlTop.Controls.Add(label1);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1474, 80);
            pnlTop.TabIndex = 0;
            pnlTop.Paint += pnlTop_Paint;
            // 
            // pnlWarning
            // 
            pnlWarning.Anchor = AnchorStyles.None;
            pnlWarning.BackColor = Color.Olive;
            pnlWarning.Controls.Add(label4);
            pnlWarning.Cursor = Cursors.Hand;
            pnlWarning.Location = new Point(476, -6);
            pnlWarning.Name = "pnlWarning";
            pnlWarning.Size = new Size(430, 36);
            pnlWarning.TabIndex = 16;
            pnlWarning.Visible = false;
            pnlWarning.Click += UpdateProductExpired;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(19, 9);
            label4.Name = "label4";
            label4.Size = new Size(395, 23);
            label4.TabIndex = 2;
            label4.Tag = "1";
            label4.Text = "Disa produkte nuk mund te paraqiten pasi janë të skaduara";
            label4.Click += UpdateProductExpired;
            // 
            // panel2
            // 
            panel2.Controls.Add(Line);
            panel2.Location = new Point(240, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(791, 10);
            panel2.TabIndex = 15;
            // 
            // Line
            // 
            Line.BackColor = Color.White;
            Line.Location = new Point(3, 0);
            Line.Name = "Line";
            Line.Size = new Size(106, 3);
            Line.TabIndex = 8;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(lblDashboard);
            flowLayoutPanel3.Controls.Add(lblCategory);
            flowLayoutPanel3.Controls.Add(lblStoku);
            flowLayoutPanel3.Controls.Add(lblReport);
            flowLayoutPanel3.Controls.Add(lblPorosia);
            flowLayoutPanel3.Controls.Add(lblTavolinatControl);
            flowLayoutPanel3.Controls.Add(lblPuntoret);
            flowLayoutPanel3.Controls.Add(lblTjera);
            flowLayoutPanel3.Location = new Point(240, 44);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(724, 25);
            flowLayoutPanel3.TabIndex = 14;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Cursor = Cursors.Hand;
            lblDashboard.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDashboard.ForeColor = Color.White;
            lblDashboard.Location = new Point(3, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(106, 30);
            lblDashboard.TabIndex = 1;
            lblDashboard.Tag = "1";
            lblDashboard.Text = "Dashboard";
            lblDashboard.Click += ElementsDashboard;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Cursor = Cursors.Hand;
            lblCategory.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategory.ForeColor = Color.White;
            lblCategory.Location = new Point(115, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(89, 30);
            lblCategory.TabIndex = 2;
            lblCategory.Tag = "2";
            lblCategory.Text = "Kategorit";
            lblCategory.Click += ElementsDashboard;
            // 
            // lblStoku
            // 
            lblStoku.AutoSize = true;
            lblStoku.Cursor = Cursors.Hand;
            lblStoku.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblStoku.ForeColor = Color.White;
            lblStoku.Location = new Point(210, 0);
            lblStoku.Name = "lblStoku";
            lblStoku.Size = new Size(60, 30);
            lblStoku.TabIndex = 3;
            lblStoku.Tag = "3";
            lblStoku.Text = "Stoku";
            lblStoku.Click += ElementsDashboard;
            // 
            // lblReport
            // 
            lblReport.AutoSize = true;
            lblReport.Cursor = Cursors.Hand;
            lblReport.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblReport.ForeColor = Color.White;
            lblReport.Location = new Point(276, 0);
            lblReport.Name = "lblReport";
            lblReport.Size = new Size(68, 30);
            lblReport.TabIndex = 4;
            lblReport.Tag = "4";
            lblReport.Text = "Raport";
            lblReport.Click += ElementsDashboard;
            // 
            // lblPorosia
            // 
            lblPorosia.AutoSize = true;
            lblPorosia.Cursor = Cursors.Hand;
            lblPorosia.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPorosia.ForeColor = Color.White;
            lblPorosia.Location = new Point(350, 0);
            lblPorosia.Name = "lblPorosia";
            lblPorosia.Size = new Size(70, 30);
            lblPorosia.TabIndex = 6;
            lblPorosia.Tag = "5";
            lblPorosia.Text = "Porosit";
            lblPorosia.Click += ElementsDashboard;
            // 
            // lblTavolinatControl
            // 
            lblTavolinatControl.AutoSize = true;
            lblTavolinatControl.Cursor = Cursors.Hand;
            lblTavolinatControl.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTavolinatControl.ForeColor = Color.White;
            lblTavolinatControl.Location = new Point(426, 0);
            lblTavolinatControl.Name = "lblTavolinatControl";
            lblTavolinatControl.Size = new Size(65, 30);
            lblTavolinatControl.TabIndex = 9;
            lblTavolinatControl.Tag = "6";
            lblTavolinatControl.Text = "Shitjet";
            lblTavolinatControl.Click += ElementsDashboard;
            // 
            // lblPuntoret
            // 
            lblPuntoret.AutoSize = true;
            lblPuntoret.Cursor = Cursors.Hand;
            lblPuntoret.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPuntoret.ForeColor = Color.White;
            lblPuntoret.Location = new Point(497, 0);
            lblPuntoret.Name = "lblPuntoret";
            lblPuntoret.Size = new Size(85, 30);
            lblPuntoret.TabIndex = 10;
            lblPuntoret.Tag = "7";
            lblPuntoret.Text = "Puntorët";
            lblPuntoret.Click += ElementsDashboard;
            // 
            // lblTjera
            // 
            lblTjera.AutoSize = true;
            lblTjera.ContextMenuStrip = contextMenuStrip1;
            lblTjera.Cursor = Cursors.Hand;
            lblTjera.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTjera.ForeColor = Color.White;
            lblTjera.Location = new Point(588, 0);
            lblTjera.Name = "lblTjera";
            lblTjera.Size = new Size(76, 30);
            lblTjera.TabIndex = 11;
            lblTjera.Tag = "8";
            lblTjera.Text = "Të tjera";
            lblTjera.Click += ElementsDashboard;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { testToolStripMenuItem, porositEFshirjaToolStripMenuItem, rrethSistemitToolStripMenuItem, lokacioniIRuajtejsSeDokumentaveToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(263, 92);
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new Size(262, 22);
            testToolStripMenuItem.Text = "Profili";
            testToolStripMenuItem.Click += testToolStripMenuItem_Click;
            // 
            // porositEFshirjaToolStripMenuItem
            // 
            porositEFshirjaToolStripMenuItem.Name = "porositEFshirjaToolStripMenuItem";
            porositEFshirjaToolStripMenuItem.Size = new Size(262, 22);
            porositEFshirjaToolStripMenuItem.Text = "Porosit e fshira";
            porositEFshirjaToolStripMenuItem.Click += porositEFshirjaToolStripMenuItem_Click;
            // 
            // rrethSistemitToolStripMenuItem
            // 
            rrethSistemitToolStripMenuItem.Name = "rrethSistemitToolStripMenuItem";
            rrethSistemitToolStripMenuItem.Size = new Size(262, 22);
            rrethSistemitToolStripMenuItem.Text = "Rreth sistemit";
            rrethSistemitToolStripMenuItem.Click += rrethSistemitToolStripMenuItem_Click;
            // 
            // lokacioniIRuajtejsSeDokumentaveToolStripMenuItem
            // 
            lokacioniIRuajtejsSeDokumentaveToolStripMenuItem.Name = "lokacioniIRuajtejsSeDokumentaveToolStripMenuItem";
            lokacioniIRuajtejsSeDokumentaveToolStripMenuItem.Size = new Size(262, 22);
            lokacioniIRuajtejsSeDokumentaveToolStripMenuItem.Text = "Lokacioni i ruajtejs se dokumentave";
            lokacioniIRuajtejsSeDokumentaveToolStripMenuItem.Click += lokacioniIRuajtejsSeDokumentaveToolStripMenuItem_Click;
            // 
            // picMinimize
            // 
            picMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMinimize.Cursor = Cursors.Hand;
            picMinimize.Image = Properties.Resources.icons8_minimize_40;
            picMinimize.Location = new Point(1394, 2);
            picMinimize.Name = "picMinimize";
            picMinimize.Size = new Size(40, 40);
            picMinimize.SizeMode = PictureBoxSizeMode.AutoSize;
            picMinimize.TabIndex = 13;
            picMinimize.TabStop = false;
            picMinimize.Click += picMinimize_Click;
            // 
            // picClose
            // 
            picClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picClose.Cursor = Cursors.Hand;
            picClose.Image = Properties.Resources.icons8_close_40;
            picClose.Location = new Point(1433, 2);
            picClose.Name = "picClose";
            picClose.Size = new Size(40, 40);
            picClose.SizeMode = PictureBoxSizeMode.AutoSize;
            picClose.TabIndex = 12;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            // 
            // lblNgarkimi
            // 
            lblNgarkimi.Anchor = AnchorStyles.Top;
            lblNgarkimi.AutoSize = true;
            lblNgarkimi.Font = new Font("Poppins", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNgarkimi.ForeColor = Color.White;
            lblNgarkimi.Location = new Point(1047, 3);
            lblNgarkimi.Name = "lblNgarkimi";
            lblNgarkimi.Size = new Size(157, 22);
            lblNgarkimi.TabIndex = 2;
            lblNgarkimi.Text = "Po ngarkohen kategorit...";
            // 
            // lblPuntori
            // 
            lblPuntori.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPuntori.AutoSize = true;
            lblPuntori.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPuntori.ForeColor = Color.White;
            lblPuntori.Location = new Point(1047, 41);
            lblPuntori.Name = "lblPuntori";
            lblPuntori.Size = new Size(81, 30);
            lblPuntori.TabIndex = 7;
            lblPuntori.Text = "Puntori: ";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(16, 41);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(166, 23);
            lblTime.TabIndex = 5;
            lblTime.Text = "Powered by: V-Software";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 37);
            label1.TabIndex = 0;
            label1.Text = "Coffee Shop";
            // 
            // pnlKategorit
            // 
            pnlKategorit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlKategorit.BackColor = Color.FromArgb(69, 43, 134);
            pnlKategorit.Controls.Add(BodyCategory);
            pnlKategorit.Controls.Add(panel6);
            pnlKategorit.Location = new Point(12, 86);
            pnlKategorit.Name = "pnlKategorit";
            pnlKategorit.Size = new Size(219, 362);
            pnlKategorit.TabIndex = 1;
            // 
            // BodyCategory
            // 
            BodyCategory.AutoScroll = true;
            BodyCategory.Dock = DockStyle.Fill;
            BodyCategory.Location = new Point(0, 58);
            BodyCategory.Name = "BodyCategory";
            BodyCategory.Size = new Size(219, 304);
            BodyCategory.TabIndex = 2;
            BodyCategory.ControlAdded += BodyCategory_ControlAdded;
            // 
            // panel6
            // 
            panel6.Controls.Add(label2);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(219, 58);
            panel6.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 12);
            label2.Name = "label2";
            label2.Size = new Size(89, 30);
            label2.TabIndex = 1;
            label2.Text = "Kategorit";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Controls.Add(txtTextCalculator);
            panel3.Location = new Point(12, 454);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 344);
            panel3.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Controls.Add(button9);
            flowLayoutPanel1.Controls.Add(button10);
            flowLayoutPanel1.Controls.Add(button11);
            flowLayoutPanel1.Controls.Add(button12);
            flowLayoutPanel1.Controls.Add(button13);
            flowLayoutPanel1.Controls.Add(button14);
            flowLayoutPanel1.Controls.Add(button15);
            flowLayoutPanel1.Controls.Add(button17);
            flowLayoutPanel1.Controls.Add(button16);
            flowLayoutPanel1.Controls.Add(btnKyqu);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 32);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5, 5, 0, 0);
            flowLayoutPanel1.Size = new Size(219, 312);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Tag = "5";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(69, 43, 134);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(8, 8);
            button1.Name = "button1";
            button1.Size = new Size(64, 45);
            button1.TabIndex = 0;
            button1.Text = "7";
            button1.TextImageRelation = TextImageRelation.TextAboveImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += CalculatorNumber;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(69, 43, 134);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(78, 8);
            button2.Name = "button2";
            button2.Size = new Size(64, 45);
            button2.TabIndex = 1;
            button2.Text = "8";
            button2.TextImageRelation = TextImageRelation.TextAboveImage;
            button2.UseVisualStyleBackColor = false;
            button2.Click += CalculatorNumber;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(69, 43, 134);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(148, 8);
            button3.Name = "button3";
            button3.Size = new Size(64, 45);
            button3.TabIndex = 2;
            button3.Text = "9";
            button3.TextImageRelation = TextImageRelation.TextAboveImage;
            button3.UseVisualStyleBackColor = false;
            button3.Click += CalculatorNumber;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(69, 43, 134);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(8, 59);
            button4.Name = "button4";
            button4.Size = new Size(64, 45);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.TextImageRelation = TextImageRelation.TextAboveImage;
            button4.UseVisualStyleBackColor = false;
            button4.Click += CalculatorNumber;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(69, 43, 134);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(78, 59);
            button5.Name = "button5";
            button5.Size = new Size(64, 45);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.TextImageRelation = TextImageRelation.TextAboveImage;
            button5.UseVisualStyleBackColor = false;
            button5.Click += CalculatorNumber;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(69, 43, 134);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(148, 59);
            button6.Name = "button6";
            button6.Size = new Size(64, 45);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.TextImageRelation = TextImageRelation.TextAboveImage;
            button6.UseVisualStyleBackColor = false;
            button6.Click += CalculatorNumber;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(69, 43, 134);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(8, 110);
            button7.Name = "button7";
            button7.Size = new Size(64, 45);
            button7.TabIndex = 6;
            button7.Text = "1";
            button7.TextImageRelation = TextImageRelation.TextAboveImage;
            button7.UseVisualStyleBackColor = false;
            button7.Click += CalculatorNumber;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(69, 43, 134);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(78, 110);
            button8.Name = "button8";
            button8.Size = new Size(64, 45);
            button8.TabIndex = 7;
            button8.Text = "2";
            button8.TextImageRelation = TextImageRelation.TextAboveImage;
            button8.UseVisualStyleBackColor = false;
            button8.Click += CalculatorNumber;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(69, 43, 134);
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Location = new Point(148, 110);
            button9.Name = "button9";
            button9.Size = new Size(64, 45);
            button9.TabIndex = 8;
            button9.Text = "3";
            button9.TextImageRelation = TextImageRelation.TextAboveImage;
            button9.UseVisualStyleBackColor = false;
            button9.Click += CalculatorNumber;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(69, 43, 134);
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button10.ForeColor = Color.White;
            button10.Location = new Point(8, 161);
            button10.Name = "button10";
            button10.Size = new Size(50, 45);
            button10.TabIndex = 9;
            button10.Text = "0";
            button10.TextImageRelation = TextImageRelation.TextAboveImage;
            button10.UseVisualStyleBackColor = false;
            button10.Click += CalculatorNumber;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(69, 43, 134);
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button11.ForeColor = Color.White;
            button11.Location = new Point(64, 161);
            button11.Name = "button11";
            button11.Size = new Size(53, 45);
            button11.TabIndex = 10;
            button11.Text = ".";
            button11.TextImageRelation = TextImageRelation.TextAboveImage;
            button11.UseVisualStyleBackColor = false;
            button11.Click += CalculatorNumber;
            // 
            // button12
            // 
            button12.BackColor = Color.OliveDrab;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button12.ForeColor = Color.White;
            button12.Location = new Point(123, 161);
            button12.Name = "button12";
            button12.Size = new Size(89, 45);
            button12.TabIndex = 11;
            button12.Tag = "1";
            button12.Text = "=";
            button12.TextImageRelation = TextImageRelation.TextAboveImage;
            button12.UseVisualStyleBackColor = false;
            button12.Click += EventsCalculator;
            // 
            // button13
            // 
            button13.BackColor = Color.OliveDrab;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button13.ForeColor = Color.White;
            button13.Location = new Point(8, 212);
            button13.Name = "button13";
            button13.Size = new Size(50, 45);
            button13.TabIndex = 12;
            button13.Tag = "2";
            button13.Text = "+";
            button13.TextImageRelation = TextImageRelation.TextAboveImage;
            button13.UseVisualStyleBackColor = false;
            button13.Click += EventsCalculator;
            // 
            // button14
            // 
            button14.BackColor = Color.OliveDrab;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button14.ForeColor = Color.White;
            button14.Location = new Point(64, 212);
            button14.Name = "button14";
            button14.Size = new Size(53, 45);
            button14.TabIndex = 13;
            button14.Tag = "3";
            button14.Text = "-";
            button14.TextImageRelation = TextImageRelation.TextAboveImage;
            button14.UseVisualStyleBackColor = false;
            button14.Click += EventsCalculator;
            // 
            // button15
            // 
            button15.BackColor = Color.OliveDrab;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button15.ForeColor = Color.White;
            button15.Location = new Point(123, 212);
            button15.Name = "button15";
            button15.Size = new Size(46, 45);
            button15.TabIndex = 14;
            button15.Tag = "4";
            button15.Text = "x";
            button15.TextImageRelation = TextImageRelation.TextAboveImage;
            button15.UseVisualStyleBackColor = false;
            button15.Click += EventsCalculator;
            // 
            // button17
            // 
            button17.BackColor = Color.FromArgb(192, 0, 0);
            button17.FlatStyle = FlatStyle.Flat;
            button17.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button17.ForeColor = Color.White;
            button17.Location = new Point(175, 212);
            button17.Name = "button17";
            button17.Size = new Size(39, 45);
            button17.TabIndex = 16;
            button17.Tag = "6";
            button17.Text = "C";
            button17.TextImageRelation = TextImageRelation.TextAboveImage;
            button17.UseVisualStyleBackColor = false;
            button17.Click += EventsCalculator;
            // 
            // button16
            // 
            button16.BackColor = Color.OliveDrab;
            button16.Cursor = Cursors.Hand;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button16.ForeColor = Color.White;
            button16.Location = new Point(8, 263);
            button16.Name = "button16";
            button16.Size = new Size(84, 45);
            button16.TabIndex = 15;
            button16.Tag = "5";
            button16.Text = "Merr";
            button16.TextImageRelation = TextImageRelation.TextAboveImage;
            button16.UseVisualStyleBackColor = false;
            button16.Click += EventsCalculator;
            // 
            // btnKyqu
            // 
            btnKyqu.BackColor = Color.OliveDrab;
            btnKyqu.Cursor = Cursors.Hand;
            btnKyqu.FlatStyle = FlatStyle.Flat;
            btnKyqu.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnKyqu.ForeColor = Color.White;
            btnKyqu.Location = new Point(98, 263);
            btnKyqu.Name = "btnKyqu";
            btnKyqu.Size = new Size(116, 45);
            btnKyqu.TabIndex = 17;
            btnKyqu.Tag = "7";
            btnKyqu.Text = "Kyqu ";
            btnKyqu.TextImageRelation = TextImageRelation.TextAboveImage;
            btnKyqu.UseVisualStyleBackColor = false;
            btnKyqu.Click += btnKyqu_Click;
            // 
            // txtTextCalculator
            // 
            txtTextCalculator.BackColor = Color.FromArgb(69, 43, 134);
            txtTextCalculator.BorderStyle = BorderStyle.None;
            txtTextCalculator.Dock = DockStyle.Top;
            txtTextCalculator.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtTextCalculator.ForeColor = Color.White;
            txtTextCalculator.Location = new Point(0, 0);
            txtTextCalculator.Name = "txtTextCalculator";
            txtTextCalculator.Size = new Size(219, 32);
            txtTextCalculator.TabIndex = 1;
            txtTextCalculator.Text = "0";
            txtTextCalculator.TextAlign = HorizontalAlignment.Center;
            txtTextCalculator.KeyPress += txtTextCalculator_KeyPress;
            // 
            // Body
            // 
            Body.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Body.BackColor = Color.FromArgb(69, 43, 134);
            Body.Location = new Point(237, 86);
            Body.Name = "Body";
            Body.Size = new Size(804, 712);
            Body.TabIndex = 3;
            // 
            // TicketPanel
            // 
            TicketPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            TicketPanel.BackColor = Color.FromArgb(69, 43, 134);
            TicketPanel.Controls.Add(pnlTotalRows);
            TicketPanel.Controls.Add(dataGridView);
            TicketPanel.Controls.Add(panel1);
            TicketPanel.Controls.Add(flowLayoutPanel2);
            TicketPanel.Controls.Add(btnPastroTiketen);
            TicketPanel.Controls.Add(button20);
            TicketPanel.Controls.Add(button19);
            TicketPanel.Controls.Add(panel4);
            TicketPanel.Controls.Add(label10);
            TicketPanel.Controls.Add(label3);
            TicketPanel.Location = new Point(1047, 86);
            TicketPanel.Name = "TicketPanel";
            TicketPanel.Size = new Size(415, 712);
            TicketPanel.TabIndex = 4;
            // 
            // pnlTotalRows
            // 
            pnlTotalRows.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTotalRows.BackColor = Color.FromArgb(49, 30, 95);
            pnlTotalRows.Controls.Add(label8);
            pnlTotalRows.Location = new Point(7, 152);
            pnlTotalRows.Name = "pnlTotalRows";
            pnlTotalRows.Size = new Size(400, 47);
            pnlTotalRows.TabIndex = 19;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(89, 10);
            label8.Name = "label8";
            label8.Size = new Size(216, 26);
            label8.TabIndex = 9;
            label8.Text = "Zgjedh produkte për porosi";
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Order, Quantity, Price, Total, btnLargo });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(69, 43, 134);
            dataGridViewCellStyle4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(69, 43, 134);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.GridColor = Color.FromArgb(69, 43, 134);
            dataGridView.Location = new Point(7, 123);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(69, 43, 134);
            dataGridViewCellStyle5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(69, 43, 134);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(69, 43, 134);
            dataGridViewCellStyle6.Font = new Font("Poppins", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(69, 43, 134);
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(400, 511);
            dataGridView.TabIndex = 20;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            dataGridView.CellValueChanged += dataGridView_CellValueChanged;
            dataGridView.RowsAdded += dataGridView_RowsAdded;
            dataGridView.RowsRemoved += dataGridView_RowsRemoved;
            // 
            // Id
            // 
            Id.HeaderText = "Num";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // Order
            // 
            Order.HeaderText = "Porosia";
            Order.Name = "Order";
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Quantity.HeaderText = "Sasia";
            Quantity.Name = "Quantity";
            Quantity.Width = 50;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Price.HeaderText = "Cmimi";
            Price.Name = "Price";
            Price.Width = 60;
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.Width = 60;
            // 
            // btnLargo
            // 
            btnLargo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle3.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Red;
            btnLargo.DefaultCellStyle = dataGridViewCellStyle3;
            btnLargo.FlatStyle = FlatStyle.System;
            btnLargo.HeaderText = "Largo";
            btnLargo.Name = "btnLargo";
            btnLargo.Text = "-";
            btnLargo.ToolTipText = "-";
            btnLargo.UseColumnTextForButtonValue = true;
            btnLargo.Width = 50;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(lblTotal);
            panel1.Location = new Point(215, 640);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 69);
            panel1.TabIndex = 18;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Poppins", 13.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(27, 18);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(136, 34);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "Totali: 0.00€";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(lblTavolina);
            flowLayoutPanel2.Location = new Point(7, 82);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel2.Size = new Size(400, 32);
            flowLayoutPanel2.TabIndex = 17;
            // 
            // lblTavolina
            // 
            lblTavolina.Anchor = AnchorStyles.Top;
            lblTavolina.AutoSize = true;
            lblTavolina.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTavolina.ForeColor = Color.White;
            lblTavolina.Location = new Point(290, 0);
            lblTavolina.Name = "lblTavolina";
            lblTavolina.RightToLeft = RightToLeft.Yes;
            lblTavolina.Size = new Size(107, 23);
            lblTavolina.TabIndex = 11;
            lblTavolina.Text = "Nuk ka tavolinë";
            lblTavolina.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnPastroTiketen
            // 
            btnPastroTiketen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPastroTiketen.BackColor = Color.FromArgb(192, 0, 0);
            btnPastroTiketen.Cursor = Cursors.Hand;
            btnPastroTiketen.FlatStyle = FlatStyle.Flat;
            btnPastroTiketen.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPastroTiketen.ForeColor = Color.White;
            btnPastroTiketen.Location = new Point(291, 9);
            btnPastroTiketen.Name = "btnPastroTiketen";
            btnPastroTiketen.Size = new Size(116, 36);
            btnPastroTiketen.TabIndex = 16;
            btnPastroTiketen.Tag = "1";
            btnPastroTiketen.Text = "Pastro Tiketen";
            btnPastroTiketen.TextImageRelation = TextImageRelation.TextAboveImage;
            btnPastroTiketen.UseVisualStyleBackColor = false;
            btnPastroTiketen.Click += btnPastroTiketen_Click;
            // 
            // button20
            // 
            button20.Anchor = AnchorStyles.Bottom;
            button20.BackColor = Color.FromArgb(0, 64, 0);
            button20.Cursor = Cursors.Hand;
            button20.FlatStyle = FlatStyle.Flat;
            button20.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button20.ForeColor = Color.White;
            button20.Location = new Point(3, 640);
            button20.Name = "button20";
            button20.Size = new Size(103, 69);
            button20.TabIndex = 14;
            button20.Tag = "1";
            button20.Text = "Porosit";
            button20.TextImageRelation = TextImageRelation.TextAboveImage;
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            // 
            // button19
            // 
            button19.Anchor = AnchorStyles.Bottom;
            button19.BackColor = Color.FromArgb(0, 64, 0);
            button19.Cursor = Cursors.Hand;
            button19.FlatStyle = FlatStyle.Flat;
            button19.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button19.ForeColor = Color.White;
            button19.Location = new Point(112, 640);
            button19.Name = "button19";
            button19.Size = new Size(97, 69);
            button19.TabIndex = 13;
            button19.Tag = "1";
            button19.Text = "Tavolina";
            button19.TextImageRelation = TextImageRelation.TextAboveImage;
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BackColor = Color.White;
            panel4.Location = new Point(7, 78);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 3);
            panel4.TabIndex = 10;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(3, 57);
            label10.Name = "label10";
            label10.Size = new Size(64, 23);
            label10.TabIndex = 9;
            label10.Text = "Tavolina";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 12);
            label3.Name = "label3";
            label3.Size = new Size(63, 30);
            label3.TabIndex = 8;
            label3.Text = "Tiketa";
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 30, 95);
            ClientSize = new Size(1474, 810);
            Controls.Add(TicketPanel);
            Controls.Add(Body);
            Controls.Add(panel3);
            Controls.Add(pnlKategorit);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlWarning.ResumeLayout(false);
            pnlWarning.PerformLayout();
            panel2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            pnlKategorit.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            TicketPanel.ResumeLayout(false);
            TicketPanel.PerformLayout();
            pnlTotalRows.ResumeLayout(false);
            pnlTotalRows.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Label label1;
        private Panel pnlKategorit;
        private Panel panel6;
        private FlowLayoutPanel BodyCategory;
        private Label label2;
        private Panel panel3;
        private Panel Body;
        private Panel TicketPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtTextCalculator;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Label lblDashboard;
        private Button btnKyqu;
        private Panel Line;
        private Label lblPuntori;
        private Label lblPorosia;
        private Label lblTime;
        private Label lblReport;
        private Label lblStoku;
        private Label lblCategory;
        private Label lblTavolina;
        private Panel panel4;
        private Label label10;
        private Label label3;
        private Button button19;
        private Label lblTotal;
        private Button button20;
        private Button btnPastroTiketen;
        private Label lblTjera;
        private Label lblPuntoret;
        private Label lblTavolinatControl;
        private Label lblNgarkimi;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel1;
        private PictureBox picClose;
        private Label label5;
        private Label label4;
        private Panel pnlTotalRows;
        private Label label8;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Order;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewButtonColumn btnLargo;
        private System.Windows.Forms.Timer timer;
        private PictureBox picMinimize;
        private FlowLayoutPanel flowLayoutPanel3;
        private Panel panel2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem porositEFshirjaToolStripMenuItem;
        private ToolStripMenuItem rrethSistemitToolStripMenuItem;
        private ToolStripMenuItem lokacioniIRuajtejsSeDokumentaveToolStripMenuItem;
        private Panel pnlWarning;
    }
}