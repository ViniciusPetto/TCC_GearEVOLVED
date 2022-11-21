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
            Cliente cl = new Cliente(int.Parse(textBox2.Text));
            if (cl.pesquisarCliente())
            {
                MessageBox.Show("Cliente Encontrado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MySqlDataReader r = cl.pesquisaClienteUpdate();
                if (r.Read())
                {
                    textBox2.Text = r["NR"].ToString();
                    textBox3.Text = r["nome"].ToString();
                    textBox4.Text = r["dataNascimento"].ToString();
                    textBox5.Text = r["email"].ToString();
                    textBox6.Text = r["cep"].ToString();
                    textBox7.Text = r["rua"].ToString();
                    textBox8.Text = r["bairro"].ToString();
                    textBox9.Text = r["cidade"].ToString();
                    textBox10.Text = r["estado"].ToString();
                    textBox11.Text = r["CPF"].ToString();
                    textBox12.Text = r["RG"].ToString();
                    textBox13.Text = r["telefone1"].ToString();
                    //textBox14.Text = r[""].ToString();
                    //textBox15.Text = r[""].ToString();
                }
                else
                {
                    MessageBox.Show("Não foram encontrados dados do cliente especificado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Clear();
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
                }
                DAO_Conexao.con.Close();
            }
            else
            {
                MessageBox.Show("Cliente não cadastrado no sistema!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Clear();
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
            }
        }
    }
}
