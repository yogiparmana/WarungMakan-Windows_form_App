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
    public partial class Form3 : Form
    {
        string[] arr = new string[6];
        string[] datauser = new string[2];
        Bitmap gambar;
        public Form3(string[] data, Bitmap b)
        {
            InitializeComponent();
            this.arr = data;
            this.datauser[0] = arr[4];
            this.datauser[1] = arr[5];
            this.gambar = b;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = gambar;
            pictureBox2.Image = gambar;
            pictureBox3.Image = gambar;
            labelNama.Text = labelNama.Text + arr[0];
            labelHarga.Text = labelHarga.Text + arr[1];
            labelstok.Text = labelstok.Text + arr[2];
            textBox1.Text = arr[3];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDesc_Click(object sender, EventArgs e)
        {

        }

        private void labelstok_Click(object sender, EventArgs e)
        {

        }

        private void labelNama_Click(object sender, EventArgs e)
        {

        }

        private void labelHarga_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string[] m = arr[0].Split('_');
            if(m[0] == "Makanan")
            {
                Form2 f = new Form2(datauser);
                f.Show();
                this.Hide();
            }
            if(m[0] == "Minuman")
            {
                Form21 f = new Form21(datauser);
                f.Show();
                this.Hide();
            }
            if (m[0] == "Snack")
            {
                Form22 f = new Form22(datauser);
                f.Show();
                this.Hide();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
