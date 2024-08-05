namespace Coffe_Shop.UserControls
{
    partial class RrethSistemit
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
            panel1 = new Panel();
            panel4 = new Panel();
            lblContact = new Label();
            btnContact = new Button();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            panel2 = new Panel();
            lblVersion = new Label();
            btnUpdate = new Button();
            panel3 = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 712);
            panel1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblContact);
            panel4.Controls.Add(btnContact);
            panel4.Controls.Add(richTextBox1);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 245);
            panel4.Name = "panel4";
            panel4.Size = new Size(787, 905);
            panel4.TabIndex = 1;
            // 
            // lblContact
            // 
            lblContact.Anchor = AnchorStyles.Bottom;
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Poppins", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblContact.Location = new Point(312, 815);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(184, 31);
            lblContact.TabIndex = 7;
            lblContact.Text = "Na kontaktoni këtu";
            // 
            // btnContact
            // 
            btnContact.Anchor = AnchorStyles.Bottom;
            btnContact.BackColor = Color.SteelBlue;
            btnContact.Cursor = Cursors.Hand;
            btnContact.FlatAppearance.BorderSize = 0;
            btnContact.FlatStyle = FlatStyle.Flat;
            btnContact.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnContact.ForeColor = SystemColors.ButtonFace;
            btnContact.Location = new Point(350, 845);
            btnContact.Name = "btnContact";
            btnContact.Size = new Size(100, 39);
            btnContact.TabIndex = 6;
            btnContact.Text = "Këtu";
            btnContact.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = Color.White;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(18, 77);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(766, 718);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 32);
            label3.Name = "label3";
            label3.Size = new Size(184, 42);
            label3.TabIndex = 4;
            label3.Text = "Rreth Sistemit";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblVersion);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(lblSubtitle);
            panel2.Controls.Add(lblTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(787, 245);
            panel2.TabIndex = 0;
            // 
            // lblVersion
            // 
            lblVersion.Anchor = AnchorStyles.None;
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Poppins", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblVersion.Location = new Point(373, 155);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(50, 31);
            lblVersion.TabIndex = 8;
            lblVersion.Text = "1.0.0";
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(302, 189);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(190, 39);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Shto përditësimin e ri";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 243);
            panel3.Name = "panel3";
            panel3.Size = new Size(787, 2);
            panel3.TabIndex = 4;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Anchor = AnchorStyles.None;
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitle.Location = new Point(250, 113);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(310, 42);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "Powered by: V-Software ";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Poppins", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(92, 51);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(621, 62);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Coffe Shop Management System";
            // 
            // RrethSistemit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "RrethSistemit";
            Size = new Size(804, 712);
            Load += RrethSistemit_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lblSubtitle;
        private Label lblTitle;
        private Panel panel4;
        private Label label3;
        private Button btnUpdate;
        private RichTextBox richTextBox1;
        private Label lblContact;
        private Button btnContact;
        private Label lblVersion;
    }
}
