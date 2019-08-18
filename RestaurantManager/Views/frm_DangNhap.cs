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
    public partial class frm_DangNhap : Form
    {

        frm_DangKy frm_DK = new frm_DangKy();

        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            panel1.BackColor = Color.SteelBlue;
            txtUsername.ForeColor = Color.SteelBlue;
        }

        private void bunifuCustomTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            panel2.BackColor = Color.SteelBlue;
            txtPassword.ForeColor = Color.SteelBlue;
        }

        private void bunifuCustomTextbox1_Leave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
            txtUsername.ForeColor = Color.White;
        }

        private void bunifuCustomTextbox2_Leave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
            txtPassword.ForeColor = Color.White;
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            frm_DK.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frm_DK.Left += 50;
            if (frm_DK.Left >=830)//830
            {
                timer1.Stop();
                this.TopMost = false;
                frm_DK.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            frm_DK.Left -= 50;
            if (frm_DK.Left <=436)
            {
                timer2.Stop();
                this.Hide();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
        }

        private void cbxShowPass_OnChange(object sender, EventArgs e)
        {
            if (cbxShowPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                bunifuCustomLabel3.ForeColor = Color.SteelBlue;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                bunifuCustomLabel3.ForeColor = Color.White;
            }
        }
    }
}
