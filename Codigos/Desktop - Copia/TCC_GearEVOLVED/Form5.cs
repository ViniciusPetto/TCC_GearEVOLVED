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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Preencha o campo 'Número de Registro' antes de prosseguir!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Preencha o campo 'Nome' antes de prosseguir!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Preencha o campo 'Data de Nascimento' antes de prosseguir!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Preencha o campo 'Rua' antes de prosseguir!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Preencha o campo 'Bairro' antes de prosseguir!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Preencha o campo 'Cidade' antes de prosseguir!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Preencha o campo 'Estado' antes de prosseguir!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(textBox8.Text))
            {
                MessageBox.Show("Preencha o campo 'CEP' antes de prosseguir!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(textBox9.Text))
            {
                MessageBox.Show("Preencha o campo 'Salário' antes de prosseguir!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(textBox10.Text))
            {
                MessageBox.Show("Preencha o campo 'CPF' antes de prosseguir!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(textBox11.Text))
            {
                MessageBox.Show("Preencha o campo 'RG' antes de prosseguir!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(textBox12.Text))
            {
                MessageBox.Show("Preencha o campo 'Data de Admissão' antes de prosseguir!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(textBox13.Text))
            {
                MessageBox.Show("Preencha o campo 'Carteira de Trabalho' antes de prosseguir!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(textBox14.Text))
            {
                MessageBox.Show("Preencha o campo 'Setor' antes de prosseguir!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(textBox15.Text))
            {
                MessageBox.Show("Preencha o campo 'Telefone' antes de prosseguir!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult escolha = MessageBox.Show("Tem certeza que deseja cadastrar esse funcionário?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (escolha == DialogResult.Yes)
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
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
                else
                {
                    MessageBox.Show("Funcionário não cadastrado!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text) && string.IsNullOrEmpty(textBox2.Text) && string.IsNullOrEmpty(textBox3.Text) && string.IsNullOrEmpty(textBox4.Text) && string.IsNullOrEmpty(textBox5.Text) && string.IsNullOrEmpty(textBox6.Text) && string.IsNullOrEmpty(textBox7.Text) && string.IsNullOrEmpty(textBox8.Text) && string.IsNullOrEmpty(textBox9.Text) && string.IsNullOrEmpty(textBox10.Text) && string.IsNullOrEmpty(textBox11.Text) && string.IsNullOrEmpty(textBox12.Text) && string.IsNullOrEmpty(textBox13.Text) && string.IsNullOrEmpty(textBox14.Text) && string.IsNullOrEmpty(textBox15.Text))
            {
                MessageBox.Show("Não há dados a serem apagados!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    textBox7.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox10.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    MessageBox.Show("Os dados foram apagados!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Os dados não serão apagados!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
