using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarungMakanApp
{
    public static class Prompt
    {
        
        public static string ShowDialog(string text, string text1, string caption)
        {
            string[] items = {
        "Mawar",
        "Melati",
        "Kamboja",
        "Lily"
    };
            Form prompt = new Form()
            {
                Width = 500,
                Height = 250,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen,
                BackColor = System.Drawing.Color.MidnightBlue,
                Font = System.Drawing.SystemFonts.CaptionFont,
                ForeColor = System.Drawing.Color.White
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Label textLabel1 = new Label() { Left = 50, Top = 100, Text = text1 };
            ComboBox cmb = new ComboBox() { Left = 50, Top = 130,Width = 400, MaxDropDownItems = 5,
        };
            cmb.Items.AddRange(items);
            Button confirmation = new Button() { Text = "Daftar", Left = 350, Width = 120, Top = 160, DialogResult = DialogResult.OK };
       
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(cmb);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textLabel1);
            confirmation.Click += (sender, e) => {

                    prompt.Close();

                };
            prompt.AcceptButton = confirmation;

            prompt.Controls.Add(confirmation);


            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text +" + "+ cmb.Text : "";
        }
    }
}
