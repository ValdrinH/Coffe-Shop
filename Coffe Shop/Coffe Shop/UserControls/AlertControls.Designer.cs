namespace Coffe_Shop.UserControls
{
    partial class AlertControls
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
            label7 = new Label();
            lblTime = new Label();
            label2 = new Label();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(297, 417);
            label7.Name = "label7";
            label7.Size = new Size(166, 23);
            label7.TabIndex = 7;
            label7.Text = "Powered by: V-Software";
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.None;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Poppins", 36.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(266, 330);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(271, 87);
            lblTime.TabIndex = 6;
            lblTime.Text = "-- : -- : --";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 36.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(52, 227);
            label2.Name = "label2";
            label2.Size = new Size(728, 87);
            label2.TabIndex = 8;
            label2.Text = "Ju lutem kyquni në sistem !!!";
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // AlertControls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 43, 134);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(lblTime);
            Name = "AlertControls";
            Size = new Size(804, 712);
            Load += AlertControls_Load;
            SizeChanged += AlertControls_SizeChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label lblTime;
        private Label label2;
        private System.Windows.Forms.Timer timer;
    }
}
