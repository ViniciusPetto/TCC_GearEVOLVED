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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "1234")
            {
                textBox3.Text = "BS5767J2";
                textBox4.Text = "Memória Kingston Fury Beast 16GB (2x8GB)";
                textBox5.Text = "R$700,00";
                textBox6.Text = "12345678";
                textBox7.Text = "Roberto Silvério";
                textBox8.Text = "Pagamento Aprovado";
            }
            else if(string.IsNullOrEmpty(textBox2.Text))
            {
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                MessageBox.Show("Digite um Número de Pedido para ser pesquisado", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                MessageBox.Show("Pedido não encontrado!","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox8.Text == "Pagamento Aprovado")
            {
                DialogResult escolha = MessageBox.Show("Tem certeza que deseja liberar o produto para envio?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (escolha == DialogResult.Yes)
                {
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                    MessageBox.Show("PRODUTO LIBERADO", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(escolha == DialogResult.No)
                {
                    MessageBox.Show("PRODUTO NÃO LIBERADO!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Não foi inserido nenhum pedido para ser liberado!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(textBox8.Text == "Pagamento Não Aprovado" || textBox8.Text == "Pagamento Pendente")
            {
                MessageBox.Show("Não é possível liberar um produto que o pagamento não está aprovado!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(textBox2.Text)))
            {
                DialogResult escolha = MessageBox.Show("Tem certeza que deseja cancelar o pedido?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (escolha == DialogResult.Yes)
                {
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                    MessageBox.Show("Pedido cancelado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (escolha == DialogResult.No)
                {
                    MessageBox.Show("Pedido não cancelado!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Não foi inserido nenhum pedido para ser cancelado","ATENÇÃO",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
