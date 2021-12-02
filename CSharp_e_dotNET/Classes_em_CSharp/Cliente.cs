using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_e_dotNET.Classes_em_CSharp
{
    public class Cliente
    {
        private string nome;
        private string sobrenome;
        private DateTime dataNasc;        // Ao integrar o banco de dados, utilizar a classe/tipo Date do próprio C#. SINTAXE -> Datetime(YYYY, D, M, H, M, S);
        private int cpf;

        // Métodos Set e Get para o Nome do cliente.
        protected void setNome(string nome)
        {
            this.nome = nome;
        }

        protected string getNome()
        {
            return this.nome;
        }

        // Métodos Set e Get para o Sobrenome.
        protected string setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }

        protected void getSobrenome()
        {
            return this.sobrenome;
        }

        // Métodos de Set e Get para a Data de Nascimento
        protected DateTime setDataNasc(DateTime dataNasc)
        {
            this.dataNasc = dataNasc;
        }

        protected void getDataNasc()
        {
            return this.dataNasc;
        }

        // Métodos de Set e Get do nº de CPF do Cliente
        protected int setCPF(int cpf)
        {
            return this.cpf = cpf;
        }

        protected void getCPF()
        {

        }

    }
}