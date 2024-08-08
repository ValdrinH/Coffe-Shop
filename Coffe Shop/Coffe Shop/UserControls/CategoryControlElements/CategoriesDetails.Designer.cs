namespace Coffe_Shop.UserControls.CategoryControlElements
{
    partial class CategoriesDetails
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
            txtEmriPershkrimit = new TextBox();
            label2 = new Label();
            txtPershkrimi = new TextBox();
            label3 = new Label();
            btnRuaj = new Button();
            btnFshije = new Button();
            SuspendLayout();
            // 
            // txtEmriPershkrimit
            // 
            txtEmriPershkrimit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmriPershkrimit.BackColor = Color.FromArgb(148, 128, 203);
            txtEmriPershkrimit.BorderStyle = BorderStyle.None;
            txtEmriPershkrimit.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmriPershkrimit.ForeColor = Color.White;
            txtEmriPershkrimit.Location = new Point(18, 66);
            txtEmriPershkrimit.MaximumSize = new Size(413, 24);
            txtEmriPershkrimit.Name = "txtEmriPershkrimit";
            txtEmriPershkrimit.PlaceholderText = "Emri i kategoris";
            txtEmriPershkrimit.Size = new Size(371, 24);
            txtEmriPershkrimit.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 33);
            label2.Name = "label2";
            label2.Size = new Size(137, 30);
            label2.TabIndex = 27;
            label2.Text = "Emri kategoris:";
            // 
            // txtPershkrimi
            // 
            txtPershkrimi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPershkrimi.BackColor = Color.FromArgb(148, 128, 203);
            txtPershkrimi.BorderStyle = BorderStyle.None;
            txtPershkrimi.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPershkrimi.ForeColor = Color.White;
            txtPershkrimi.Location = new Point(17, 138);
            txtPershkrimi.Multiline = true;
            txtPershkrimi.Name = "txtPershkrimi";
            txtPershkrimi.PlaceholderText = "Emri i kategoris";
            txtPershkrimi.ScrollBars = ScrollBars.Vertical;
            txtPershkrimi.Size = new Size(551, 281);
            txtPershkrimi.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(17, 110);
            label3.Name = "label3";
            label3.Size = new Size(105, 30);
            label3.TabIndex = 28;
            label3.Text = "Përshkrimi:";
            // 
            // btnRuaj
            // 
            btnRuaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRuaj.BackColor = Color.FromArgb(0, 64, 0);
            btnRuaj.FlatStyle = FlatStyle.Flat;
            btnRuaj.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRuaj.ForeColor = Color.White;
            btnRuaj.Location = new Point(457, 459);
            btnRuaj.Name = "btnRuaj";
            btnRuaj.Size = new Size(111, 34);
            btnRuaj.TabIndex = 29;
            btnRuaj.Tag = "";
            btnRuaj.Text = "Ruaj";
            btnRuaj.TextImageRelation = TextImageRelation.TextAboveImage;
            btnRuaj.UseVisualStyleBackColor = false;
            btnRuaj.Click += btnRuaj_Click;
            // 
            // btnFshije
            // 
            btnFshije.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFshije.BackColor = Color.FromArgb(192, 64, 0);
            btnFshije.FlatStyle = FlatStyle.Flat;
            btnFshije.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFshije.ForeColor = Color.White;
            btnFshije.Location = new Point(340, 459);
            btnFshije.Name = "btnFshije";
            btnFshije.Size = new Size(111, 34);
            btnFshije.TabIndex = 30;
            btnFshije.Tag = "";
            btnFshije.Text = "Fshije";
            btnFshije.TextImageRelation = TextImageRelation.TextAboveImage;
            btnFshije.UseVisualStyleBackColor = false;
            btnFshije.Click += btnFshije_Click;
            // 
            // CategoriesDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 43, 134);
            Controls.Add(btnFshije);
            Controls.Add(btnRuaj);
            Controls.Add(txtEmriPershkrimit);
            Controls.Add(label2);
            Controls.Add(txtPershkrimi);
            Controls.Add(label3);
            Name = "CategoriesDetails";
            Size = new Size(598, 500);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmriPershkrimit;
        private Label label2;
        private TextBox txtPershkrimi;
        private Label label3;
        private Button btnRuaj;
        private Button btnFshije;
    }
}
