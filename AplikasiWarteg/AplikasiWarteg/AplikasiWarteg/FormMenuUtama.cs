namespace AplikasiWarteg
{
    public partial class FormMenuUtama : Form
    {
        public FormMenuUtama()
        {
            InitializeComponent();
        }

        private void btnMakanan_Click(object sender, EventArgs e)
        {
            FormMakanan formMakanan = new FormMakanan();
            formMakanan.Show();
            this.Hide();
        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            FormKeranjang formKeranjang = new FormKeranjang();
            formKeranjang.Show();
            this.Hide();
        }

        private void btnMinuman_Click(object sender, EventArgs e)
        {
            FormMinuman formMinuman = new FormMinuman();
            formMinuman.Show();
            this.Hide();
        }

        private void btnGorengan_Click(object sender, EventArgs e)
        {
            FormGorengan formGorengan = new FormGorengan();
            formGorengan.Show();
            this.Hide();
        }

        private void btnBantuan_Click(object sender, EventArgs e)
        {
            FormBantuan formBantuan = new FormBantuan();
            formBantuan.Show();
            this.Hide();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            FormDetailProduk1 formDetailProduk1 = new FormDetailProduk1();
            formDetailProduk1.Show();
            this.Hide();
        }
    }
}