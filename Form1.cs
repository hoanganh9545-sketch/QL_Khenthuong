
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Khenthuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnlog_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtpass.Text;

            string sql = "SELECT * FROM [User] WHERE username = '" + username + "' AND password = '" + password + "'";
            connectBD connect = new connectBD();
            DataTable dt = connect.ReadData(sql);

            if (dt.Rows.Count > 0)
            {
                Main frmMain = new Main();
                frmMain.Show();
                this.Hide();
                frmMain.dangxuat += FrmMain_dangxuat;
            }
            else
            {
                MessageBox.Show("TK hoặc MK không chính xác");
            }
        }

        private void FrmMain_dangxuat(object sender, EventArgs e)
        {
            (sender as Main).is_logout = true;
            (sender as Main).Close();
            this.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {

            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
