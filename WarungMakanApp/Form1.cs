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
    public partial class Form1 : Form
    {
        string[] arr;
        string promptValue = "";
        public Form1(String[] datauser, string a ) 
        {
            InitializeComponent();
            this.arr = datauser;
            if (a == "1")
            {
                panel2.SendToBack();
               
                labelnama.Text = "Selamat Datang " + datauser[0];
            }
            else 
            {
                panel2.BringToFront();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form21 f = new Form21(arr);
            f.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form22 f = new Form22(arr);
            f.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("v00.1", "Version",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(arr);
            f.Show();
            this.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void buttondaftar_Click(object sender, EventArgs e)
        {
            
                promptValue = Prompt.ShowDialog("Masukkan Nama Anda", "Pilih Meja", "Daftar");
                User user = new User(promptValue);
                arr = user.nama.ToString().Split('+');
                labelnama.Text = "Selamat Datang " + arr[0];
                panel2.SendToBack();
           
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form21 f = new Form21(arr);
            f.Show();
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yogi Parmana \n 180030514", "Dev", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
