namespace Coffe_Shop.UserControls.SalesElement
{
    partial class SaleControl
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
            label1 = new Label();
            Body = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 65);
            panel1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(169, 37);
            label1.TabIndex = 19;
            label1.Text = "Lista e shitjeve";
            // 
            // Body
            // 
            Body.Dock = DockStyle.Fill;
            Body.Location = new Point(0, 65);
            Body.Name = "Body";
            Body.Size = new Size(804, 647);
            Body.TabIndex = 23;
            // 
            // SaleControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 43, 134);
            Controls.Add(Body);
            Controls.Add(panel1);
            Name = "SaleControl";
            Size = new Size(804, 712);
            Load += SaleControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel Body;
    }
}
