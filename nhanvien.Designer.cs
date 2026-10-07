namespace QL_Khenthuong
{
    partial class nhanvien
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dtptime = new DateTimePicker();
            txtcccd = new TextBox();
            rdNam = new RadioButton();
            rdNu = new RadioButton();
            label9 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            textBox3 = new TextBox();
            btnadd = new Button();
            btnsave = new Button();
            btnedit = new Button();
            btnxoa = new Button();
            btntkiem = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 64);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên Nhân Viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 97);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 130);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 3;
            label4.Text = "Số CCCD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(443, 27);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 4;
            label5.Text = "Giới tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(443, 64);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 5;
            label6.Text = "Phòng ban";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(447, 97);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 6;
            label7.Text = "Chức vụ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(443, 130);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 7;
            label8.Text = "Bậc lương";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 9;
            // 
            // dtptime
            // 
            dtptime.CustomFormat = "dd/MM/yyyy";
            dtptime.Format = DateTimePickerFormat.Custom;
            dtptime.Location = new Point(133, 90);
            dtptime.Name = "dtptime";
            dtptime.Size = new Size(250, 27);
            dtptime.TabIndex = 10;
            // 
            // txtcccd
            // 
            txtcccd.Location = new Point(133, 123);
            txtcccd.Name = "txtcccd";
            txtcccd.Size = new Size(250, 27);
            txtcccd.TabIndex = 11;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Checked = true;
            rdNam.Location = new Point(555, 23);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(62, 24);
            rdNam.TabIndex = 12;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            rdNam.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(644, 23);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(50, 24);
            rdNu.TabIndex = 13;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(784, 27);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 14;
            label9.Text = "Sở thích";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(540, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(217, 28);
            comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(540, 89);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(217, 28);
            comboBox2.TabIndex = 16;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(540, 122);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(217, 28);
            comboBox3.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(784, 56);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(249, 94);
            textBox3.TabIndex = 18;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(217, 175);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(94, 29);
            btnadd.TabIndex = 19;
            btnadd.Text = "Thêm";
            btnadd.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(354, 175);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(94, 29);
            btnsave.TabIndex = 20;
            btnsave.Text = "Lưu";
            btnsave.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            btnedit.Location = new Point(493, 175);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(94, 29);
            btnedit.TabIndex = 21;
            btnedit.Text = "Sửa";
            btnedit.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(631, 175);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 22;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            // 
            // btntkiem
            // 
            btntkiem.Location = new Point(761, 175);
            btntkiem.Name = "btntkiem";
            btntkiem.Size = new Size(94, 29);
            btntkiem.TabIndex = 23;
            btntkiem.Text = "Tìm Kiếm";
            btntkiem.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(122, 226);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(853, 209);
            dataGridView1.TabIndex = 24;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên NV";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 250;
            // 
            // Column3
            // 
            Column3.HeaderText = "Giới tính";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Phòng ban";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 250;
            // 
            // Column5
            // 
            Column5.HeaderText = "Chức vụ";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 250;
            // 
            // nhanvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 463);
            Controls.Add(dataGridView1);
            Controls.Add(btntkiem);
            Controls.Add(btnxoa);
            Controls.Add(btnedit);
            Controls.Add(btnsave);
            Controls.Add(btnadd);
            Controls.Add(textBox3);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(rdNu);
            Controls.Add(rdNam);
            Controls.Add(txtcccd);
            Controls.Add(dtptime);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "nhanvien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "From NV";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dtptime;
        private TextBox txtcccd;
        private RadioButton rdNam;
        private RadioButton rdNu;
        private Label label9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private TextBox textBox3;
        private Button btnadd;
        private Button btnsave;
        private Button btnedit;
        private Button btnxoa;
        private Button btntkiem;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}