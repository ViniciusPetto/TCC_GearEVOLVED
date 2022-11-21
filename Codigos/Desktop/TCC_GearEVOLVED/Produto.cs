using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_GearEVOLVED
{
    internal class Produto
    {
        //ATRIBUTOS
        private int codigo;
        private string modelo;
        private string nome;
        private string marca;
        private float preco;
        private string descricao;


        //GETTERS E SETTERS
        private void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        private int getCodigo()
        {
            return codigo;
        }

        private void setModelo(string modelo)
        {
            this.modelo = modelo;
        }
        private string getModelo()
        {
            return modelo;
        }

        private void setNome(string nome)
        {
            this.nome = nome;
        }
        private string getNome()
        {
            return nome;
        }

        private void setMarca(string marca)
        {
            this.marca = marca;
        }
        private string getMarca()
        {
            return marca;
        }

        private void setPreco(float preco)
        {
            this.preco = preco;
        }
        private float getPreco()
        {
            return preco;
        }

        private void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }
        private string getDescricao()
        {
            return descricao;
        }

        public Produto(int codigo, string modelo, string nome, string marca, float preco, string descricao)
        {
            setCodigo(codigo);
            setModelo(modelo);
            setNome(nome);
            setMarca(marca);
            setPreco(preco);
            setDescricao(descricao);
        }

        public Produto(int codigo)
        {
            setCodigo(codigo);
        }

        public bool cadastrarProduto()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Produto (codigo, modelo, nome, marca, preco, descricao) values ('" + codigo + "','" + modelo + "','" + nome + "','" + marca + "','" + preco + "','" + descricao + "')", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }


        public MySqlDataReader pesquisaProduto()
        {
            MySqlDataReader pesquisa = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Estoque where codProd = '" + codigo + "'", DAO_Conexao.con);
                pesquisa = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return pesquisa;
        }
    }
}
