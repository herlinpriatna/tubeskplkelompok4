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
    public partial class DashboardPenjual : Form
    {
        public DashboardPenjual()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DaftarMenuPenjual daftarMenuPenjual = new DaftarMenuPenjual();
            daftarMenuPenjual.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            TampilanAwal tampilanAwal = new TampilanAwal();
            tampilanAwal.Show();
        }
    }
}
