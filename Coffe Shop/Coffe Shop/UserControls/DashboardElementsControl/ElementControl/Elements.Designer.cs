namespace Coffe_Shop.UserControls.DashboardElementsControl.ElementControl
{
    partial class Elements
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
            picElement = new PictureBox();
            tableLayoutPanel = new TableLayoutPanel();
            lblCost = new Label();
            lblTitle = new Label();
            pnlSelected = new Panel();
            ((System.ComponentModel.ISupportInitialize)picElement).BeginInit();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // picElement
            // 
            picElement.Anchor = AnchorStyles.Left;
            picElement.Cursor = Cursors.Hand;
            picElement.Location = new Point(17, 6);
            picElement.Name = "picElement";
            picElement.Size = new Size(147, 130);
            picElement.SizeMode = PictureBoxSizeMode.StretchImage;
            picElement.TabIndex = 0;
            picElement.TabStop = false;
            picElement.Click += ElementClick;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(lblCost, 0, 1);
            tableLayoutPanel.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel.Location = new Point(17, 142);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(147, 49);
            tableLayoutPanel.TabIndex = 1;
            tableLayoutPanel.Click += ElementClick;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Cursor = Cursors.Hand;
            lblCost.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCost.ForeColor = Color.FromArgb(148, 128, 203);
            lblCost.Location = new Point(3, 24);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(47, 22);
            lblCost.TabIndex = 8;
            lblCost.Tag = "5";
            lblCost.Text = "5.00€";
            lblCost.Click += ElementClick;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Cursor = Cursors.Hand;
            lblTitle.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(98, 24);
            lblTitle.TabIndex = 7;
            lblTitle.Tag = "5";
            lblTitle.Text = "Kafe Expresso xxxxxxx";
            lblTitle.Click += ElementClick;
            // 
            // pnlSelected
            // 
            pnlSelected.BackColor = Color.FromArgb(148, 128, 203);
            pnlSelected.Dock = DockStyle.Bottom;
            pnlSelected.Location = new Point(0, 199);
            pnlSelected.Name = "pnlSelected";
            pnlSelected.Size = new Size(181, 5);
            pnlSelected.TabIndex = 2;
            pnlSelected.Visible = false;
            // 
            // Elements
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(85, 59, 148);
            Controls.Add(pnlSelected);
            Controls.Add(tableLayoutPanel);
            Controls.Add(picElement);
            Cursor = Cursors.Hand;
            Name = "Elements";
            Size = new Size(181, 204);
            Load += Elements_Load;
            Click += ElementClick;
            ((System.ComponentModel.ISupportInitialize)picElement).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picElement;
        private TableLayoutPanel tableLayoutPanel;
        private Label lblCost;
        private Label lblTitle;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlSelected;
    }
}
