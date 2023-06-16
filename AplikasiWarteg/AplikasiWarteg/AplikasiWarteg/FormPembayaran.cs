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
    public partial class FormPembayaran : Form
    {
        public FormPembayaran()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPayment.Items.Add("");
            cmbPayment.Items.Add("COD");
            cmbPayment.Items.Add("Bank");
            cmbPayment.Items.Add("E Wallet");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult kembali;
            kembali = MessageBox.Show("Apakah Anda yakin akan membatalkan proses pesanan Anda?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kembali == DialogResult.Yes)
            {
                FormKeranjang formKeranjang = new FormKeranjang();
                formKeranjang.Show();
                this.Hide();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAlamat formAlamat = new FormAlamat();
            formAlamat.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbPengiriman_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPengiriman.Items.Add("");
            cmbPengiriman.Items.Add("Gojek");
            cmbPengiriman.Items.Add("Grab");
        }
    }
}
