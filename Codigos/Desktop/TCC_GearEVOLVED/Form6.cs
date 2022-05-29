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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Preencha o campo 'Código' antes de prosseguir!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Preencha o campo 'Modelo' antes de prosseguir!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Preencha o campo 'Preço Unitário' antes de prosseguir!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Preencha o campo 'Nome' antes de prosseguir!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Preencha o campo 'Marca' antes de prosseguir!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Preencha o campo 'Descrição' antes de prosseguir!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult escolha = MessageBox.Show("Tem certeza que deseja cadastrar esse produto?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (escolha == DialogResult.Yes)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    MessageBox.Show("Produto cadastrado com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Produto não cadastrado!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Não há dados a serem apagados", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult escolha = MessageBox.Show("Tem certeza que deseja apagar os dados escritos?", "ATENÇÂO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (escolha == DialogResult.Yes)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    MessageBox.Show("Os dados foram apagados!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Os dados não serão apagados", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
