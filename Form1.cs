using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base64EncodeAndDecode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var txtDecode = textBox1.Text;

            if (txtDecode.Length != 0)
            {
                try
                {
                    byte[] dadosAsBytes = System.Convert.FromBase64String(txtDecode);
                    string resultado = System.Text.ASCIIEncoding.ASCII.GetString(dadosAsBytes);
                    textBox2.Text = resultado.Replace(";pt-BR", "");
                }
                catch (Exception error)
                {
                    MessageBox.Show($"Error: {error}");
                }

            }else
            {
                MessageBox.Show($"The [Decode from Base64 format] field cannot be empty");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var txtEncode = textBox3.Text;

            if (txtEncode.Length != 0)
            {
                try
                {
                    byte[] textoAsBytes = Encoding.ASCII.GetBytes($"{txtEncode}");
                    string resultado = System.Convert.ToBase64String(textoAsBytes);
                    textBox4.Text = resultado;
                }
                catch (Exception error)
                {
                    MessageBox.Show($"Error: {error}");
                }
            }
            else
            {
                MessageBox.Show($"The [Encode to Base64 format] field cannot be empty");
            }
        }
    }
}
