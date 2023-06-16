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
    public partial class FormKeranjang : Form
    {
        public FormKeranjang()
        {
            InitializeComponent();
        }

        private void btnDaftarMenu_Click(object sender, EventArgs e)
        {
            FormMenuUtama formMenu = new FormMenuUtama();
            formMenu.Show();
            this.Hide();

        }

        private void btnBantuan_Click(object sender, EventArgs e)
        {
            FormBantuan formBantuan = new FormBantuan();
            formBantuan.Show();
            this.Hide();
        }

        private void btnLanjut_Click(object sender, EventArgs e)
        {
            FormPembayaran formPembayaran = new FormPembayaran();
            formPembayaran.Show();
            this.Hide();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPilih_Click(object sender, EventArgs e)
        {
            FormPembayaran formPembayaran = new FormPembayaran();
            formPembayaran.Show();
            this.Hide();
        }
    }
}
