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
    public partial class Form22 : Form
    {
        int harga;
        string[] datauser;
        Bitmap gambar;
        string nama;
        int[] count = {0,0,0,0,0,0}; 
        string[] data = new string[6];
        List<items_pesanan> d = new List<items_pesanan>();

        public Form22(String[] datauser)
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
            data[0] = "Snack_1";
            data[1] = "1000";
            data[2] = "10";
            data[3] = "Ini adalah Snack yang terbuat dari bla bla bla dan ble ble ble";
            
            gambar = WarungMakanApp.Properties.Resources.rekomendasi_Snack_favorit_007;
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
            nama = "Snack_1";
            count[0] ++;
            label8.Text = count[0].ToString();
            d.Add(new items_pesanan() { nama = nama, harga = harga });

        }

        private void button2_Click(object sender, EventArgs e)
        {
            harga = 2000;
            nama = "Snack_2";
            count[1]++;
            label9.Text = count[1].ToString();
            d.Add(new items_pesanan() { nama = nama, harga = harga });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            harga = 3000;
            nama = "Snack_3";
            count[2]++;
            label10.Text = count[2].ToString();
            d.Add(new items_pesanan() { nama = nama, harga = harga });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            harga = 4000;
            nama = "Snack_4";
            count[3]++;
            label13.Text = count[3].ToString();
            d.Add(new items_pesanan() { nama = nama, harga = harga });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            harga = 5000;
            nama = "Snack_5";
            count[4]++;
            label12.Text = count[4].ToString();
            d.Add(new items_pesanan() { nama = nama, harga = harga });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            harga = 6000;
            nama = "Snack_6";
            count[5]++;
            label11.Text = count[5].ToString();
            d.Add(new items_pesanan() { nama = nama, harga = harga });
        }

        private void Form2_Load(object sender, EventArgs e)
        {

          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            data[0] = "Snack_2";
            data[1] = "2000";
            data[2] = "20";
            data[3] = "Ini adalah Snack dari bla bla bla dan ble ble ble";
            gambar = WarungMakanApp.Properties.Resources.Kon_Snack_Taro_3D_Potato_Jungle_Chicken;
            Form3 f = new Form3(data,gambar);
            f.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            data[0] = "Snack_3";
            data[1] = "3000";
            data[2] = "25";
            data[3] = "Ini adalah Snack dari bla bla bla dan ble ble ble";
            gambar = WarungMakanApp.Properties.Resources._2a373b7a_12a8_405c_a520_e0f1904eee34;
            Form3 f = new Form3(data, gambar);
            f.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            data[0] = "Snack_6";
            data[1] = "6000";
            data[2] = "15";
            data[3] = "Ini adalah Snack dari bla bla bla dan ble ble ble";
            gambar = WarungMakanApp.Properties.Resources._20101064_1;
            Form3 f = new Form3(data, gambar);
            f.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            data[0] = "Snack_5";
            data[1] = "5000";
            data[2] = "5";
            data[3] = "Ini adalah Snack dari bla bla bla dan ble ble ble";
            gambar = WarungMakanApp.Properties.Resources.kemasan_snack_bantal_full_printing;
            Form3 f = new Form3(data, gambar);
            f.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            data[0] = "Snack_4";
            data[1] = "4000";
            data[2] = "23";
            data[3] = "Ini adalah Snack dari bla bla bla dan ble ble ble";
            gambar = WarungMakanApp.Properties.Resources._9c591f624ffe85b95a2268dda6495cf4;
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
