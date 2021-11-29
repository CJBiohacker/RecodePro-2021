using System;

namespace Recode
{
    class tabuada
    {
        static void Main(string[] args)
        {
            int numTabuada = 0;
            int i = 0;

            Console.WriteLine("Caso For\nSelecione o número da Tabuada:");
            numTabuada = int.Parse(Console.ReadLine());             // Usar o método int.Parse() que converte string para int. Tudo que entra pelo Console.ReadLine(), é dado como string.

            for (i = 0; i <= 10; i++)
            {
                int resultado = i * numTabuada;
                Console.WriteLine("{0} x {1} = {2}", numTabuada, i, resultado);     // Exemplo de Interpolação de Cadeira de Caracteres (Valores) por posição.
            }

            i = 0; // Resetando o valor do contador 'i' para 0.

            Console.WriteLine("Caso While\nSelecione o novo número da Tabuada:");
            numTabuada = int.Parse(Console.ReadLine());

            while (i <= 10)
            {
                int resultado = i * numTabuada;
                Console.WriteLine($"{numTabuada} x {i} = {resultado}");     // Exemplo de Interpolação de Cadeira de Caractere (Valores) chamando variáveis
                i++;
            }

            i = 0; // Resetando o valor do contador 'i' para 0.

            Console.WriteLine("Caso Do...While\nSelecione o novo número da Tabuada:");
            numTabuada = int.Parse(Console.ReadLine());

            do
            {
                int resultado = i * numTabuada;
                Console.WriteLine($"{numTabuada} x {i} = {resultado}");
                i++;
            } while (i <= 10);
        }
    }
}