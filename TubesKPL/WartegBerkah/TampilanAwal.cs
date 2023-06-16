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
    public partial class TampilanAwal : Form
    {
        public TampilanAwal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pembeli pembeli = new Pembeli();
            pembeli.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Penjual penjual = new Penjual();
            penjual.Show();
        }
    }
}
