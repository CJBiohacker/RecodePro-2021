using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_e_dotNET.Classes_em_CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int ano, mes, dia = 0;

            Cliente carlos = new Cliente();

            carlos.setNome("Carlos");
            carlos.setSobrenome("Junior");
            carlos.setDataNasc("12/03/1990");
            var nome = carlos.getNome();
            var sobrenome = carlos.getSobrenome();
            var data = carlos.getDataNasc();

            System.Console.WriteLine($"{nome} {sobrenome}\n Data Nasc: {data}");
        }
    }
}