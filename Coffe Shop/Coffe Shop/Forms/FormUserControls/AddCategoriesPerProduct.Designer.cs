namespace Coffe_Shop.Forms.FormUserControls
{
    partial class AddCategoriesPerProduct
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
            txtKerkimi = new TextBox();
            flowLayoutPanel = new FlowLayoutPanel();
            btnRuaj = new Button();
            SuspendLayout();
            // 
            // txtKerkimi
            // 
            txtKerkimi.BackColor = Color.FromArgb(69, 43, 134);
            txtKerkimi.BorderStyle = BorderStyle.None;
            txtKerkimi.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtKerkimi.ForeColor = Color.White;
            txtKerkimi.Location = new Point(104, 24);
            txtKerkimi.Name = "txtKerkimi";
            txtKerkimi.PlaceholderText = "Kërko...";
            txtKerkimi.Size = new Size(368, 32);
            txtKerkimi.TabIndex = 20;
            txtKerkimi.TextAlign = HorizontalAlignment.Center;
            txtKerkimi.TextChanged += txtKerkimi_TextChanged;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Location = new Point(3, 86);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(592, 346);
            flowLayoutPanel.TabIndex = 21;
            // 
            // btnRuaj
            // 
            btnRuaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRuaj.BackColor = Color.FromArgb(28, 209, 123);
            btnRuaj.FlatStyle = FlatStyle.Flat;
            btnRuaj.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRuaj.ForeColor = Color.White;
            btnRuaj.Location = new Point(451, 459);
            btnRuaj.Name = "btnRuaj";
            btnRuaj.Size = new Size(144, 38);
            btnRuaj.TabIndex = 46;
            btnRuaj.Tag = "";
            btnRuaj.Text = "Përfundo";
            btnRuaj.TextImageRelation = TextImageRelation.TextAboveImage;
            btnRuaj.UseVisualStyleBackColor = false;
            btnRuaj.Click += btnRuaj_Click;
            // 
            // AddCategoriesPerProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 43, 134);
            Controls.Add(btnRuaj);
            Controls.Add(flowLayoutPanel);
            Controls.Add(txtKerkimi);
            Name = "AddCategoriesPerProduct";
            Size = new Size(598, 500);
            Load += AddCategoriesPerProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKerkimi;
        private FlowLayoutPanel flowLayoutPanel;
        private Button btnRuaj;
    }
}
