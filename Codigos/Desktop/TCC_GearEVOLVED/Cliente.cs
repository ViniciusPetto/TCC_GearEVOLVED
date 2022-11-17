using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_GearEVOLVED
{
    internal class Cliente
    {
        //ATRIBUTOS
        private int NR;
        private string nome;
        private string dataNascimento;
        private string email;
        private string CEP;
        private string rua;
        private string bairro;
        private string cidade;
        private string estado;
        private string CPF;
        private string RG;
        private string telefone;
        private string pagamentos;
        private string historicoPag;


        //GETTERS E SETTERS
        private void setNR(int NR)
        {
            this.NR = NR;
        }
        private int getNR()
        {
            return NR;
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

        private void setEmail(string email)
        {
            this.email = email;
        }
        private string getEmail()
        {
            return email;
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

        private void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        private string getTelefone()
        {
            return telefone;
        }

        private void setPagamento(string pagamento)
        {
            this.pagamentos = pagamento;
        }
        private string getPagamento()
        {
            return pagamentos;
        }

        private void setHistoricoPag(string historicoPag)
        {
            this.historicoPag = historicoPag;
        }
        private string getHistoricoPag()
        {
            return historicoPag;
        }




    }
}
