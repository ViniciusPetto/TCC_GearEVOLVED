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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "12345678")
            {
                textBox3.Text = "Roberto Silvério";
                textBox4.Text = "01/01/1985";
                textBox5.Text = "robertosilverio@gmail.com";
                textBox6.Text = "13.480-000";
                textBox7.Text = "Rua José da Silva Júnior";
                textBox8.Text = "Bairro Jardim Santa Rosália";
                textBox9.Text = "Limeira";
                textBox10.Text = "SP";
                textBox11.Text = "123.456.789-10";
                textBox12.Text = "12.345.678-9";
                textBox13.Text = "(19)3444-4444";
                textBox14.Text = "Cartão de Crédito; Cartão de Débito";
                textBox15.Text = "Placa de Vídeo GeForce 1660Ti; Processador Intel Core i9 12900K";
            }
            else if(string.IsNullOrEmpty(textBox2.Text))
            {
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                textBox14.Clear();
                textBox15.Clear();
                MessageBox.Show("Digite um Número de Registro para ser pesquisado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                textBox14.Clear();
                textBox15.Clear();
                MessageBox.Show("Cliente não cadastrado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
