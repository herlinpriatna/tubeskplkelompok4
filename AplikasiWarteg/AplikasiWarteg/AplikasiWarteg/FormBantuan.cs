using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiWarteg
{
    public partial class FormBantuan : Form
    {
        public FormBantuan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pemesananan bisa dilakukan secara langsung melalui aplikasi");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Metode Pembayaran bisa melalui bank, ewallet, atau COD");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Metode Pengiriman bisa melalui Gojek, Grab ataupun jasa pengiriman antar makanan lainnya");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenuUtama formMenuUtama = new FormMenuUtama();
            formMenuUtama.Show();
            this.Hide();
        }
    }
}
