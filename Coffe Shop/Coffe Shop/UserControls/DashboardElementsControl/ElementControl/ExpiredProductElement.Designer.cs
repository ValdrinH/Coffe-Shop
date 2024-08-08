namespace Coffe_Shop.UserControls.DashboardElementsControl.ElementControl
{
    partial class ExpiredProductElement
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
            tableLayoutPanel = new TableLayoutPanel();
            lblDataeSkadimit = new Label();
            lblTitle = new Label();
            dateTimePicker = new DateTimePicker();
            label2 = new Label();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(lblDataeSkadimit, 0, 1);
            tableLayoutPanel.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel.Location = new Point(0, 3);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.Size = new Size(195, 83);
            tableLayoutPanel.TabIndex = 2;
            // 
            // lblDataeSkadimit
            // 
            lblDataeSkadimit.AutoSize = true;
            lblDataeSkadimit.Cursor = Cursors.Hand;
            lblDataeSkadimit.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDataeSkadimit.ForeColor = Color.White;
            lblDataeSkadimit.Location = new Point(3, 61);
            lblDataeSkadimit.Name = "lblDataeSkadimit";
            lblDataeSkadimit.Size = new Size(112, 22);
            lblDataeSkadimit.TabIndex = 8;
            lblDataeSkadimit.Tag = "5";
            lblDataeSkadimit.Text = "Data e Skadimit:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Cursor = Cursors.Hand;
            lblTitle.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(105, 22);
            lblTitle.TabIndex = 7;
            lblTitle.Tag = "5";
            lblTitle.Text = "Emri i Produktit";
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "dd/MMMMM/yyyy";
            dateTimePicker.Location = new Point(3, 123);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(192, 23);
            dateTimePicker.TabIndex = 3;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 98);
            label2.Name = "label2";
            label2.Size = new Size(106, 22);
            label2.TabIndex = 9;
            label2.Tag = "5";
            label2.Text = "Ndrysho Datën:";
            // 
            // ExpiredProductElement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(85, 59, 148);
            Controls.Add(label2);
            Controls.Add(dateTimePicker);
            Controls.Add(tableLayoutPanel);
            Name = "ExpiredProductElement";
            Size = new Size(198, 150);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Label lblDataeSkadimit;
        private Label lblTitle;
        private DateTimePicker dateTimePicker;
        private Label label2;
    }
}
