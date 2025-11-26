using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projek_icha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Array contoh kode tiket dan jenis kereta
            string[] kodeKereta = { "SEN888", "MALL777", "SUR999" };
            string[] jenisKereta = { "SENJA", "MALAM", "SURYA" };
            double[] hargaTiket = { 15000, 20000, 25000 };
            string[] jamBerangkat = { "20.00", "21,30", "22.00" };

                
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string kode = txtKodTiket.Text.ToUpper();
            int jumlah = 0;
            bool ditemukan = false;

            // validasi jumlah tiket if (!
            int.TryParse(txtJumlah.Teks, out jumlah) || jumlah <= 0;);
            MessageBox.Show("Jumlah tiket harus berupa angka positif", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;


        }
    }
}
