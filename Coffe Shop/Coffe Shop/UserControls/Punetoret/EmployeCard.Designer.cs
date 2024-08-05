namespace Coffe_Shop.UserControls.Punetoret
{
    partial class EmployeCard
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel = new TableLayoutPanel();
            lblNumri = new Label();
            lblRoli = new Label();
            lblTitle = new Label();
            picElement = new PictureBox();
            toolTip1 = new ToolTip(components);
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picElement).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(lblNumri, 0, 2);
            tableLayoutPanel.Controls.Add(lblRoli, 0, 1);
            tableLayoutPanel.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel.Cursor = Cursors.Hand;
            tableLayoutPanel.Location = new Point(3, 166);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.Size = new Size(188, 76);
            tableLayoutPanel.TabIndex = 3;
            tableLayoutPanel.Click += EmployeCard_Click;
            // 
            // lblNumri
            // 
            lblNumri.AutoSize = true;
            lblNumri.BackColor = Color.Transparent;
            lblNumri.Cursor = Cursors.Hand;
            lblNumri.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumri.ForeColor = Color.Black;
            lblNumri.Location = new Point(3, 50);
            lblNumri.Name = "lblNumri";
            lblNumri.Size = new Size(94, 22);
            lblNumri.TabIndex = 9;
            lblNumri.Tag = "5";
            lblNumri.Text = "Nr: 123456789";
            lblNumri.Click += EmployeCard_Click;
            // 
            // lblRoli
            // 
            lblRoli.AutoSize = true;
            lblRoli.BackColor = Color.Transparent;
            lblRoli.Cursor = Cursors.Hand;
            lblRoli.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoli.ForeColor = Color.Black;
            lblRoli.Location = new Point(3, 25);
            lblRoli.Name = "lblRoli";
            lblRoli.Size = new Size(48, 22);
            lblRoli.TabIndex = 8;
            lblRoli.Tag = "5";
            lblRoli.Text = "R: Roli";
            lblRoli.Click += EmployeCard_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Cursor = Cursors.Hand;
            lblTitle.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(85, 22);
            lblTitle.TabIndex = 7;
            lblTitle.Tag = "5";
            lblTitle.Text = "EM: Punëtori";
            lblTitle.Click += EmployeCard_Click;
            // 
            // picElement
            // 
            picElement.Anchor = AnchorStyles.Left;
            picElement.Cursor = Cursors.Hand;
            picElement.Location = new Point(17, 9);
            picElement.Name = "picElement";
            picElement.Size = new Size(163, 145);
            picElement.SizeMode = PictureBoxSizeMode.StretchImage;
            picElement.TabIndex = 2;
            picElement.TabStop = false;
            picElement.Click += EmployeCard_Click;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // EmployeCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(tableLayoutPanel);
            Controls.Add(picElement);
            Name = "EmployeCard";
            Size = new Size(194, 245);
            Load += EmployeCard_Load;
            Click += EmployeCard_Click;
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picElement).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Label lblTitle;
        private PictureBox picElement;
        private Label lblNumri;
        private Label lblRoli;
        private ToolTip toolTip1;
    }
}
