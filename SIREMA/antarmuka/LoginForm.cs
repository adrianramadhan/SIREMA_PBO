using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIREMA.antarmuka
{
    using model;
    public partial class LoginForm : Form
    {
        LoginCls login = new LoginCls();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login.apakahAda(userId_txt.Text, password_txt.Text))
            {
                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Maaf, user ID/ Password salah.", "" +
                    "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userId_txt.SelectAll();
                userId_txt.Focus();
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin keluar dari aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Keluar dari aplikasi
                Application.Exit();
            }
            // Jika result == DialogResult.No, maka tidak melakukan apa-apa
        }

    }
}
