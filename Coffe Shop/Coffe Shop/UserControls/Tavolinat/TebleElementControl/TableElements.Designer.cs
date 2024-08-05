namespace Coffe_Shop.UserControls.Tavolinat
{
    partial class TableElements
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
            btnFshije = new Button();
            btnRuajes = new Button();
            Selected = new PictureBox();
            txtName = new TextBox();
            picInUse = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picElement).BeginInit();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Selected).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInUse).BeginInit();
            SuspendLayout();
            // 
            // picElement
            // 
            picElement.Cursor = Cursors.Hand;
            picElement.Image = Properties.Resources.icons8_restaurant_table_100;
            picElement.Location = new Point(41, 10);
            picElement.Name = "picElement";
            picElement.Size = new Size(100, 100);
            picElement.SizeMode = PictureBoxSizeMode.AutoSize;
            picElement.TabIndex = 8;
            picElement.TabStop = false;
            picElement.Click += SelektoTabelen;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(lblCost, 0, 1);
            tableLayoutPanel.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel.Cursor = Cursors.Hand;
            tableLayoutPanel.Location = new Point(21, 117);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(147, 49);
            tableLayoutPanel.TabIndex = 9;
            tableLayoutPanel.Click += SelektoTabelen;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Cursor = Cursors.Hand;
            lblCost.Font = new Font("Poppins", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblCost.ForeColor = Color.GreenYellow;
            lblCost.Location = new Point(3, 24);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(70, 25);
            lblCost.TabIndex = 8;
            lblCost.Tag = "5";
            lblCost.Text = "E Hapur";
            lblCost.Click += SelektoTabelen;
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
            lblTitle.Click += SelektoTabelen;
            // 
            // btnFshije
            // 
            btnFshije.Anchor = AnchorStyles.None;
            btnFshije.BackColor = Color.FromArgb(192, 0, 0);
            btnFshije.Cursor = Cursors.Hand;
            btnFshije.FlatStyle = FlatStyle.Flat;
            btnFshije.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFshije.ForeColor = Color.White;
            btnFshije.Location = new Point(24, 172);
            btnFshije.Name = "btnFshije";
            btnFshije.Size = new Size(67, 30);
            btnFshije.TabIndex = 48;
            btnFshije.Tag = "";
            btnFshije.Text = "Fshij";
            btnFshije.TextImageRelation = TextImageRelation.TextAboveImage;
            btnFshije.UseVisualStyleBackColor = false;
            btnFshije.Visible = false;
            btnFshije.Click += btnFshije_Click;
            // 
            // btnRuajes
            // 
            btnRuajes.Anchor = AnchorStyles.None;
            btnRuajes.BackColor = Color.FromArgb(28, 209, 123);
            btnRuajes.Cursor = Cursors.Hand;
            btnRuajes.FlatStyle = FlatStyle.Flat;
            btnRuajes.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRuajes.ForeColor = Color.White;
            btnRuajes.Location = new Point(97, 172);
            btnRuajes.Name = "btnRuajes";
            btnRuajes.Size = new Size(71, 30);
            btnRuajes.TabIndex = 49;
            btnRuajes.Tag = "";
            btnRuajes.Text = "Ruaj";
            btnRuajes.TextImageRelation = TextImageRelation.TextAboveImage;
            btnRuajes.UseVisualStyleBackColor = false;
            btnRuajes.Visible = false;
            btnRuajes.Click += btnRuajes_Click;
            // 
            // Selected
            // 
            Selected.Cursor = Cursors.Hand;
            Selected.Image = Properties.Resources.icons8_bookmark_30;
            Selected.Location = new Point(157, 3);
            Selected.Name = "Selected";
            Selected.Size = new Size(30, 30);
            Selected.SizeMode = PictureBoxSizeMode.AutoSize;
            Selected.TabIndex = 50;
            Selected.TabStop = false;
            Selected.Tag = "flag";
            Selected.Visible = false;
            Selected.Click += RemoveTableFromSelected;
            // 
            // txtName
            // 
            txtName.Location = new Point(21, 118);
            txtName.Name = "txtName";
            txtName.Size = new Size(147, 23);
            txtName.TabIndex = 51;
            txtName.Visible = false;
            // 
            // picInUse
            // 
            picInUse.Cursor = Cursors.Hand;
            picInUse.Image = Properties.Resources.icons8_time_30;
            picInUse.Location = new Point(5, 3);
            picInUse.Name = "picInUse";
            picInUse.Size = new Size(30, 30);
            picInUse.SizeMode = PictureBoxSizeMode.AutoSize;
            picInUse.TabIndex = 52;
            picInUse.TabStop = false;
            picInUse.Tag = "flag";
            picInUse.Visible = false;
            // 
            // TableElements
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(85, 59, 148);
            Controls.Add(picInUse);
            Controls.Add(txtName);
            Controls.Add(Selected);
            Controls.Add(btnRuajes);
            Controls.Add(btnFshije);
            Controls.Add(tableLayoutPanel);
            Controls.Add(picElement);
            Name = "TableElements";
            Size = new Size(189, 205);
            Load += TableElements_Load;
            Click += SelektoTabelen;
            ((System.ComponentModel.ISupportInitialize)picElement).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Selected).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInUse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picElement;
        private TableLayoutPanel tableLayoutPanel;
        private Label lblTitle;
        private Button btnFshije;
        private Button btnRuajes;
        private Label lblCost;
        private PictureBox Selected;
        private TextBox txtName;
        private PictureBox picInUse;
    }
}
