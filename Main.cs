using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QL_Khenthuong
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private Form currentChildFrom;
        private void openChildForm(Form childForm)
        {
            if (currentChildFrom != null)
            {
                currentChildFrom.Close();
            }
            currentChildFrom = childForm;
            childForm.TopLevel = false;
            pnmain.Controls.Add(childForm);
            pnmain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public bool is_logout = false;
        public event EventHandler dangxuat;
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            is_logout = true;
            dangxuat(this, new EventArgs());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (is_logout) { }
            else
            {
                Application.Exit();
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new nhanvien());
            lbForm.Text = "Form nhân viên";
        }

        private void pbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new phongban());
            lbForm.Text = "Form phòng ban";
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

       
    }
}
