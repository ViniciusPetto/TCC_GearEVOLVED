using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_GearEVOLVED
{
    internal class Pedido
    {
        //ATRIBUTOS
        private int numPedido;
        private int codProd;
        private string nomeCli;
        private int NF;
        private int NRCli;
        private float precoUnitario;
        private int quantidade;
        private float valorTotal;
        private string situacaoPag;
        private int IDadm;
        private string descricao;
        private string rua;
        private string numero;
        private string bairro;
        private string complemento;
        private string cidade;
        private string estado;
        private string CEP;


        //GETTERS E SETTERS
        private void setNumPedido(int numPedido)
        {
            this.numPedido = numPedido;
        }
        private int getNumPedido()
        {
            return numPedido;
        }

        private void setNRCli(int NRCli)
        {
            this.NRCli = NRCli;
        }
        private int getNRCli()
        {
            return NRCli;
        }

        private void setCodProd(int codProd)
        {
            this.codProd = codProd;
        }
        private int getCodProd()
        {
            return codProd;
        }

        private void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }
        private string getDescricao()
        {
            return descricao;
        }

        private void setNomeCli(string nomeCli)
        {
            this.nomeCli = nomeCli;
        }
        private string getNomeCli()
        {
            return nomeCli;
        }

        private void setNF(int NF)
        {
            this.NF = NF;
        }
        private int getNF()
        {
            return NF;
        }

        private void setCEP(string CEP)
        {
            this.CEP = CEP;
        }
        private string getCEP()
        {
            return CEP;
        }

        private void setNumero(string numero)
        {
            this.numero = numero;
        }
        private string getNumero()
        {
            return numero;
        }

        private void setRua(string rua)
        {
            this.rua = rua;
        }
        private string getRua()
        {
            return rua;
        }

        private void setBairro(string bairro)
        {
            this.bairro = bairro;
        }
        private string getBairro()
        {
            return bairro;
        }

        private void setComplemento(string complemento)
        {
            this.complemento = complemento;
        }
        private string getComplemento()
        {
            return complemento;
        }

        private void setCidade(string cidade)
        {
            this.cidade = cidade;
        }
        private string getCidade()
        {
            return cidade;
        }

        private void setEstado(string estado)
        {
            this.estado = estado;
        }
        private string getEtado()
        {
            return estado;
        }

        private void setPrecoUnitario(float precoUnitario)
        {
            this.precoUnitario = precoUnitario;
        }
        private float getPrecoUnitario()
        {
            return precoUnitario;
        }

        private void setQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }
        private int getQuantidade()
        {
            return quantidade;
        }

        private void setValorTotal(float valorTotal)
        {
            this.valorTotal = valorTotal;
        }
        private float getTelefone()
        {
            return valorTotal;
        }

        private void setSituacaoPag(string situacaoPag)
        {
            this.situacaoPag = situacaoPag;
        }
        private string getSituacaoPag()
        {
            return situacaoPag;
        }

        private void setIDadm(int IDadm)
        {
            this.IDadm = IDadm;
        }
        private int getIDadm()
        {
            return IDadm;
        }


        public Pedido(int numPedido, int codProd, string nomeCli, int NF, int NRCli, float precoUnitario, int quantidade, float valorTotal, string situacaoPag, int IDadm, string descricao, string rua, string numero, string bairro, string complemento, string cidade, string estado, string CEP)
        {
            setNumPedido(numPedido);
            setCodProd(codProd);
            setNomeCli(nomeCli);
            setNF(NF);
            setNRCli(NRCli);
            setPrecoUnitario(precoUnitario);
            setQuantidade(quantidade); 
            setValorTotal(valorTotal);
            setDescricao(descricao);
            setRua(rua);
            setNumero(numero);
            setBairro(bairro);
            setComplemento(complemento);
            setSituacaoPag(situacaoPag);
            setIDadm(IDadm);
            setCidade(cidade);
            setCEP(CEP);
            setEstado(estado);
        }


        public Pedido(int numPedido)
        {
            setNumPedido(numPedido);
        }


        public bool pesquisarPedido()
        {
            bool consulta = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand pesquisa = new MySqlCommand("select * from Pedido where numPedido = '" + numPedido + "'", DAO_Conexao.con);
                MySqlDataReader resultado = pesquisa.ExecuteReader();

                if (resultado.Read())
                    consulta = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return consulta;
        }


        public MySqlDataReader pesquisaPedidoUpdate()
        {
            MySqlDataReader pesquisa = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Pedido where numPedido = '" + numPedido + "'", DAO_Conexao.con);
                pesquisa = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return pesquisa;
        }

        public bool liberacaoPedido()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Pedido set liberacao = 1 where numPedido = '" + numPedido + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }

        public bool naoLiberacaoPedido()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Pedido set liberacao = 0 where numPedido = '" + numPedido + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }
    }
}
