namespace Coffe_Shop.UserControls.Punetoret
{
    partial class ListofEmployees
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
            pnlMessage = new Panel();
            lblMessage = new Label();
            txtSearch = new TextBox();
            panel1 = new Panel();
            btnAddNewEmployees = new Button();
            label1 = new Label();
            button20 = new Button();
            bodyElement = new FlowLayoutPanel();
            pnlMessage.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMessage
            // 
            pnlMessage.BackColor = Color.Cyan;
            pnlMessage.Controls.Add(lblMessage);
            pnlMessage.Dock = DockStyle.Top;
            pnlMessage.Location = new Point(0, 97);
            pnlMessage.Name = "pnlMessage";
            pnlMessage.Size = new Size(804, 48);
            pnlMessage.TabIndex = 25;
            pnlMessage.Visible = false;
            // 
            // lblMessage
            // 
            lblMessage.Anchor = AnchorStyles.None;
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessage.ForeColor = Color.IndianRed;
            lblMessage.Location = new Point(209, 9);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(338, 34);
            lblMessage.TabIndex = 21;
            lblMessage.Text = "Nuk u gjet asnjë puntor në sistem!";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(69, 43, 134);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Dock = DockStyle.Top;
            txtSearch.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(0, 65);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Kërko porosin";
            txtSearch.Size = new Size(804, 32);
            txtSearch.TabIndex = 26;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddNewEmployees);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button20);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 65);
            panel1.TabIndex = 27;
            // 
            // btnAddNewEmployees
            // 
            btnAddNewEmployees.Anchor = AnchorStyles.Right;
            btnAddNewEmployees.BackColor = Color.Green;
            btnAddNewEmployees.Cursor = Cursors.Hand;
            btnAddNewEmployees.FlatStyle = FlatStyle.Flat;
            btnAddNewEmployees.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddNewEmployees.ForeColor = Color.White;
            btnAddNewEmployees.Location = new Point(634, 17);
            btnAddNewEmployees.Name = "btnAddNewEmployees";
            btnAddNewEmployees.Size = new Size(158, 33);
            btnAddNewEmployees.TabIndex = 21;
            btnAddNewEmployees.Tag = "1";
            btnAddNewEmployees.Text = "Shto puntor të rinjë";
            btnAddNewEmployees.TextImageRelation = TextImageRelation.TextAboveImage;
            btnAddNewEmployees.UseVisualStyleBackColor = false;
            btnAddNewEmployees.Click += btnAddNewEmployees_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(209, 37);
            label1.TabIndex = 19;
            label1.Text = "Lista e punëtorëve";
            // 
            // button20
            // 
            button20.Anchor = AnchorStyles.Right;
            button20.BackColor = Color.FromArgb(28, 209, 123);
            button20.Cursor = Cursors.Hand;
            button20.FlatStyle = FlatStyle.Flat;
            button20.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button20.ForeColor = Color.White;
            button20.Location = new Point(1847, -23);
            button20.Name = "button20";
            button20.Size = new Size(158, 33);
            button20.TabIndex = 20;
            button20.Tag = "1";
            button20.Text = "Shto produkte të reja";
            button20.TextImageRelation = TextImageRelation.TextAboveImage;
            button20.UseVisualStyleBackColor = false;
            // 
            // bodyElement
            // 
            bodyElement.AutoScroll = true;
            bodyElement.Dock = DockStyle.Fill;
            bodyElement.Location = new Point(0, 145);
            bodyElement.Name = "bodyElement";
            bodyElement.Padding = new Padding(6, 5, 0, 0);
            bodyElement.Size = new Size(804, 567);
            bodyElement.TabIndex = 28;
            // 
            // ListofEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 43, 134);
            Controls.Add(bodyElement);
            Controls.Add(pnlMessage);
            Controls.Add(txtSearch);
            Controls.Add(panel1);
            Name = "ListofEmployees";
            Size = new Size(804, 712);
            Load += ListofEmployees_Load;
            pnlMessage.ResumeLayout(false);
            pnlMessage.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMessage;
        private Label lblMessage;
        private TextBox txtSearch;
        private Panel panel1;
        private Label label1;
        private Button button20;
        private FlowLayoutPanel bodyElement;
        private Button btnAddNewEmployees;
    }
}
