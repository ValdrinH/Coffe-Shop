namespace Coffe_Shop.UserControls.Porosit
{
    partial class OrdersDetails
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            picBack = new PictureBox();
            lblTitle = new Label();
            lblTotal = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblInvoice = new Label();
            label2 = new Label();
            label3 = new Label();
            lblDate = new Label();
            lblOra = new Label();
            label6 = new Label();
            lblName = new Label();
            label7 = new Label();
            btnFshije = new Button();
            btnRuaj = new Button();
            dataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Order = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btnLargo = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)picBack).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // picBack
            // 
            picBack.Cursor = Cursors.Hand;
            picBack.Image = Properties.Resources.icons8_back_35;
            picBack.Location = new Point(12, 22);
            picBack.Name = "picBack";
            picBack.Size = new Size(35, 35);
            picBack.SizeMode = PictureBoxSizeMode.AutoSize;
            picBack.TabIndex = 29;
            picBack.TabStop = false;
            picBack.Click += picBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(53, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(219, 37);
            lblTitle.TabIndex = 28;
            lblTitle.Text = "Porosia në '#Table1'";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Poppins", 35.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.SeaGreen;
            lblTotal.Location = new Point(197, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(174, 84);
            lblTotal.TabIndex = 30;
            lblTotal.Text = "0.00€";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(lblTotal);
            flowLayoutPanel1.Controls.Add(lblInvoice);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(427, 22);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(374, 146);
            flowLayoutPanel1.TabIndex = 31;
            // 
            // lblInvoice
            // 
            lblInvoice.AutoSize = true;
            lblInvoice.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInvoice.ForeColor = Color.IndianRed;
            lblInvoice.Location = new Point(191, 0);
            lblInvoice.Name = "lblInvoice";
            lblInvoice.Size = new Size(0, 37);
            lblInvoice.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 138);
            label2.Name = "label2";
            label2.Size = new Size(124, 30);
            label2.TabIndex = 33;
            label2.Text = "Emri Puntorit:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(11, 215);
            label3.Name = "label3";
            label3.Size = new Size(138, 30);
            label3.TabIndex = 35;
            label3.Text = "Data e Porosis:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(12, 252);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(101, 30);
            lblDate.TabIndex = 36;
            lblDate.Text = "Jan 1 2024";
            // 
            // lblOra
            // 
            lblOra.AutoSize = true;
            lblOra.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblOra.ForeColor = Color.White;
            lblOra.Location = new Point(190, 252);
            lblOra.Name = "lblOra";
            lblOra.Size = new Size(47, 30);
            lblOra.TabIndex = 38;
            lblOra.Text = "19:17";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(189, 215);
            label6.Name = "label6";
            label6.Size = new Size(128, 30);
            label6.TabIndex = 37;
            label6.Text = "Ora e Porosis:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(12, 172);
            lblName.Name = "lblName";
            lblName.Size = new Size(117, 30);
            lblName.TabIndex = 39;
            lblName.Text = "------ -----";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(11, 305);
            label7.Name = "label7";
            label7.Size = new Size(171, 30);
            label7.TabIndex = 41;
            label7.Text = "Lista e Produkteve:";
            // 
            // btnFshije
            // 
            btnFshije.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFshije.BackColor = Color.FromArgb(192, 0, 0);
            btnFshije.Cursor = Cursors.Hand;
            btnFshije.FlatStyle = FlatStyle.Flat;
            btnFshije.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFshije.ForeColor = Color.White;
            btnFshije.Location = new Point(661, 656);
            btnFshije.Name = "btnFshije";
            btnFshije.Size = new Size(128, 40);
            btnFshije.TabIndex = 42;
            btnFshije.Tag = "1";
            btnFshije.Text = "Fshije Porosin";
            btnFshije.TextImageRelation = TextImageRelation.TextAboveImage;
            btnFshije.UseVisualStyleBackColor = false;
            btnFshije.Click += btnFshije_Click;
            // 
            // btnRuaj
            // 
            btnRuaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRuaj.BackColor = Color.FromArgb(0, 64, 0);
            btnRuaj.Cursor = Cursors.Hand;
            btnRuaj.FlatStyle = FlatStyle.Flat;
            btnRuaj.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRuaj.ForeColor = Color.White;
            btnRuaj.Location = new Point(539, 656);
            btnRuaj.Name = "btnRuaj";
            btnRuaj.Size = new Size(116, 40);
            btnRuaj.TabIndex = 43;
            btnRuaj.Tag = "1";
            btnRuaj.Text = "Merr Porosin";
            btnRuaj.TextImageRelation = TextImageRelation.TextAboveImage;
            btnRuaj.UseVisualStyleBackColor = false;
            btnRuaj.Click += btnRuaj_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(148, 128, 203);
            dataGridViewCellStyle7.Font = new Font("Poppins", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(148, 128, 203);
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.FromArgb(69, 43, 134);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(69, 43, 134);
            dataGridViewCellStyle8.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(69, 43, 134);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Order, Quantity, Price, Total, btnLargo });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(69, 43, 134);
            dataGridViewCellStyle10.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(69, 43, 134);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridView.GridColor = Color.FromArgb(69, 43, 134);
            dataGridView.Location = new Point(12, 338);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(69, 43, 134);
            dataGridViewCellStyle11.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(69, 43, 134);
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(69, 43, 134);
            dataGridViewCellStyle12.Font = new Font("Poppins", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(69, 43, 134);
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(786, 293);
            dataGridView.TabIndex = 44;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Num";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // Order
            // 
            Order.HeaderText = "Produkti";
            Order.Name = "Order";
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Quantity.HeaderText = "Sasia";
            Quantity.Name = "Quantity";
            Quantity.Width = 80;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Price.HeaderText = "Cmimi";
            Price.Name = "Price";
            Price.Width = 80;
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.Width = 80;
            // 
            // btnLargo
            // 
            btnLargo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle9.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.Red;
            btnLargo.DefaultCellStyle = dataGridViewCellStyle9;
            btnLargo.FlatStyle = FlatStyle.System;
            btnLargo.HeaderText = "Largo";
            btnLargo.Name = "btnLargo";
            btnLargo.Text = "Del";
            btnLargo.ToolTipText = "Del";
            btnLargo.UseColumnTextForButtonValue = true;
            btnLargo.Width = 80;
            // 
            // OrdersDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 43, 134);
            Controls.Add(dataGridView);
            Controls.Add(btnFshije);
            Controls.Add(btnRuaj);
            Controls.Add(label7);
            Controls.Add(lblName);
            Controls.Add(lblOra);
            Controls.Add(label6);
            Controls.Add(lblDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(picBack);
            Controls.Add(lblTitle);
            Name = "OrdersDetails";
            Size = new Size(804, 712);
            ((System.ComponentModel.ISupportInitialize)picBack).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBack;
        private Label lblTitle;
        private Label lblTotal;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label lblDate;
        private Label lblOra;
        private Label label6;
        private Label lblName;
        private Label label7;
        private Button btnFshije;
        private Button btnRuaj;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Order;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewButtonColumn btnLargo;
        private Label lblInvoice;
    }
}
