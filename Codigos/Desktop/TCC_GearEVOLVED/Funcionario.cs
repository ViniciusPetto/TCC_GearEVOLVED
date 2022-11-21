using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_GearEVOLVED
{
    internal class Funcionario
    {
        private string numFunc;
        private string nome;
        private string rua;
        private string numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string estado;
        private string CEP;
        private string CPF;
        private string dataNascimento;
        private string RG;
        private string dataAdmissao;


        private void setNumFunc(string numFunc)
        {
            this.numFunc = numFunc;
        }
        private string getNumFun()
        {
            return this.numFunc;
        }

        private void setDataAdmissao(string dataAdmissao)
        {
            this.dataAdmissao = dataAdmissao;
        }
        private string getDataAdmissao()
        {
            return dataAdmissao;
        }

        private void setNumero(string numero)
        {
            this.numero = numero;
        }

        private string getNumero()
        {
            return this.numero;
        }

        private void setComplemento(string complemento)
        {
            this.complemento = complemento;
        }
        private string getComplemento()
        {
            return this.complemento;
        }

        private void setNome(string nome)
        {
            this.nome = nome;
        }
        private string getNome()
        {
            return nome;
        }

        private void setDataNasc(string dataNascimento)
        {
            this.dataNascimento = dataNascimento;
        }
        private string getDataNasc()
        {
            return dataNascimento;
        }

        private void setCEP(string CEP)
        {
            this.CEP = CEP;
        }
        private string getCEP()
        {
            return CEP;
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

        private void setCPF(string CPF)
        {
            this.CPF = CPF;
        }
        private string getCPF()
        {
            return CPF;
        }

        private void setRG(string RG)
        {
            this.RG = RG;
        }
        private string getRG()
        {
            return RG;
        }



        public Funcionario(string numFunc, string nome, string rua, string numero, string complemento, string bairro, string cidade, string estado, string CEP, string CPF, string dataNascimento, string RG, string dataAdmissao)
        {
            setNumFunc(numFunc);
            setNome(nome);
            setRua(rua);
            setNumero(numero);
            setComplemento(complemento);
            setBairro(bairro);
            setCidade(cidade);
            setEstado(estado);
            setCEP(CEP);
            setCPF(CPF);
            setDataNasc(dataNascimento);
            setRG(RG);
            setDataAdmissao(dataAdmissao);
        }

        public Funcionario(string numFunc)
        {
            setNumFunc(numFunc);
        }

        public bool cadastraFuncionario()
        {
                bool cad = false;
                try
                {
                    DAO_Conexao.con.Open();
                    MySqlCommand insere = new MySqlCommand("insert into Funcionario (numFunc, nome, rua, numero, complemento, bairro, cidade, estado, CEP, CPF, dataNascimento, RG, dataAdmissao) values ('" + numFunc + "','" + nome + "','" + rua + "','" + numero + "','" + complemento + "','" + bairro + "','" + cidade + "','" + estado + "','" + CEP + "','" + CPF + "','" + dataNascimento + "','" + RG + "','" + dataAdmissao + "')", DAO_Conexao.con);
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
    }
}
