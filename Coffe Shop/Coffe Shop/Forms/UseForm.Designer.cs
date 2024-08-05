namespace Coffe_Shop.Forms
{
    partial class UseForm
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
            TopPanel = new Panel();
            lblTitle = new Label();
            Body = new Panel();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.Controls.Add(lblTitle);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(598, 49);
            TopPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(181, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(236, 37);
            lblTitle.TabIndex = 27;
            lblTitle.Text = "Shto produkte të reja\r\n";
            // 
            // Body
            // 
            Body.Dock = DockStyle.Fill;
            Body.Location = new Point(0, 49);
            Body.Name = "Body";
            Body.Size = new Size(598, 500);
            Body.TabIndex = 1;
            // 
            // UseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 43, 134);
            ClientSize = new Size(598, 549);
            Controls.Add(Body);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UseForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            FormClosing += UseForm_FormClosing;
            Load += UseForm_Load;
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Panel Body;
        private Label lblTitle;
    }
}