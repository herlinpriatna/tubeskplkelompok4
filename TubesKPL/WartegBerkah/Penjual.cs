﻿using System;
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
    public partial class Penjual : Form
    {
        public Penjual()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPenjual loginPenjual = new LoginPenjual();
            loginPenjual.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TampilanAwal tampilanAwal = new TampilanAwal();
            tampilanAwal.Show();
        }
    }
}
