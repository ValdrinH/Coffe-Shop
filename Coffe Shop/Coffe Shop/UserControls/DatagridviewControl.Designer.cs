namespace Coffe_Shop.UserControls
{
    partial class DatagridviewControl
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
            dataGridView = new DataGridView();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblTotal = new Label();
            panel2 = new Panel();
            btnFshije = new Button();
            btnRuaj = new Button();
            panelError = new Panel();
            lbl = new Label();
            button1 = new Button();
            picRefresh = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panelError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRefresh).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewCellStyle1.Font = new Font("Poppins", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.BackgroundColor = Color.FromArgb(69, 43, 134);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(69, 43, 134);
            dataGridViewCellStyle2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.White;
            dataGridView.Location = new Point(0, 62);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(148, 128, 203);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Poppins", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(148, 128, 203);
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(783, 601);
            dataGridView.TabIndex = 17;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.RowHeaderMouseClick += dataGridView_RowHeaderMouseClick;
            dataGridView.RowPostPaint += dataGridView_RowPostPaint;
            dataGridView.RowsAdded += dataGridView_RowsAdded;
            dataGridView.RowsRemoved += dataGridView_RowsRemoved;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 669);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 43);
            panel1.TabIndex = 18;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblTotal);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 10, 0, 0);
            flowLayoutPanel1.Size = new Size(600, 43);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(3, 10);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(109, 23);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Total Rreshta: 0";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnFshije);
            panel2.Controls.Add(btnRuaj);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(600, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(189, 43);
            panel2.TabIndex = 1;
            // 
            // btnFshije
            // 
            btnFshije.Anchor = AnchorStyles.Bottom;
            btnFshije.BackColor = Color.FromArgb(192, 0, 0);
            btnFshije.Cursor = Cursors.Hand;
            btnFshije.FlatStyle = FlatStyle.Flat;
            btnFshije.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFshije.ForeColor = Color.White;
            btnFshije.Location = new Point(102, 3);
            btnFshije.Name = "btnFshije";
            btnFshije.Size = new Size(87, 40);
            btnFshije.TabIndex = 15;
            btnFshije.Tag = "1";
            btnFshije.Text = "Fshije";
            btnFshije.TextImageRelation = TextImageRelation.TextAboveImage;
            btnFshije.UseVisualStyleBackColor = false;
            btnFshije.Visible = false;
            // 
            // btnRuaj
            // 
            btnRuaj.Anchor = AnchorStyles.Bottom;
            btnRuaj.BackColor = Color.FromArgb(28, 209, 123);
            btnRuaj.Cursor = Cursors.Hand;
            btnRuaj.FlatStyle = FlatStyle.Flat;
            btnRuaj.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRuaj.ForeColor = Color.White;
            btnRuaj.Location = new Point(9, 2);
            btnRuaj.Name = "btnRuaj";
            btnRuaj.Size = new Size(87, 40);
            btnRuaj.TabIndex = 16;
            btnRuaj.Tag = "1";
            btnRuaj.Text = "Ruaj";
            btnRuaj.TextImageRelation = TextImageRelation.TextAboveImage;
            btnRuaj.UseVisualStyleBackColor = false;
            btnRuaj.Visible = false;
            btnRuaj.Click += btnRuaj_Click;
            // 
            // panelError
            // 
            panelError.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelError.BackColor = Color.FromArgb(69, 43, 134);
            panelError.Controls.Add(lbl);
            panelError.Location = new Point(3, 310);
            panelError.Name = "panelError";
            panelError.Size = new Size(780, 100);
            panelError.TabIndex = 20;
            panelError.Visible = false;
            // 
            // lbl
            // 
            lbl.Anchor = AnchorStyles.None;
            lbl.AutoSize = true;
            lbl.Font = new Font("Poppins", 14.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.ForeColor = Color.Red;
            lbl.Location = new Point(258, 36);
            lbl.Name = "lbl";
            lbl.Size = new Size(281, 36);
            lbl.TabIndex = 11;
            lbl.Text = "Nuk u gjet asnjë e dhënë !!!";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Teal;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.icons8_filtering_30;
            button1.Location = new Point(687, 11);
            button1.Name = "button1";
            button1.Size = new Size(96, 39);
            button1.TabIndex = 21;
            button1.Tag = "1";
            button1.Text = "   Filtro";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // picRefresh
            // 
            picRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picRefresh.Cursor = Cursors.Hand;
            picRefresh.Image = Properties.Resources.icons8_refresh_38;
            picRefresh.Location = new Point(643, 11);
            picRefresh.Name = "picRefresh";
            picRefresh.Size = new Size(38, 40);
            picRefresh.TabIndex = 22;
            picRefresh.TabStop = false;
            picRefresh.Click += picRefresh_Click;
            // 
            // DatagridviewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 43, 134);
            Controls.Add(picRefresh);
            Controls.Add(button1);
            Controls.Add(panelError);
            Controls.Add(panel1);
            Controls.Add(dataGridView);
            Name = "DatagridviewControl";
            Size = new Size(789, 712);
            Load += DatagridviewControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panelError.ResumeLayout(false);
            panelError.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRefresh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblTotal;
        private Panel panelError;
        private Label lbl;
        private Panel panel2;
        private Button btnRuaj;
        private Button btnFshije;
        private Button button1;
        private PictureBox picRefresh;
    }
}
