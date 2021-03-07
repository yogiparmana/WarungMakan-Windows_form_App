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
    public partial class Form21 : Form
    {
        int harga;
        string[] datauser;
        Bitmap gambar;
        string nama;
        int[] count = {0,0,0,0,0,0}; 
        string[] data = new string[6];
        List<items_pesanan> d = new List<items_pesanan>();

        public Form21(String[] datauser)
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
            data[0] = "Minuman_1";
            data[1] = "1000";
            data[2] = "10";
            data[3] = "Ini adalah Minuman yang terbuat dari bla bla bla dan ble ble ble";
            
            gambar = WarungMakanApp.Properties.Resources.esteh;
            Form3 f = new Form3(data,gambar);
            f.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            harga = 1000;
            nama = "Minuman_1";
            count[0] ++;
            label8.Text = count[0].ToString();
            d.Add(new items_pesanan() { nama = nama, harga = harga });

        }

        private void button2_Click(object sender, EventArgs e)
        {
            harga = 10000;
            nama = "Minuman_2";
            count[1]++;
            label9.Text = count[1].ToString();
            d.Add(new items_pesanan() { nama = nama, harga = harga });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            harga = 8000;
            nama = "Mimuman_3";
            count[2]++;
            label10.Text = count[2].ToString();
            d.Add(new items_pesanan() { nama = nama, harga = harga });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            harga = 8000;
            nama = "Minuman_4";
            count[3]++;
            label13.Text = count[3].ToString();
            d.Add(new items_pesanan() { nama = nama, harga = harga });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            harga = 9000;
            nama = "Minuman_5";
            count[4]++;
            label12.Text = count[4].ToString();
            d.Add(new items_pesanan() { nama = nama, harga = harga });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            harga = 10000;
            nama = "Minuman_6";
            count[5]++;
            label11.Text = count[5].ToString();
            d.Add(new items_pesanan() { nama = nama, harga = harga });
        }

        private void Form2_Load(object sender, EventArgs e)
        {

          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            data[0] = "Minuman_2";
            data[1] = "20000";
            data[2] = "20";
            data[3] = "Ini adalah Minuman dari bla bla bla dan ble ble ble";
            gambar = WarungMakanApp.Properties.Resources.food_and_beverage_photography_4_a6e79806fbc35522fb2c221ff3e7d8c5;
            Form3 f = new Form3(data,gambar);
            f.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            data[0] = "Minuman_3";
            data[1] = "8000";
            data[2] = "25";
            data[3] = "Ini adalah minuman dari bla bla bla dan ble ble ble";
            gambar = WarungMakanApp.Properties.Resources.Jasa_Fotografi_Makanan_Kafe_Dontea_Minuman_Dengan_Topping;
            Form3 f = new Form3(data, gambar);
            f.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            data[0] = "Minuman_4";
            data[1] = "8000";
            data[2] = "15";
            data[3] = "Ini adalah minuman dari bla bla bla dan ble ble ble";
            gambar = WarungMakanApp.Properties.Resources.images;
            Form3 f = new Form3(data, gambar);
            f.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            data[0] = "Minuman_5";
            data[1] = "9000";
            data[2] = "5";
            data[3] = "Ini adalah minuman dari bla bla bla dan ble ble ble";
            gambar = WarungMakanApp.Properties.Resources.download__2_;
            Form3 f = new Form3(data, gambar);
            f.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            data[0] = "Minuman_6";
            data[1] = "10000";
            data[2] = "23";
            data[3] = "Ini adalah minuman dari bla bla bla dan ble ble ble";
            gambar = WarungMakanApp.Properties.Resources.tips_fotografi_minuman;
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
