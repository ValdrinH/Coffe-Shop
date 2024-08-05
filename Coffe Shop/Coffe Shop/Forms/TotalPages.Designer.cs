namespace Coffe_Shop.Forms
{
    partial class TotalPages
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTotal = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtPagesa = new TextBox();
            label3 = new Label();
            txtBorgji = new Label();
            button20 = new Button();
            lblPuntori = new Label();
            lblOra = new Label();
            lblTable = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblDate = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTotal.BackColor = Color.Gainsboro;
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.ForeColor = Color.Black;
            txtTotal.Location = new Point(6, 62);
            txtTotal.MaximumSize = new Size(413, 24);
            txtTotal.Name = "txtTotal";
            txtTotal.PlaceholderText = "0.00";
            txtTotal.Size = new Size(308, 24);
            txtTotal.TabIndex = 24;
            txtTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(7, 27);
            label2.Name = "label2";
            label2.Size = new Size(140, 30);
            label2.TabIndex = 25;
            label2.Text = "Totali pagesës:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 25.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(93, 1);
            label1.Name = "label1";
            label1.Size = new Size(159, 62);
            label1.TabIndex = 26;
            label1.Text = "Pagesa";
            // 
            // txtPagesa
            // 
            txtPagesa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPagesa.BackColor = Color.Gainsboro;
            txtPagesa.BorderStyle = BorderStyle.None;
            txtPagesa.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPagesa.ForeColor = Color.Black;
            txtPagesa.Location = new Point(7, 126);
            txtPagesa.MaximumSize = new Size(413, 24);
            txtPagesa.Name = "txtPagesa";
            txtPagesa.PlaceholderText = "0.00";
            txtPagesa.Size = new Size(307, 24);
            txtPagesa.TabIndex = 27;
            txtPagesa.TextAlign = HorizontalAlignment.Center;
            txtPagesa.TextChanged += txtPagesa_TextChanged;
            txtPagesa.KeyPress += txtPagesa_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(5, 94);
            label3.Name = "label3";
            label3.Size = new Size(80, 30);
            label3.TabIndex = 28;
            label3.Text = "Pagesa:";
            // 
            // txtBorgji
            // 
            txtBorgji.AutoSize = true;
            txtBorgji.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBorgji.ForeColor = Color.Black;
            txtBorgji.Location = new Point(7, 163);
            txtBorgji.Name = "txtBorgji";
            txtBorgji.Size = new Size(105, 30);
            txtBorgji.TabIndex = 30;
            txtBorgji.Text = "Borgji: 0.00";
            // 
            // button20
            // 
            button20.BackColor = Color.Green;
            button20.Dock = DockStyle.Bottom;
            button20.FlatStyle = FlatStyle.Flat;
            button20.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button20.ForeColor = Color.White;
            button20.Location = new Point(0, 448);
            button20.Name = "button20";
            button20.Size = new Size(344, 39);
            button20.TabIndex = 31;
            button20.Tag = "1";
            button20.Text = "Paguaj";
            button20.TextImageRelation = TextImageRelation.TextAboveImage;
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            // 
            // lblPuntori
            // 
            lblPuntori.AutoSize = true;
            lblPuntori.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPuntori.ForeColor = Color.Black;
            lblPuntori.Location = new Point(5, 31);
            lblPuntori.Name = "lblPuntori";
            lblPuntori.Size = new Size(162, 30);
            lblPuntori.TabIndex = 32;
            lblPuntori.Text = "Puntori: ---------";
            // 
            // lblOra
            // 
            lblOra.AutoSize = true;
            lblOra.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblOra.ForeColor = Color.Black;
            lblOra.Location = new Point(6, 74);
            lblOra.Name = "lblOra";
            lblOra.Size = new Size(87, 30);
            lblOra.TabIndex = 33;
            lblOra.Text = "Ora: 11:52";
            // 
            // lblTable
            // 
            lblTable.AutoSize = true;
            lblTable.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTable.ForeColor = Color.Black;
            lblTable.Location = new Point(88, 0);
            lblTable.Name = "lblTable";
            lblTable.Size = new Size(124, 30);
            lblTable.TabIndex = 34;
            lblTable.Text = "sadfasfadsdf";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblTable);
            flowLayoutPanel1.Location = new Point(99, 74);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel1.Size = new Size(215, 32);
            flowLayoutPanel1.TabIndex = 35;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Poppins", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(117, 55);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(112, 30);
            lblDate.TabIndex = 36;
            lblDate.Text = "12 Dec 2023";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPagesa);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtBorgji);
            groupBox1.Location = new Point(11, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 213);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detajet e pageses";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblOra);
            groupBox2.Controls.Add(lblPuntori);
            groupBox2.Controls.Add(flowLayoutPanel1);
            groupBox2.Location = new Point(11, 309);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(320, 126);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detajet e tjera";
            // 
            // TotalPages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(344, 487);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblDate);
            Controls.Add(button20);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TotalPages";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += TotalPages_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Label label2;
        private Label label1;
        private TextBox txtPagesa;
        private Label label3;
        private Label txtBorgji;
        private Button button20;
        private Label lblPuntori;
        private Label lblOra;
        private Label lblTable;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblDate;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}