using System;

namespace Teste
{
    class Hello
    {
        static void Main(string[] args)
        {
            int num = 2;
            int total = 0;

            Console.WriteLine("Olá Mundo");

            for (int i = 0; i < 10; i++)
            {
                total = num + i;
                Console.WriteLine($"Contagem de nº: {num} + {i} = {total}");
            }

            if (total > 10)
            {
                Console.WriteLine($"Total = {total} > 10");
            }
            else
            {
                Console.WriteLine($"Total = {total} < 10");
            }

            string escolha;
            escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Console.WriteLine("Parabéns, você escolhe um Guerreiro.");
                    break;
                case "2":
                    Console.WriteLine("Parabéns, você escolhe um Mago.");
                    break;
                default:
                    Console.WriteLine("Sua classe não existe.");
                    break;
            }

            string cond;
            cond = Console.ReadLine();

            switch (cond)
            {
                case "1":
                    Console.WriteLine("Parabéns, você escolhe um Ladino.");
                    break;
                case "2":
                    Console.WriteLine("Parabéns, você escolhe um Caçador.");
                    break;
                default:
                    Console.WriteLine("Sua classe não existe.");
                    break;
            }
        }
    }
}