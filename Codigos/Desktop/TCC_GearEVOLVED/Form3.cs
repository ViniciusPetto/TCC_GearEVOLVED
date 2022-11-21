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
            Pedido pe = new Pedido(int.Parse(textBox2.Text));
            if (pe.pesquisarPedido())
            {
                MessageBox.Show("Pedido Encontrado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MySqlDataReader r = pe.pesquisaPedidoUpdate();
                if (r.Read())
                {
                    textBox2.Text = r["numPedido"].ToString();
                    textBox3.Text = r["nomeCli"].ToString();
                    textBox4.Text = r["precoUnitario"].ToString();
                    textBox5.Text = r["codProd"].ToString();
                    textBox6.Text = r["descricao"].ToString();
                    textBox7.Text = r["quantidade"].ToString();
                    textBox8.Text = r["valorTotal"].ToString();
                    textBox1.Text = r["situacaoPagamento"].ToString();
                }
                else
                {
                    MessageBox.Show("Não foram encontrados dados do pedido especificado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
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
            else
            {
                MessageBox.Show("Pedido não efetuado no sistema!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
            }
        }
    }
}
