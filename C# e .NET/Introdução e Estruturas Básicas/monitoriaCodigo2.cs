using System;

namespace Recode
{
    class MonitoriaCodigo2
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Condição While + If Ternário");

            Console.Write($"Digite um nº:");
            int num = int.Parse(Console.ReadLine());                // Converte a string recebida em um número do tipo inteiro.
            bool cond = (num % 2 == 0);                             // Condição booleana definida para especificar se o nº é par ou ímpar.

            while (num < 1000)                                      // Estrutura de Repetição While que limita até o número passar de 1000
            {
                int result = cond ? num += 5 : num *= 2;            // If ternário que aplica que analisa --> nº par = soma por 5 até chegar ou passar de 1000 
                Console.WriteLine($"Valor: {result}");              //                                   \--> nª ímpar = multiplica por 2 até chegar ou passar de 1000
            }

            Console.WriteLine($"Condição Switch...Case + For");

            Console.Write($"Digite um nº:");
            num = int.Parse(Console.ReadLine());

            switch (cond)
            {                                                       // Estrutura Condicional que recebe a análise de par ou impar e escolhe um dos casos abaixo
                case true:                                          // Caso True -> nº par = soma por 5 até chegar ou passar de 1000 
                    for (int i = num; i < 1000; i += 5)
                    {
                        Console.WriteLine($"Valor: {i}");
                    }
                    break;
                case false:
                    for (int i = num; i < 1000; i *= 2)             // Caso False -> nª ímpar = multiplica por 2 até chegar ou passar de 1000
                    {
                        Console.WriteLine($"Valor: {i}");
                    }
                    break;
            }
        }
    }
}