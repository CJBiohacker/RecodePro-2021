using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_e_dotNET.Classes_em_CSharp
{
    class Cliente
    {
        private string nome = "";
        private string sobrenome = "";
        private string dataNasc = "";        // Ao integrar o banco de dados, utilizar a classe/tipo Date do próprio C#. SINTAXE -> Datetime(YYYY, D, M, H, M, S);
        private int cpf = 0;

        // Métodos Set e Get para o Nome do cliente.
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        // Métodos Set e Get para o Sobrenome.
        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }

        public string getSobrenome()
        {
            return this.sobrenome;
        }

        // Métodos de Set e Get para a Data de Nascimento
        public void setDataNasc(string dataNasc)
        {
            this.dataNasc = dataNasc;
        }

        public string getDataNasc()
        {
            return this.dataNasc;
        }

        // Métodos de Set e Get do nº de CPF do Cliente
        public void setCPF(int cpf)
        {
            this.cpf = cpf;
        }

        public int getCPF()
        {
            return this.cpf;
        }

    }
}