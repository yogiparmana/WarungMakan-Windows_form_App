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
    public partial class Form4 : Form
    {
        List<items_pesanan> list = new List<items_pesanan>();
        String[] data;
        int total = 0;
        public Form4(List<items_pesanan> items_Pesanans, string[] datauser)
        { 
            InitializeComponent();
            labelnama.Text = "Nama : " + datauser[0];
            this.data = datauser;
            this.list = items_Pesanans;
            ShowingArray();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
    


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        
        public void ShowingArray()
        {
           
            for (int i = 0; i < list.Count; i++)
            {
              listBox1.Items.Add((i+1)+". "+list[i].nama + " : \t" + list[i].harga);
                total += list[i].harga;
            }
            labelduduk.Text = "banyak pesanan : " + list.Count.ToString();
            label3.Text += total.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void labelnama_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5(data, total);
            f.Show();
            this.Hide();
        }

        private void buttonpesanlagi_Click(object sender, EventArgs e)
        {

        }
    }
}
