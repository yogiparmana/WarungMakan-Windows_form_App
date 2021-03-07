
namespace WarungMakanApp
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDesc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelstok = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.labelDesc);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.labelstok);
            this.panel2.Controls.Add(this.labelHarga);
            this.panel2.Controls.Add(this.labelNama);
            this.panel2.Location = new System.Drawing.Point(12, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 229);
            this.panel2.TabIndex = 1;
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDesc.Font = new System.Drawing.Font("Poppins", 10F);
            this.labelDesc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDesc.Location = new System.Drawing.Point(11, 82);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(57, 25);
            this.labelDesc.TabIndex = 11;
            this.labelDesc.Text = "Desc : ";
            this.labelDesc.Click += new System.EventHandler(this.labelDesc_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Font = new System.Drawing.Font("Poppins", 10F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Location = new System.Drawing.Point(16, 102);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(317, 108);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelstok
            // 
            this.labelstok.AutoSize = true;
            this.labelstok.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelstok.Font = new System.Drawing.Font("Poppins", 10F);
            this.labelstok.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelstok.Location = new System.Drawing.Point(12, 56);
            this.labelstok.Name = "labelstok";
            this.labelstok.Size = new System.Drawing.Size(52, 25);
            this.labelstok.TabIndex = 10;
            this.labelstok.Text = "Stok : ";
            this.labelstok.Click += new System.EventHandler(this.labelstok_Click);
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelHarga.Font = new System.Drawing.Font("Poppins", 10F);
            this.labelHarga.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelHarga.Location = new System.Drawing.Point(12, 31);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(61, 25);
            this.labelHarga.TabIndex = 9;
            this.labelHarga.Text = "Harga :";
            this.labelHarga.Click += new System.EventHandler(this.labelHarga_Click);
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelNama.Font = new System.Drawing.Font("Poppins", 10F);
            this.labelNama.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNama.Location = new System.Drawing.Point(12, 6);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(65, 25);
            this.labelNama.TabIndex = 8;
            this.labelNama.Text = "Nama : ";
            this.labelNama.Click += new System.EventHandler(this.labelNama_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(12, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 100);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Detail Makanan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Location = new System.Drawing.Point(265, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 23);
            this.button9.TabIndex = 19;
            this.button9.Text = "Kembali";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WarungMakanApp.Properties.Resources.chow_mein;
            this.pictureBox3.Location = new System.Drawing.Point(1, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(111, 98);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WarungMakanApp.Properties.Resources.chow_mein;
            this.pictureBox2.Location = new System.Drawing.Point(236, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WarungMakanApp.Properties.Resources.chow_mein;
            this.pictureBox1.Location = new System.Drawing.Point(118, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(371, 408);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail Makanan";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelstok;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelNama;
    }
}