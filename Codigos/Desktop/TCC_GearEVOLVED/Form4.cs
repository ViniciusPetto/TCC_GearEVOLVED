using MySql.Data.MySqlClient;
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
            Pedido p1 = new Pedido(int.Parse(textBox2.Text));
            if (p1.pesquisarPedido())
            {
                MessageBox.Show("Pedido Encontrado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MySqlDataReader r = p1.pesquisaPedidoUpdate();
                if (r.Read())
                {
                    textBox2.Text = r["numPedido"].ToString();
                    textBox3.Text = r["codProd"].ToString();
                    textBox4.Text = r["descricao"].ToString();
                    textBox5.Text = r["valorTotal"].ToString();
                    textBox6.Text = r["NRCli"].ToString();
                    textBox7.Text = r["nomeCli"].ToString();
                    textBox8.Text = r["situacaoPagamento"].ToString();
                }
                else
                {
                    MessageBox.Show("Não foram encontrados dados do pedido especificado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                }
                DAO_Conexao.con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pedido p1 = new Pedido(int.Parse(textBox2.Text));
            if (!(string.IsNullOrEmpty(textBox2.Text)))
            {
                DialogResult escolha = MessageBox.Show("Tem certeza que deseja liberar o produto para envio?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (escolha == DialogResult.Yes)
                {
                    if (p1.liberacaoPedido())
                    {
                        MessageBox.Show("Produto liberado!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
                        textBox8.Clear();
                    }
                }
                else if (escolha == DialogResult.No)
                {
                    MessageBox.Show("Produto não liberado!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (textBox8.Text != "aprovado")
                {
                    MessageBox.Show("Não é possível liberar um produto que o pagamento não está aprovado!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Não foi inserido nenhum pedido para ser cancelado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pedido p1 = new Pedido(int.Parse(textBox2.Text));
            if (!(string.IsNullOrEmpty(textBox2.Text)))
            {
                DialogResult escolha = MessageBox.Show("Tem certeza que deseja cancelar o pedido ou mantê-lo sem liberação?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (escolha == DialogResult.Yes)
                {
                    if (p1.naoLiberacaoPedido())
                    {
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
                        textBox8.Clear();
                        MessageBox.Show("Pedido cancelado/Sem liberação!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (escolha == DialogResult.No)
                {
                    MessageBox.Show("Pedido não cancelado!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Não foi inserido nenhum pedido para ser cancelado!","ATENÇÃO",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}