namespace Coffe_Shop.UserControls.CoffeProfile
{
    partial class ControlProfile
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
            btnRuaj = new Button();
            label12 = new Label();
            picLogo = new PictureBox();
            txtEmri = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtAdresa = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            label6 = new Label();
            lblDtReg = new Label();
            txtNumriTelefonit = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // btnRuaj
            // 
            btnRuaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRuaj.BackColor = Color.DarkGreen;
            btnRuaj.Cursor = Cursors.Hand;
            btnRuaj.FlatStyle = FlatStyle.Flat;
            btnRuaj.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRuaj.ForeColor = Color.White;
            btnRuaj.Location = new Point(630, 646);
            btnRuaj.Name = "btnRuaj";
            btnRuaj.Size = new Size(144, 48);
            btnRuaj.TabIndex = 60;
            btnRuaj.Tag = "";
            btnRuaj.Text = "Ruaj";
            btnRuaj.TextImageRelation = TextImageRelation.TextAboveImage;
            btnRuaj.UseVisualStyleBackColor = false;
            btnRuaj.Click += btnRuaj_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(630, 229);
            label12.Name = "label12";
            label12.Size = new Size(53, 30);
            label12.TabIndex = 62;
            label12.Text = "Logo";
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Cursor = Cursors.Hand;
            picLogo.Image = Properties.Resources.Logo;
            picLogo.Location = new Point(555, 33);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(205, 193);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 58;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // txtEmri
            // 
            txtEmri.BackColor = Color.FromArgb(148, 128, 203);
            txtEmri.BorderStyle = BorderStyle.None;
            txtEmri.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmri.ForeColor = Color.White;
            txtEmri.Location = new Point(45, 278);
            txtEmri.Name = "txtEmri";
            txtEmri.PlaceholderText = "Emri i kafes";
            txtEmri.Size = new Size(715, 24);
            txtEmri.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(44, 245);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 53;
            label1.Text = "Emri Kafes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(41, 21);
            label2.Name = "label2";
            label2.Size = new Size(287, 70);
            label2.TabIndex = 50;
            label2.Text = "Coffee Shop ";
            // 
            // txtAdresa
            // 
            txtAdresa.BackColor = Color.FromArgb(148, 128, 203);
            txtAdresa.BorderStyle = BorderStyle.None;
            txtAdresa.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdresa.ForeColor = Color.White;
            txtAdresa.Location = new Point(46, 343);
            txtAdresa.Multiline = true;
            txtAdresa.Name = "txtAdresa";
            txtAdresa.PlaceholderText = "Adresa";
            txtAdresa.Size = new Size(715, 67);
            txtAdresa.TabIndex = 63;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(41, 312);
            label3.Name = "label3";
            label3.Size = new Size(143, 30);
            label3.TabIndex = 64;
            label3.Text = "Adresa e kafes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(45, 424);
            label4.Name = "label4";
            label4.Size = new Size(161, 30);
            label4.TabIndex = 66;
            label4.Text = "Numri konaktues:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(148, 128, 203);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(46, 529);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email adresa";
            txtEmail.Size = new Size(715, 24);
            txtEmail.TabIndex = 67;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(45, 496);
            label5.Name = "label5";
            label5.Size = new Size(67, 30);
            label5.TabIndex = 68;
            label5.Text = "Emaili:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(54, 83);
            label6.Name = "label6";
            label6.Size = new Size(263, 30);
            label6.TabIndex = 69;
            label6.Text = "Powered by: V-Software 2023";
            // 
            // lblDtReg
            // 
            lblDtReg.AutoSize = true;
            lblDtReg.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDtReg.ForeColor = Color.White;
            lblDtReg.Location = new Point(34, 655);
            lblDtReg.Name = "lblDtReg";
            lblDtReg.Size = new Size(172, 30);
            lblDtReg.TabIndex = 70;
            lblDtReg.Text = "Data e regjistrimit: ";
            lblDtReg.Visible = false;
            // 
            // txtNumriTelefonit
            // 
            txtNumriTelefonit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNumriTelefonit.BackColor = Color.FromArgb(148, 128, 203);
            txtNumriTelefonit.BeepOnError = true;
            txtNumriTelefonit.BorderStyle = BorderStyle.None;
            txtNumriTelefonit.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumriTelefonit.ForeColor = Color.White;
            txtNumriTelefonit.Location = new Point(46, 457);
            txtNumriTelefonit.Mask = "(999) 000-0000";
            txtNumriTelefonit.Name = "txtNumriTelefonit";
            txtNumriTelefonit.Size = new Size(177, 24);
            txtNumriTelefonit.TabIndex = 71;
            // 
            // ControlProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 43, 134);
            Controls.Add(txtNumriTelefonit);
            Controls.Add(lblDtReg);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtAdresa);
            Controls.Add(label3);
            Controls.Add(btnRuaj);
            Controls.Add(label12);
            Controls.Add(picLogo);
            Controls.Add(txtEmri);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "ControlProfile";
            Size = new Size(804, 712);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRuaj;
        private Label label12;
        private PictureBox picLogo;
        private TextBox txtEmri;
        private Label label1;
        private Label label2;
        private TextBox txtAdresa;
        private Label label3;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private Label label6;
        private Label lblDtReg;
        private MaskedTextBox txtNumriTelefonit;
    }
}
