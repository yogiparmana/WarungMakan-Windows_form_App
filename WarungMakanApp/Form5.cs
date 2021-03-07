using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarungMakanApp
{
    public partial class Form5 : Form
    {
        int total,kem =-1;
        string[] arr = new string[3];
        
        public Form5(String[] datauser,int total)
        {
            InitializeComponent();
            label2.Text = "Nama : " + datauser[0];
            label4.Text = "Meja : " + datauser[1];
            label3.Text += total;
            this.total = total;
            this.arr = datauser;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonbayar_Click(object sender, EventArgs e)
        {
            kem = int.Parse(textBox1.Text) - total;
            if(kem < 0)
            {
                label5.Text = "Kembalian : uang kurang lagi Rp. " + (kem*-1);
            }
            else
            {
                label5.Text = "Kembalian : " + kem.ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelduduk_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(kem < 0)
            {
                MessageBox.Show("Silakan Bayar / Lunasi Dulu !", "Kesalahan");
            }
            else
            {
                Form1 f = new Form1(arr,"1");
                f.Show();
                this.Hide();
            }
        }
    }
}
