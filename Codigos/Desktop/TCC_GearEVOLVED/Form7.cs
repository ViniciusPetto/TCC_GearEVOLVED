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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
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
                MessageBox.Show("Digite um Código de Produto para ser pesquisado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Produto p1 = new Produto(int.Parse(textBox1.Text));
                if (p1.pesquisaProduto() != null)
                {
                    MySqlDataReader r = p1.pesquisaProduto();
                    MessageBox.Show("Produto Encontrado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (r.Read())
                    {
                        textBox1.Text = r["codProd"].ToString();
                        textBox2.Text = r["modelo"].ToString();
                        textBox3.Text = r["nome"].ToString();
                        textBox4.Text = r["marca"].ToString();
                        textBox5.Text = r["descricao"].ToString();
                        textBox6.Text = r["dataEntrada"].ToString();
                        textBox7.Text = r["horaEntrada"].ToString();
                        textBox8.Text = r["dataSaida"].ToString();
                        textBox9.Text = r["horaSaida"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Não foram encontrados dados do produto especificado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
                        textBox8.Clear();
                        textBox9.Clear();
                    }
                    DAO_Conexao.con.Close();
                }
                else
                {
                    MessageBox.Show("Produto sem estoque no sistema!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
