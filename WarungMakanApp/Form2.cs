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
    public partial class Form2 : Form
    {
        int harga;
        string[] datauser;
        Bitmap gambar;
        string nama;
        int[] count = {0,0,0,0,0,0}; 
        string[] data = new string[6];
        List<items_pesanan> d = new List<items_pesanan>();

        public Form2(String[] datauser)
        {
            InitializeComponent();
            this.datauser = datauser;
            data[4] = datauser[0];
            data[5] = datauser[1];

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            data[0] = "Makanan_1";
            data[1] = "5000";
            data[2] = "10";
            data[3] = "Ini adalah makanan yang terbuat dari bla bla bla dan ble ble ble";
            
            gambar = WarungMakanApp.Properties.Resources.chow_mein1;
            Form3 f = new Form3(data,gambar);
            f.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            harga = 5000;
            nama = "Makanan_1";
            count[0] ++;
            label8.Text = count[0].ToString();
            d.Add(new items_pesanan() { nama = nama, harga = harga });

        }

        private void button2_Click(object sender, EventArgs e)
        {
            harga = 6000;
            nama = "Makanan_2";
            count[1]++;
            label9.Text = count[1].ToString();
            d.Add(new items_pesanan() { nama = nama, harga = harga });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            harga = 7000;
            nama = "Makanan_3";
            count[2]++;
            label10.Text = count[2].ToString();
            d.Add(new items_pesanan() { nama = nama, harga = harga });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            harga = 8000;
            nama = "Makanan_4";
            count[3]++;
            label13.Text = count[3].ToString();
            d.Add(new items_pesanan() { nama = nama, harga = harga });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            harga = 9000;
            nama = "Makanan_5";
            count[4]++;
            label12.Text = count[4].ToString();
            d.Add(new items_pesanan() { nama = nama, harga = harga });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            harga = 10000;
            nama = "Makanan_6";
            count[5]++;
            label11.Text = count[5].ToString();
            d.Add(new items_pesanan() { nama = nama, harga = harga });
        }

        private void Form2_Load(object sender, EventArgs e)
        {

          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            data[0] = "Makanan_2";
            data[1] = "6000";
            data[2] = "20";
            data[3] = "Ini adalah makanan dari bla bla bla dan ble ble ble";
            gambar = WarungMakanApp.Properties.Resources.fuyunghai;
            Form3 f = new Form3(data,gambar);
            f.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            data[0] = "Makanan_3";
            data[1] = "7000";
            data[2] = "25";
            data[3] = "Ini adalah makanan dari bla bla bla dan ble ble ble";
            gambar = WarungMakanApp.Properties.Resources.kwetiau;
            Form3 f = new Form3(data, gambar);
            f.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            data[0] = "Makanan_4";
            data[1] = "8000";
            data[2] = "15";
            data[3] = "Ini adalah makanan dari bla bla bla dan ble ble ble";
            gambar = WarungMakanApp.Properties.Resources.mapotofu;
            Form3 f = new Form3(data, gambar);
            f.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            data[0] = "Makanan_5";
            data[1] = "9000";
            data[2] = "5";
            data[3] = "Ini adalah makanan dari bla bla bla dan ble ble ble";
            gambar = WarungMakanApp.Properties.Resources.Food_Photography_4;
            Form3 f = new Form3(data, gambar);
            f.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            data[0] = "Makanan_6";
            data[1] = "10000";
            data[2] = "23";
            data[3] = "Ini adalah makanan dari bla bla bla dan ble ble ble";
            gambar = WarungMakanApp.Properties.Resources.Teknik_foto_makanan_iga;
            Form3 f = new Form3(data, gambar);
            f.Show();
            this.Hide();
        }

       
        private void button10_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4(d,datauser);

            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(datauser, "1");
            f.Show();
            this.Hide();
        }
    }
}
