namespace Coffe_Shop.Forms
{
    partial class FiltringFormsTool
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
            label1 = new Label();
            txtName = new TextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            cbGValues = new ComboBox();
            label2 = new Label();
            cbGroup = new ComboBox();
            btnktheu = new Button();
            groupBox2 = new GroupBox();
            dateTimePicker3 = new DateTimePicker();
            label10 = new Label();
            label4 = new Label();
            cbUnit = new ComboBox();
            label5 = new Label();
            comboDate = new ComboBox();
            groupBox3 = new GroupBox();
            cb2date = new ComboBox();
            dtEnd = new DateTimePicker();
            dtStart = new DateTimePicker();
            btnCheckBetweenTwoDates = new Button();
            label8 = new Label();
            label9 = new Label();
            cb2Date1 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Kërko:";
            // 
            // txtName
            // 
            txtName.Location = new Point(60, 22);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Kërko...";
            txtName.Size = new Size(380, 23);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbGValues);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbGroup);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 116);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtro sipas të dhënave";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(64, 70);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "Vlera:";
            // 
            // cbGValues
            // 
            cbGValues.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbGValues.FormattingEnabled = true;
            cbGValues.Location = new Point(105, 67);
            cbGValues.Name = "cbGValues";
            cbGValues.Size = new Size(228, 23);
            cbGValues.TabIndex = 2;
            cbGValues.Text = "----";
            cbGValues.TextChanged += cbGValues_TextChanged;
            cbGValues.KeyDown += cbGroup_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(53, 36);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Kolona:";
            // 
            // cbGroup
            // 
            cbGroup.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbGroup.FormattingEnabled = true;
            cbGroup.Items.AddRange(new object[] { "----" });
            cbGroup.Location = new Point(105, 33);
            cbGroup.Name = "cbGroup";
            cbGroup.Size = new Size(228, 23);
            cbGroup.TabIndex = 0;
            cbGroup.Text = "----";
            cbGroup.TextChanged += cbGroup_TextChanged;
            cbGroup.KeyDown += cbGroup_KeyDown;
            // 
            // btnktheu
            // 
            btnktheu.Anchor = AnchorStyles.Bottom;
            btnktheu.BackColor = Color.FromArgb(192, 0, 0);
            btnktheu.Cursor = Cursors.Hand;
            btnktheu.FlatStyle = FlatStyle.Flat;
            btnktheu.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnktheu.ForeColor = Color.White;
            btnktheu.Location = new Point(353, 51);
            btnktheu.Name = "btnktheu";
            btnktheu.Size = new Size(87, 28);
            btnktheu.TabIndex = 16;
            btnktheu.Tag = "1";
            btnktheu.Text = "Ktheu";
            btnktheu.TextImageRelation = TextImageRelation.TextAboveImage;
            btnktheu.UseVisualStyleBackColor = false;
            btnktheu.Click += btnktheu_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePicker3);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cbUnit);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(comboDate);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 211);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(428, 116);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtro sipas datës";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker3.CustomFormat = "dd MMM yyyy";
            dateTimePicker3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(74, 69);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(228, 25);
            dateTimePicker3.TabIndex = 10;
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(325, 36);
            label10.Name = "label10";
            label10.Size = new Size(32, 15);
            label10.TabIndex = 9;
            label10.Text = "Unit:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 69);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "Vlera:";
            // 
            // cbUnit
            // 
            cbUnit.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbUnit.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbUnit.FlatStyle = FlatStyle.Flat;
            cbUnit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbUnit.FormattingEnabled = true;
            cbUnit.Items.AddRange(new object[] { "=", "<", ">", "<=", ">=" });
            cbUnit.Location = new Point(357, 34);
            cbUnit.Name = "cbUnit";
            cbUnit.Size = new Size(54, 23);
            cbUnit.TabIndex = 8;
            cbUnit.Text = "=";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 35);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 1;
            label5.Text = "Kolona:";
            // 
            // comboDate
            // 
            comboDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboDate.FormattingEnabled = true;
            comboDate.Items.AddRange(new object[] { "----" });
            comboDate.Location = new Point(74, 33);
            comboDate.Name = "comboDate";
            comboDate.Size = new Size(228, 23);
            comboDate.TabIndex = 0;
            comboDate.Text = "----";
            comboDate.KeyDown += cbGroup_KeyDown;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cb2date);
            groupBox3.Controls.Add(dtEnd);
            groupBox3.Controls.Add(dtStart);
            groupBox3.Controls.Add(btnCheckBetweenTwoDates);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(cb2Date1);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 333);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(428, 145);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Filtro sipas ndërmjet dy datave";
            // 
            // cb2date
            // 
            cb2date.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cb2date.FormattingEnabled = true;
            cb2date.Items.AddRange(new object[] { "----" });
            cb2date.Location = new Point(66, 37);
            cb2date.Name = "cb2date";
            cb2date.Size = new Size(137, 23);
            cb2date.TabIndex = 20;
            cb2date.Text = "----";
            cb2date.KeyDown += cbGroup_KeyDown;
            // 
            // dtEnd
            // 
            dtEnd.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtEnd.CustomFormat = "dd MMM yyyy";
            dtEnd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtEnd.Format = DateTimePickerFormat.Custom;
            dtEnd.Location = new Point(281, 66);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(130, 25);
            dtEnd.TabIndex = 19;
            // 
            // dtStart
            // 
            dtStart.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtStart.CustomFormat = "dd MMM yyyy";
            dtStart.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtStart.Format = DateTimePickerFormat.Custom;
            dtStart.Location = new Point(68, 66);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(135, 25);
            dtStart.TabIndex = 18;
            // 
            // btnCheckBetweenTwoDates
            // 
            btnCheckBetweenTwoDates.Anchor = AnchorStyles.Bottom;
            btnCheckBetweenTwoDates.BackColor = Color.FromArgb(50, 137, 195);
            btnCheckBetweenTwoDates.Cursor = Cursors.Hand;
            btnCheckBetweenTwoDates.FlatStyle = FlatStyle.Flat;
            btnCheckBetweenTwoDates.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCheckBetweenTwoDates.ForeColor = Color.White;
            btnCheckBetweenTwoDates.Location = new Point(324, 111);
            btnCheckBetweenTwoDates.Name = "btnCheckBetweenTwoDates";
            btnCheckBetweenTwoDates.Size = new Size(87, 28);
            btnCheckBetweenTwoDates.TabIndex = 17;
            btnCheckBetweenTwoDates.Tag = "1";
            btnCheckBetweenTwoDates.Text = "Vendos";
            btnCheckBetweenTwoDates.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCheckBetweenTwoDates.UseVisualStyleBackColor = false;
            btnCheckBetweenTwoDates.Click += btnCheckBetweenTwoDates_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(238, 73);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 7;
            label8.Text = "Vlera:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(227, 39);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 5;
            label9.Text = "Kolona:";
            // 
            // cb2Date1
            // 
            cb2Date1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cb2Date1.FormattingEnabled = true;
            cb2Date1.Items.AddRange(new object[] { "----" });
            cb2Date1.Location = new Point(281, 33);
            cb2Date1.Name = "cb2Date1";
            cb2Date1.Size = new Size(130, 23);
            cb2Date1.TabIndex = 4;
            cb2Date1.Text = "----";
            cb2Date1.KeyDown += cbGroup_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(24, 73);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 3;
            label6.Text = "Vlera:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(11, 39);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 1;
            label7.Text = "Kolona:";
            // 
            // FiltringFormsTool
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(452, 524);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnktheu);
            Controls.Add(groupBox1);
            Controls.Add(txtName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FiltringFormsTool";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Filtro të dhënat";
            FormClosing += FilterForm_FormClosing;
            Load += FiltringFormsTool_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private GroupBox groupBox1;
        private Label label3;
        private ComboBox cbGValues;
        private Label label2;
        private ComboBox cbGroup;
        private Button btnktheu;
        private GroupBox groupBox2;
        private Label label4;
        private ComboBox comboBox3;
        private Label label5;
        private ComboBox comboDate;
        private GroupBox groupBox3;
        private Label label6;
        private ComboBox comboBox5;
        private Label label7;
        private ComboBox comboBox6;
        private Button btnCheckBetweenTwoDates;
        private Label label8;
        private ComboBox comboBox7;
        private Label label9;
        private ComboBox cb2Date1;
        private Label label10;
        private ComboBox cbUnit;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dtEnd;
        private DateTimePicker dtStart;
        private ComboBox cb2date;
    }
}