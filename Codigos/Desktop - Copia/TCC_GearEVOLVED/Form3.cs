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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "87654321")
            {
                textBox3.Text = "Roberto Silvério";
                textBox4.Text = "R$ 3.100,00";
                textBox5.Text = "AJ5897K1";
                textBox6.Text = "Placa Mãe Gigabyte Z590 rev(1.0), Soquete LGA 1700 para processadores Intel Core i9 12° geração, Intel Core i7 e Intel Core i5, ATX, 4 slots de memória DDR5 até 128GB, Suporte para SSDs M.2 NVme, WiFi.";
                textBox7.Text = "2";
                textBox8.Text = "R$6.200,00";
                textBox1.Text = "Pagamento Aprovado";
            }
            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox1.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                MessageBox.Show("Digite um Número de Registro de venda para ser pesquisado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                textBox1.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                MessageBox.Show("Venda não cadastrada!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
