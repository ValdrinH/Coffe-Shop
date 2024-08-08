namespace Coffe_Shop.Forms
{
    partial class FshiPorosin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPuntori = new Label();
            groupBox1 = new GroupBox();
            lblDataOra = new Label();
            lblTavolina = new Label();
            lblInvoice = new Label();
            lblTitle = new Label();
            groupBox2 = new GroupBox();
            txtDetajet = new TextBox();
            btnFshije = new Button();
            btnAnulo = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblPuntori
            // 
            lblPuntori.AutoSize = true;
            lblPuntori.Location = new Point(9, 29);
            lblPuntori.Name = "lblPuntori";
            lblPuntori.Size = new Size(52, 15);
            lblPuntori.TabIndex = 0;
            lblPuntori.Text = "Puntori: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblDataOra);
            groupBox1.Controls.Add(lblTavolina);
            groupBox1.Controls.Add(lblInvoice);
            groupBox1.Controls.Add(lblPuntori);
            groupBox1.Location = new Point(12, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 149);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detajet e fshirjes";
            // 
            // lblDataOra
            // 
            lblDataOra.AutoSize = true;
            lblDataOra.ForeColor = Color.Black;
            lblDataOra.Location = new Point(9, 107);
            lblDataOra.Name = "lblDataOra";
            lblDataOra.Size = new Size(111, 15);
            lblDataOra.TabIndex = 3;
            lblDataOra.Text = "Data/Ora e Porosis: ";
            // 
            // lblTavolina
            // 
            lblTavolina.AutoSize = true;
            lblTavolina.ForeColor = Color.Black;
            lblTavolina.Location = new Point(9, 81);
            lblTavolina.Name = "lblTavolina";
            lblTavolina.Size = new Size(89, 15);
            lblTavolina.TabIndex = 2;
            lblTavolina.Text = "Tavolina: Table3";
            // 
            // lblInvoice
            // 
            lblInvoice.AutoSize = true;
            lblInvoice.ForeColor = Color.IndianRed;
            lblInvoice.Location = new Point(9, 55);
            lblInvoice.Name = "lblInvoice";
            lblInvoice.Size = new Size(117, 15);
            lblInvoice.TabIndex = 1;
            lblInvoice.Text = "Invoice: INV_1234567";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(56, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(221, 30);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Për të fshir porosin ju duhet të plotësoni \r\nkëto të dhëna më posht!";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDetajet);
            groupBox2.Location = new Point(12, 220);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(315, 149);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detajet";
            // 
            // txtDetajet
            // 
            txtDetajet.BorderStyle = BorderStyle.None;
            txtDetajet.Dock = DockStyle.Fill;
            txtDetajet.Location = new Point(3, 19);
            txtDetajet.Multiline = true;
            txtDetajet.Name = "txtDetajet";
            txtDetajet.PlaceholderText = "Shkruaj detajet e fshirjes...";
            txtDetajet.ScrollBars = ScrollBars.Horizontal;
            txtDetajet.Size = new Size(309, 127);
            txtDetajet.TabIndex = 0;
            // 
            // btnFshije
            // 
            btnFshije.FlatStyle = FlatStyle.Flat;
            btnFshije.ForeColor = Color.IndianRed;
            btnFshije.Location = new Point(230, 406);
            btnFshije.Name = "btnFshije";
            btnFshije.Size = new Size(94, 30);
            btnFshije.TabIndex = 4;
            btnFshije.Text = "Fshije";
            btnFshije.UseVisualStyleBackColor = true;
            btnFshije.Click += btnFshije_Click;
            // 
            // btnAnulo
            // 
            btnAnulo.FlatStyle = FlatStyle.Flat;
            btnAnulo.ForeColor = SystemColors.ActiveCaption;
            btnAnulo.Location = new Point(130, 406);
            btnAnulo.Name = "btnAnulo";
            btnAnulo.Size = new Size(94, 30);
            btnAnulo.TabIndex = 5;
            btnAnulo.Text = "Anulo";
            btnAnulo.UseVisualStyleBackColor = true;
            btnAnulo.Click += btnAnulo_Click;
            // 
            // FshiPorosin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 448);
            Controls.Add(btnAnulo);
            Controls.Add(btnFshije);
            Controls.Add(groupBox2);
            Controls.Add(lblTitle);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(355, 487);
            MinimizeBox = false;
            MinimumSize = new Size(355, 487);
            Name = "FshiPorosin";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Fshi Porosin";
            FormClosed += FshiPorosin_FormClosed;
            Load += FshiPorosin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPuntori;
        private GroupBox groupBox1;
        private Label lblTitle;
        private Label lblDataOra;
        private Label lblTavolina;
        private Label lblInvoice;
        private GroupBox groupBox2;
        private TextBox txtDetajet;
        private Button btnFshije;
        private Button btnAnulo;
    }
}