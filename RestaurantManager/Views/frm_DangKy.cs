using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.Views
{
    public partial class frm_DangKy : Form
    {
        public frm_DangKy()
        {
            InitializeComponent();

        }
        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            frm_DangNhap frm_DN = new frm_DangNhap();
            frm_DN.Show();
            this.Close();
        }

        private void cbxShowPass_OnChange(object sender, EventArgs e)
        {
            if (cbxShowPass.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
                txtNhapLaiPass.UseSystemPasswordChar = false;
                bunifuCustomLabel3.ForeColor = Color.SteelBlue;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                txtNhapLaiPass.UseSystemPasswordChar = true;
                bunifuCustomLabel3.ForeColor = Color.White;
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            panel1.BackColor = Color.SteelBlue;
            txtUser.ForeColor = Color.SteelBlue;
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            panel2.BackColor = Color.SteelBlue;
            txtPass.ForeColor = Color.SteelBlue;
        }

        private void txtNhapLaiPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            panel3.BackColor = Color.SteelBlue;
            txtNhapLaiPass.ForeColor = Color.SteelBlue;
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
            txtUser.ForeColor = Color.White;
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
            txtPass.ForeColor = Color.White;
        }

        private void txtNhapLaiPass_Leave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
            txtNhapLaiPass.ForeColor = Color.White;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            frm_DangNhap frm_DN = new frm_DangNhap();
            frm_DN.Show();
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }
    }
}
