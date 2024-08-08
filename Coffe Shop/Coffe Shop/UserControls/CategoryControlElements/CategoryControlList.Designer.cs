namespace Coffe_Shop.UserControls.CategoryControlElements
{
    partial class CategoryControlList
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
            button20 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            body = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button20
            // 
            button20.Anchor = AnchorStyles.Right;
            button20.BackColor = Color.Green;
            button20.FlatStyle = FlatStyle.Flat;
            button20.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button20.ForeColor = Color.White;
            button20.Location = new Point(663, 13);
            button20.Name = "button20";
            button20.Size = new Size(120, 33);
            button20.TabIndex = 15;
            button20.Tag = "1";
            button20.Text = "Shto kategori";
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
            panel1.Size = new Size(804, 59);
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(200, 37);
            label1.TabIndex = 17;
            label1.Text = "Lista e kategorive";
            // 
            // body
            // 
            body.Dock = DockStyle.Fill;
            body.Location = new Point(0, 59);
            body.Name = "body";
            body.Size = new Size(804, 653);
            body.TabIndex = 17;
            // 
            // CategoryControlList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 43, 134);
            Controls.Add(body);
            Controls.Add(panel1);
            Name = "CategoryControlList";
            Size = new Size(804, 712);
            Load += CategoryControlList_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button20;
        private Panel panel1;
        private Label label1;
        private Panel body;
    }
}
