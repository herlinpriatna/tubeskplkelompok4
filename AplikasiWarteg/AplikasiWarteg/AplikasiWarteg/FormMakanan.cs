﻿using System;
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
    public partial class FormMakanan : Form
    {
        public FormMakanan()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FormMenuUtama formMenu = new FormMenuUtama();
            formMenu.Show();
            this.Hide();
        }

        private void btnPaketLengkap_Click(object sender, EventArgs e)
        {
            FormMenuUtama formMenu = new FormMenuUtama();
            formMenu.Show();
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

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            FormKeranjang formKeranjang = new FormKeranjang();
            formKeranjang.Show();
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
    }
}
