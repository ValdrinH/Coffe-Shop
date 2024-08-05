namespace Coffe_Shop.UserControls.StockElements
{
    partial class StockList
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
            button20 = new Button();
            panel1 = new Panel();
            Body = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(289, 37);
            label1.TabIndex = 19;
            label1.Text = "Lista e produkteve në stok";
            // 
            // button20
            // 
            button20.Anchor = AnchorStyles.Right;
            button20.BackColor = Color.Green;
            button20.Cursor = Cursors.Hand;
            button20.FlatStyle = FlatStyle.Flat;
            button20.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button20.ForeColor = Color.White;
            button20.Location = new Point(639, 13);
            button20.Name = "button20";
            button20.Size = new Size(158, 33);
            button20.TabIndex = 20;
            button20.Tag = "1";
            button20.Text = "Shto produkte të reja";
            button20.TextImageRelation = TextImageRelation.TextAboveImage;
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button20);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 65);
            panel1.TabIndex = 21;
            // 
            // Body
            // 
            Body.Dock = DockStyle.Fill;
            Body.Location = new Point(0, 65);
            Body.Name = "Body";
            Body.Size = new Size(804, 647);
            Body.TabIndex = 22;
            // 
            // StockList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 43, 134);
            Controls.Add(Body);
            Controls.Add(panel1);
            Name = "StockList";
            Size = new Size(804, 712);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button20;
        private Panel panel1;
        private Panel Body;
    }
}
