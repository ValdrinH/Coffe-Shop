namespace Coffe_Shop.UserControls.Porosit
{
    partial class OrderComponent
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
            pictureBox1 = new PictureBox();
            lblOra = new Label();
            lblData = new Label();
            lblTable = new Label();
            lblWaiter = new Label();
            MeShumeDetaje = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_order_64;
            pictureBox1.Location = new Point(126, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblOra
            // 
            lblOra.AutoSize = true;
            lblOra.Font = new Font("Poppins", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblOra.Location = new Point(3, 5);
            lblOra.Name = "lblOra";
            lblOra.Size = new Size(114, 62);
            lblOra.TabIndex = 1;
            lblOra.Text = "20:13";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(119, 55);
            lblData.Name = "lblData";
            lblData.Size = new Size(73, 15);
            lblData.TabIndex = 2;
            lblData.Text = "07 Mar, 2024";
            // 
            // lblTable
            // 
            lblTable.AutoSize = true;
            lblTable.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTable.Location = new Point(3, 98);
            lblTable.Name = "lblTable";
            lblTable.Size = new Size(0, 28);
            lblTable.TabIndex = 3;
            // 
            // lblWaiter
            // 
            lblWaiter.AutoSize = true;
            lblWaiter.Font = new Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblWaiter.Location = new Point(4, 129);
            lblWaiter.Name = "lblWaiter";
            lblWaiter.Size = new Size(0, 26);
            lblWaiter.TabIndex = 4;
            // 
            // MeShumeDetaje
            // 
            MeShumeDetaje.BackColor = Color.OliveDrab;
            MeShumeDetaje.Cursor = Cursors.Hand;
            MeShumeDetaje.FlatStyle = FlatStyle.Flat;
            MeShumeDetaje.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MeShumeDetaje.ForeColor = SystemColors.ButtonHighlight;
            MeShumeDetaje.Location = new Point(40, 184);
            MeShumeDetaje.Name = "MeShumeDetaje";
            MeShumeDetaje.Size = new Size(111, 32);
            MeShumeDetaje.TabIndex = 5;
            MeShumeDetaje.Text = "Shiko Porosin";
            MeShumeDetaje.UseVisualStyleBackColor = false;
            MeShumeDetaje.Click += MeShumeDetaje_Click;
            // 
            // OrderComponent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(MeShumeDetaje);
            Controls.Add(lblWaiter);
            Controls.Add(lblTable);
            Controls.Add(lblData);
            Controls.Add(lblOra);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(193, 219);
            MinimumSize = new Size(193, 219);
            Name = "OrderComponent";
            Size = new Size(193, 219);
            Load += OrderComponent_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblOra;
        private Label lblData;
        private Label lblTable;
        private Label lblWaiter;
        private Button MeShumeDetaje;
    }
}
