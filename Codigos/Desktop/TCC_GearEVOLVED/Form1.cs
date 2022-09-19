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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*if (DAO_Conexao.getConexao("143.106.241.3", "cl201000", "cl201000", "cl*07071994"))
                Console.WriteLine("CONECTADO");
            else
                Console.WriteLine("ERRO NA CONEXÃO");*/
        }

        private void controleDoCadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 cadastroClientes = new Form2();
            cadastroClientes.Show();
        }

        private void controleDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 vendas = new Form3();
            vendas.Show();
        }

        private void controleDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 estoque = new Form7();
            estoque.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 pedidos = new Form4();
            pedidos.Show();
        }

        private void cadastroDeFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 funcionarios = new Form5();
            funcionarios.Show();
        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 produtos = new Form6();
            produtos.Show();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 sobre = new AboutBox1();
            sobre.Show();
        }

        private void menuInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
