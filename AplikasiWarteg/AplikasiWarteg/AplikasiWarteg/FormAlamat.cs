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
    public partial class FormAlamat : Form
    {
        public FormAlamat()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            DialogResult kembali;
            kembali = MessageBox.Show("Apakah Anda yakin akan kembali?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kembali == DialogResult.Yes)
            {
                FormPembayaran formPembayaran = new FormPembayaran();
                formPembayaran.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SILAHKAN ANDA LAKUKAN PEMBAYARAN KE NOMOR REKENING 112393219 (BRI) ATAU EWALLET (0836372833). SETELAH ANDA MELALUKAN PEMBAYARAN, TUNGGU HINGGA MAKANAN ANDA DATANG KE TEMPAT")
        }
    }
}
