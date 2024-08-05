namespace Coffe_Shop.UserControls.Porosit
{
    partial class ListofOrders
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
            panel1 = new Panel();
            label1 = new Label();
            button20 = new Button();
            BodyComponent = new FlowLayoutPanel();
            panel2 = new Panel();
            txtSearch = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblInvoice = new Label();
            lblTotal = new Label();
            pnlMessage = new Panel();
            lblMessage = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlMessage.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button20);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 65);
            panel1.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(178, 37);
            label1.TabIndex = 19;
            label1.Text = "Lista e porosive";
            // 
            // button20
            // 
            button20.Anchor = AnchorStyles.Right;
            button20.BackColor = Color.FromArgb(28, 209, 123);
            button20.Cursor = Cursors.Hand;
            button20.FlatStyle = FlatStyle.Flat;
            button20.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button20.ForeColor = Color.White;
            button20.Location = new Point(1243, -5);
            button20.Name = "button20";
            button20.Size = new Size(158, 33);
            button20.TabIndex = 20;
            button20.Tag = "1";
            button20.Text = "Shto produkte të reja";
            button20.TextImageRelation = TextImageRelation.TextAboveImage;
            button20.UseVisualStyleBackColor = false;
            // 
            // BodyComponent
            // 
            BodyComponent.AutoScroll = true;
            BodyComponent.Dock = DockStyle.Fill;
            BodyComponent.Location = new Point(0, 151);
            BodyComponent.Margin = new Padding(3, 3, 6, 3);
            BodyComponent.Name = "BodyComponent";
            BodyComponent.Padding = new Padding(7, 4, 7, 0);
            BodyComponent.Size = new Size(804, 561);
            BodyComponent.TabIndex = 24;
            BodyComponent.ControlAdded += BodyComponent_ControlAdded;
            BodyComponent.ControlRemoved += BodyComponent_ControlRemoved;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(804, 38);
            panel2.TabIndex = 25;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(69, 43, 134);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Dock = DockStyle.Top;
            txtSearch.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(0, 0);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Kërko porosin";
            txtSearch.Size = new Size(539, 32);
            txtSearch.TabIndex = 3;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblInvoice);
            flowLayoutPanel1.Controls.Add(lblTotal);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(539, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(265, 38);
            flowLayoutPanel1.TabIndex = 32;
            // 
            // lblInvoice
            // 
            lblInvoice.AutoSize = true;
            lblInvoice.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInvoice.ForeColor = Color.IndianRed;
            lblInvoice.Location = new Point(262, 0);
            lblInvoice.Name = "lblInvoice";
            lblInvoice.Size = new Size(0, 37);
            lblInvoice.TabIndex = 31;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(140, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(116, 26);
            lblTotal.TabIndex = 20;
            lblTotal.Text = "Total Porosi: 0";
            // 
            // pnlMessage
            // 
            pnlMessage.BackColor = Color.Cyan;
            pnlMessage.Controls.Add(lblMessage);
            pnlMessage.Dock = DockStyle.Top;
            pnlMessage.Location = new Point(0, 103);
            pnlMessage.Name = "pnlMessage";
            pnlMessage.Size = new Size(804, 48);
            pnlMessage.TabIndex = 0;
            pnlMessage.Visible = false;
            // 
            // lblMessage
            // 
            lblMessage.Anchor = AnchorStyles.None;
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessage.ForeColor = Color.IndianRed;
            lblMessage.Location = new Point(226, 9);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(334, 34);
            lblMessage.TabIndex = 21;
            lblMessage.Text = "Nuk u gjet asnjë porosi në sistem!";
            // 
            // ListofOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 43, 134);
            Controls.Add(BodyComponent);
            Controls.Add(pnlMessage);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ListofOrders";
            Size = new Size(804, 712);
            Load += ListofOrders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            pnlMessage.ResumeLayout(false);
            pnlMessage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Button button20;
        private FlowLayoutPanel BodyComponent;
        private Panel panel2;
        private Label lblTotal;
        private TextBox txtSearch;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblInvoice;
        private Panel pnlMessage;
        private Label lblMessage;
    }
}
