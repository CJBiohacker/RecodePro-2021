using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_e_dotNET.Classes_em_CSharp
{
    protected class Endereco
    {
        private string rua;
        private int num;
        private string bairro;
        private string cidade;
        private int cep;

        // Métodos Set e Get para o nome da Rua
        protected void setRua(string rua)
        {
            this.rua = rua;
        }

        protected string getRua()
        {
            return this.rua;
        }

        // Métodos Set e Get para Número da rua
        protected void setNum(int num)
        {
            this.num = num;
        }

        protected int getNum()
        {
            return this.num;
        }

        // Métodos Set e Get para o nome do Bairro
        protected void setBairro(string bairro)
        {
            this.bairro = bairro;
        }

        protected string getBairro()
        {
            return this.bairro;
        }

        // Métodos Set e Get para o nome da Cidade
        protected void setCidade(string cidade)
        {
            this.cidade = cidade;
        }

        protected string getCidade()
        {
            return this.cidade;
        }

        // Métodos Set e Get para o número do CEP
        protected void setCep(int cep)
        {
            this.cep = cep;
        }

        protected int getCep()
        {
            return this.cep;
        }

    }
}