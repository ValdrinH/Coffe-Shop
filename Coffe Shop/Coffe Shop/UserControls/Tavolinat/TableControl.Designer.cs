namespace Coffe_Shop.UserControls.Tavolinat
{
    partial class TableControl
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
            flowLayoutPanel = new FlowLayoutPanel();
            btnRuaj = new Button();
            btnFshije = new Button();
            txtTextCalculator = new TextBox();
            panel1 = new Panel();
            txtEmri = new TextBox();
            label1 = new Label();
            btnShtoTavolinen = new Button();
            picBack = new PictureBox();
            lblTitle = new Label();
            btnNdrysho = new Button();
            panelError = new Panel();
            lbl = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBack).BeginInit();
            panelError.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Location = new Point(3, 102);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(798, 607);
            flowLayoutPanel.TabIndex = 0;
            flowLayoutPanel.ControlAdded += flowLayoutPanel_ControlAdded;
            flowLayoutPanel.ControlRemoved += flowLayoutPanel_ControlRemoved;
            // 
            // btnRuaj
            // 
            btnRuaj.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRuaj.BackColor = Color.FromArgb(28, 209, 123);
            btnRuaj.Cursor = Cursors.Hand;
            btnRuaj.FlatStyle = FlatStyle.Flat;
            btnRuaj.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRuaj.ForeColor = Color.White;
            btnRuaj.Location = new Point(724, 53);
            btnRuaj.Name = "btnRuaj";
            btnRuaj.Size = new Size(63, 30);
            btnRuaj.TabIndex = 46;
            btnRuaj.Tag = "";
            btnRuaj.Text = "Shto";
            btnRuaj.TextImageRelation = TextImageRelation.TextAboveImage;
            btnRuaj.UseVisualStyleBackColor = false;
            btnRuaj.Click += btnRuaj_Click;
            // 
            // btnFshije
            // 
            btnFshije.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFshije.BackColor = Color.FromArgb(192, 0, 0);
            btnFshije.Cursor = Cursors.Hand;
            btnFshije.FlatStyle = FlatStyle.Flat;
            btnFshije.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFshije.ForeColor = Color.White;
            btnFshije.Location = new Point(554, 53);
            btnFshije.Name = "btnFshije";
            btnFshije.Size = new Size(76, 30);
            btnFshije.TabIndex = 47;
            btnFshije.Tag = "";
            btnFshije.Text = "Fshij";
            btnFshije.TextImageRelation = TextImageRelation.TextAboveImage;
            btnFshije.UseVisualStyleBackColor = false;
            btnFshije.Click += btnFshije_Click;
            // 
            // txtTextCalculator
            // 
            txtTextCalculator.BackColor = Color.FromArgb(69, 43, 134);
            txtTextCalculator.BorderStyle = BorderStyle.None;
            txtTextCalculator.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtTextCalculator.ForeColor = Color.White;
            txtTextCalculator.Location = new Point(0, 61);
            txtTextCalculator.Name = "txtTextCalculator";
            txtTextCalculator.PlaceholderText = "Kërko tavolinën";
            txtTextCalculator.Size = new Size(351, 32);
            txtTextCalculator.TabIndex = 48;
            txtTextCalculator.TextAlign = HorizontalAlignment.Center;
            txtTextCalculator.TextChanged += txtTextCalculator_TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtEmri);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnShtoTavolinen);
            panel1.Location = new Point(468, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 146);
            panel1.TabIndex = 49;
            panel1.Visible = false;
            // 
            // txtEmri
            // 
            txtEmri.BackColor = Color.White;
            txtEmri.BorderStyle = BorderStyle.None;
            txtEmri.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmri.ForeColor = Color.Black;
            txtEmri.Location = new Point(11, 61);
            txtEmri.MaximumSize = new Size(413, 24);
            txtEmri.Name = "txtEmri";
            txtEmri.PlaceholderText = "Emri i tavolinës";
            txtEmri.Size = new Size(301, 24);
            txtEmri.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(8, 28);
            label1.Name = "label1";
            label1.Size = new Size(136, 30);
            label1.TabIndex = 49;
            label1.Text = "Emri tavolinës:";
            // 
            // btnShtoTavolinen
            // 
            btnShtoTavolinen.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnShtoTavolinen.BackColor = Color.FromArgb(28, 209, 123);
            btnShtoTavolinen.Cursor = Cursors.Hand;
            btnShtoTavolinen.FlatStyle = FlatStyle.Flat;
            btnShtoTavolinen.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnShtoTavolinen.ForeColor = Color.White;
            btnShtoTavolinen.Location = new Point(178, 106);
            btnShtoTavolinen.Name = "btnShtoTavolinen";
            btnShtoTavolinen.Size = new Size(133, 30);
            btnShtoTavolinen.TabIndex = 47;
            btnShtoTavolinen.Tag = "";
            btnShtoTavolinen.Text = "Shtoje Tavolinën";
            btnShtoTavolinen.TextImageRelation = TextImageRelation.TextAboveImage;
            btnShtoTavolinen.UseVisualStyleBackColor = false;
            btnShtoTavolinen.Click += btnShtoTavolinen_Click;
            // 
            // picBack
            // 
            picBack.Cursor = Cursors.Hand;
            picBack.Image = Properties.Resources.icons8_back_35;
            picBack.Location = new Point(8, 8);
            picBack.Name = "picBack";
            picBack.Size = new Size(35, 35);
            picBack.SizeMode = PictureBoxSizeMode.AutoSize;
            picBack.TabIndex = 51;
            picBack.TabStop = false;
            picBack.Click += picBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(49, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(192, 37);
            lblTitle.TabIndex = 50;
            lblTitle.Text = "Zgjedh Tavolinën";
            // 
            // btnNdrysho
            // 
            btnNdrysho.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNdrysho.BackColor = Color.FromArgb(28, 209, 123);
            btnNdrysho.Cursor = Cursors.Hand;
            btnNdrysho.FlatStyle = FlatStyle.Flat;
            btnNdrysho.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNdrysho.ForeColor = Color.White;
            btnNdrysho.Location = new Point(636, 53);
            btnNdrysho.Name = "btnNdrysho";
            btnNdrysho.Size = new Size(82, 30);
            btnNdrysho.TabIndex = 52;
            btnNdrysho.Tag = "";
            btnNdrysho.Text = "Ndrysho";
            btnNdrysho.TextImageRelation = TextImageRelation.TextAboveImage;
            btnNdrysho.UseVisualStyleBackColor = false;
            btnNdrysho.Click += btnNdrysho_Click;
            // 
            // panelError
            // 
            panelError.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelError.Controls.Add(lbl);
            panelError.Location = new Point(9, 306);
            panelError.Name = "panelError";
            panelError.Size = new Size(786, 100);
            panelError.TabIndex = 53;
            panelError.Visible = false;
            // 
            // lbl
            // 
            lbl.Anchor = AnchorStyles.None;
            lbl.AutoSize = true;
            lbl.Font = new Font("Poppins", 14.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.ForeColor = Color.Red;
            lbl.Location = new Point(282, 31);
            lbl.Name = "lbl";
            lbl.Size = new Size(252, 36);
            lbl.TabIndex = 11;
            lbl.Text = "Nuk u gjet asnjë tabel !!!\r\n";
            // 
            // TableControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 43, 134);
            Controls.Add(panelError);
            Controls.Add(btnNdrysho);
            Controls.Add(picBack);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            Controls.Add(txtTextCalculator);
            Controls.Add(btnFshije);
            Controls.Add(btnRuaj);
            Controls.Add(flowLayoutPanel);
            Name = "TableControl";
            Size = new Size(804, 712);
            Load += TableControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBack).EndInit();
            panelError.ResumeLayout(false);
            panelError.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private Button btnRuaj;
        private Button btnFshije;
        private TextBox txtTextCalculator;
        private Panel panel1;
        private Button btnShtoTavolinen;
        private TextBox txtEmri;
        private Label label1;
        private PictureBox picBack;
        private Label label2;
        private Button btnNdrysho;
        private Panel panelError;
        private Label lbl;
        private Label lblTitle;
    }
}
