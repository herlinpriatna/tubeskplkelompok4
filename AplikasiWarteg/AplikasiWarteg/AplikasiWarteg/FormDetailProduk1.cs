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
    public partial class FormDetailProduk1 : Form
    {
        public FormDetailProduk1()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormMenuUtama formMenuUtama = new FormMenuUtama();
            formMenuUtama.ShowDialog();
            this.Close();
        }
    }
}
