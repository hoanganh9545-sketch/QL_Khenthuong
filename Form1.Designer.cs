namespace QL_Khenthuong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnlog = new Button();
            btnexit = new Button();
            label1 = new Label();
            label2 = new Label();
            txtuser = new TextBox();
            txtpass = new TextBox();
            SuspendLayout();
            // 
            // btnlog
            // 
            btnlog.Location = new Point(274, 305);
            btnlog.Name = "btnlog";
            btnlog.Size = new Size(94, 29);
            btnlog.TabIndex = 0;
            btnlog.Text = "login";
            btnlog.UseVisualStyleBackColor = true;
            btnlog.Click += btnlog_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(519, 305);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(94, 29);
            btnexit.TabIndex = 1;
            btnexit.Text = "exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 75);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 132);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(324, 72);
            txtuser.MaxLength = 50;
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(282, 27);
            txtuser.TabIndex = 4;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(324, 129);
            txtpass.MaxLength = 50;
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(282, 27);
            txtpass.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnexit);
            Controls.Add(btnlog);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnlog;
        private Button btnexit;
        private Label label1;
        private Label label2;
        private TextBox txtuser;
        private TextBox txtpass;
    }
}
