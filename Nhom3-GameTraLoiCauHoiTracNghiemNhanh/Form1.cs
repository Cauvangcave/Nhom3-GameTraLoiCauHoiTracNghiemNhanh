using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom3_GameTraLoiCauHoiTracNghiemNhanh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            wrongLabel.Visible = false;
        }

        private void txtSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSelectUser.SelectedIndex == 0)
            {
                panel2.Visible = true;
                panel1.Visible = false;
            }
            else if (txtSelectUser.SelectedIndex == 1)
            {
                panel1 .Visible = true;
                panel2 .Visible = false;
            }
        }

        private void checkBoxShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowHide.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
                checkBoxShowHide.Text = "Hide Password";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                checkBoxShowHide.Text = "Show Password";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Cauvangcave" && txtPassword.Text == "Cauvangcave123")
            {
                wrongLabel.Visible = false;
                Teacher te = new Teacher();
                te.Show();
                this.Hide();
            }
            else
            {
                wrongLabel.Visible = true;
            }
        }

        
    }
}
