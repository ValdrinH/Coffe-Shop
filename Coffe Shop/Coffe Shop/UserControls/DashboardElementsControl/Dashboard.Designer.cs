namespace Coffe_Shop.UserControls.DashboardElementsControl
{
    partial class Dashboard
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
            txtTextCalculator = new TextBox();
            flowLayoutPanel = new FlowLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            cbNjesia = new ComboBox();
            label11 = new Label();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
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
            txtTextCalculator.Size = new Size(804, 32);
            txtTextCalculator.TabIndex = 2;
            txtTextCalculator.TextAlign = HorizontalAlignment.Center;
            txtTextCalculator.TextChanged += txtTextCalculator_TextChanged;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new Point(0, 32);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Padding = new Padding(15, 14, 0, 0);
            flowLayoutPanel.Size = new Size(804, 680);
            flowLayoutPanel.TabIndex = 3;
            flowLayoutPanel.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.9170036F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.9047623F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.1904755F));
            tableLayoutPanel2.Controls.Add(cbNjesia, 2, 1);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // cbNjesia
            // 
            cbNjesia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbNjesia.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbNjesia.FormattingEnabled = true;
            cbNjesia.Items.AddRange(new object[] { "Copa", "Kg", "Litra" });
            cbNjesia.Location = new Point(145, 23);
            cbNjesia.Name = "cbNjesia";
            cbNjesia.Size = new Size(52, 30);
            cbNjesia.TabIndex = 47;
            cbNjesia.Text = "Copa";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(145, 0);
            label11.Name = "label11";
            label11.Size = new Size(49, 60);
            label11.TabIndex = 47;
            label11.Text = "Njësia:";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 43, 134);
            Controls.Add(flowLayoutPanel);
            Controls.Add(txtTextCalculator);
            Name = "Dashboard";
            Size = new Size(804, 712);
            Load += Dashboard_Load;
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTextCalculator;
        public FlowLayoutPanel flowLayoutPanel;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox cbNjesia;
        private Label label11;
    }
}
