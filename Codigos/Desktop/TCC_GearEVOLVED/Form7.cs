using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_GearEVOLVED
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "12345")
            {
                textBox2.Text = "TUF-GTX1660TI-O6G-EVO-GAMING";
                textBox3.Text = "ASUS GeForce GTX 1660Ti TUF GAMING";
                textBox4.Text = "ASUS";
                textBox5.Text = "Placa de Vídeo ASUS GeForce GTX 1660Ti TUF GAMING OC, 6GB, GDDR6, 192-BIT, PCI Express 3.0, 1536 núclos CUDA, 1853MHz modo OC (Boost), TUF-GTX1660TI-O6G-EVO-GAMING";
                textBox6.Text = "08/03/2022";
                textBox7.Text = "09:30";
                comboBox1.Text = "PM";
                textBox8.Text = "28/05/2022";
                textBox9.Text = "05:00";
                comboBox2.Text = "PM";
            }
            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                comboBox1.Text = " ";
                comboBox2.Text = " ";
                MessageBox.Show("Digite um Código de Produto para ser pesquisado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                comboBox1.Text = " ";
                comboBox2.Text = " ";
                MessageBox.Show("Produto não cadastrado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
