using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WartegBerkah
{
    public partial class LoginPenjual : Form
    {
        readonly string username = "penjual";
        readonly string password = "penjual";

        public LoginPenjual()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;

            if (textBox1.Text == username && textBox2.Text == password)
            {
                DashboardPenjual dashboardPenjual = new DashboardPenjual();
                MessageBox.Show("Berhasil Login");
                dashboardPenjual.Show();
                this.Hide();
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Mohon masukkan username dan password terlebih dahulu");
            }
            else
            {
                MessageBox.Show("Mohon maaf, username atau password yang anda masukkan salah");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Penjual penjual = new Penjual();
            penjual.Show();
        }
    }
}
