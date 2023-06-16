using Microsoft.VisualBasic;
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
    public partial class DaftarMenuPenjual : Form
    {
        private List<string> dataMakanan;

        public DaftarMenuPenjual()
        {
            InitializeComponent();

            dataMakanan = new List<string>();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            TampilanAwal tampilanAwal = new TampilanAwal();
            tampilanAwal.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardPenjual dashboard = new DashboardPenjual();
            dashboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Harap lengkapi data");
            }
            else
            {
                dataMakanan.Add(textBox1.Text + "\t\t\t\t\t" + textBox2.Text);
                RefreshListBox();
            }
        }

        private void RefreshListBox()
        {
            listBox1.Items.Clear();
            foreach (string data in dataMakanan)
            {
                listBox1.Items.Add(data);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int selectedIndex = listBox1.SelectedIndex;
                string editedItem = Interaction.InputBox("Edit Item", "Edit", listBox1.SelectedItem.ToString());
                dataMakanan[selectedIndex] = editedItem;
                RefreshListBox();
            }
            else
            {
                MessageBox.Show("Pilih item yang ingin diubah");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int selectedIndex = listBox1.SelectedIndex;
                dataMakanan.RemoveAt(selectedIndex);
                RefreshListBox();
            }
            else
            {
                MessageBox.Show("Pilih item yang ingin dihapus");
            }
        }
    }
}
