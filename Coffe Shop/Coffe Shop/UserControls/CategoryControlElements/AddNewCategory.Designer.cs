namespace Coffe_Shop.UserControls.CategoryControlElements
{
    partial class AddNewCategory
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
            label1 = new Label();
            btnRuaj = new Button();
            txtEmriPershkrimit = new TextBox();
            txtPershkrimi = new TextBox();
            label2 = new Label();
            label3 = new Label();
            picBack = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBack).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(53, 21);
            label1.Name = "label1";
            label1.Size = new Size(209, 37);
            label1.TabIndex = 18;
            label1.Text = "Shto kategori të re";
            // 
            // btnRuaj
            // 
            btnRuaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRuaj.BackColor = Color.FromArgb(0, 64, 0);
            btnRuaj.FlatStyle = FlatStyle.Flat;
            btnRuaj.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRuaj.ForeColor = Color.White;
            btnRuaj.Location = new Point(631, 652);
            btnRuaj.Name = "btnRuaj";
            btnRuaj.Size = new Size(144, 48);
            btnRuaj.TabIndex = 19;
            btnRuaj.Tag = "";
            btnRuaj.Text = "Ruaj";
            btnRuaj.TextImageRelation = TextImageRelation.TextAboveImage;
            btnRuaj.UseVisualStyleBackColor = false;
            btnRuaj.Click += btnRuaj_Click;
            // 
            // txtEmriPershkrimit
            // 
            txtEmriPershkrimit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmriPershkrimit.BackColor = Color.FromArgb(148, 128, 203);
            txtEmriPershkrimit.BorderStyle = BorderStyle.None;
            txtEmriPershkrimit.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmriPershkrimit.ForeColor = Color.White;
            txtEmriPershkrimit.Location = new Point(13, 155);
            txtEmriPershkrimit.MaximumSize = new Size(413, 24);
            txtEmriPershkrimit.Name = "txtEmriPershkrimit";
            txtEmriPershkrimit.PlaceholderText = "Emri i kategoris";
            txtEmriPershkrimit.Size = new Size(413, 24);
            txtEmriPershkrimit.TabIndex = 21;
            // 
            // txtPershkrimi
            // 
            txtPershkrimi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPershkrimi.BackColor = Color.FromArgb(148, 128, 203);
            txtPershkrimi.BorderStyle = BorderStyle.None;
            txtPershkrimi.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPershkrimi.ForeColor = Color.White;
            txtPershkrimi.Location = new Point(12, 227);
            txtPershkrimi.Multiline = true;
            txtPershkrimi.Name = "txtPershkrimi";
            txtPershkrimi.PlaceholderText = "Emri i kategoris";
            txtPershkrimi.ScrollBars = ScrollBars.Vertical;
            txtPershkrimi.Size = new Size(714, 327);
            txtPershkrimi.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(137, 30);
            label2.TabIndex = 23;
            label2.Text = "Emri kategoris:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 199);
            label3.Name = "label3";
            label3.Size = new Size(105, 30);
            label3.TabIndex = 24;
            label3.Text = "Përshkrimi:";
            // 
            // picBack
            // 
            picBack.Cursor = Cursors.Hand;
            picBack.Image = Properties.Resources.icons8_back_35;
            picBack.Location = new Point(12, 21);
            picBack.Name = "picBack";
            picBack.Size = new Size(35, 35);
            picBack.SizeMode = PictureBoxSizeMode.AutoSize;
            picBack.TabIndex = 25;
            picBack.TabStop = false;
            picBack.Click += picBack_Click;
            // 
            // AddNewCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 43, 134);
            Controls.Add(picBack);
            Controls.Add(txtEmriPershkrimit);
            Controls.Add(label2);
            Controls.Add(txtPershkrimi);
            Controls.Add(btnRuaj);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "AddNewCategory";
            Size = new Size(804, 712);
            ((System.ComponentModel.ISupportInitialize)picBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRuaj;
        private TextBox txtEmriPershkrimit;
        private TextBox txtPershkrimi;
        private Label label2;
        private Label label3;
        private PictureBox picBack;
    }
}
