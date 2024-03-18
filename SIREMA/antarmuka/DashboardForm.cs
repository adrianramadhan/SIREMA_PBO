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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void jurusanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 jurusan = new Form1();
            jurusan.TopLevel = false;
            panel3.Controls.Add(jurusan);

            jurusan.Show();
            //jurusan.ShowDialog();
        }

        private void programStudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramStudi_Form prodi = new ProgramStudi_Form();
            prodi.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Close();
        }
    }
}
