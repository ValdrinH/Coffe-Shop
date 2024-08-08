namespace Coffe_Shop.UserControls.DashboardElementsControl
{
    partial class ExpiredProducts
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
            txtTextCalculator = new TextBox();
            Body = new FlowLayoutPanel();
            panel2 = new Panel();
            btnUpdate = new Button();
            lblWarnging = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTextCalculator);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 40);
            panel1.TabIndex = 0;
            // 
            // txtTextCalculator
            // 
            txtTextCalculator.BackColor = Color.FromArgb(69, 43, 134);
            txtTextCalculator.BorderStyle = BorderStyle.None;
            txtTextCalculator.Dock = DockStyle.Top;
            txtTextCalculator.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtTextCalculator.ForeColor = Color.White;
            txtTextCalculator.Location = new Point(0, 0);
            txtTextCalculator.Name = "txtTextCalculator";
            txtTextCalculator.PlaceholderText = "Kërko produktin...";
            txtTextCalculator.Size = new Size(598, 32);
            txtTextCalculator.TabIndex = 3;
            txtTextCalculator.TextAlign = HorizontalAlignment.Center;
            txtTextCalculator.TextChanged += txtTextCalculator_TextChanged;
            // 
            // Body
            // 
            Body.Dock = DockStyle.Fill;
            Body.Location = new Point(0, 40);
            Body.Name = "Body";
            Body.Size = new Size(598, 413);
            Body.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblWarnging);
            panel2.Controls.Add(btnUpdate);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 453);
            panel2.Name = "panel2";
            panel2.Size = new Size(598, 47);
            panel2.TabIndex = 2;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Poppins", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(432, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(163, 41);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Ruaj Ndryshimet";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblWarnging
            // 
            lblWarnging.AutoSize = true;
            lblWarnging.ForeColor = Color.Yellow;
            lblWarnging.Location = new Point(3, 10);
            lblWarnging.Name = "lblWarnging";
            lblWarnging.Size = new Size(244, 30);
            lblWarnging.TabIndex = 7;
            lblWarnging.Text = "Siguro që të gjitha datat të jenë më të më se :\r\nNdryshe nuk do të ruhen të dhënat";
            // 
            // ExpiredProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 43, 134);
            Controls.Add(Body);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ExpiredProducts";
            Size = new Size(598, 500);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel Body;
        private Panel panel2;
        private TextBox txtTextCalculator;
        private Button btnUpdate;
        private Label lblWarnging;
    }
}
