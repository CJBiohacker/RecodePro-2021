using System;

namespace Recode
{
    class MonitoriaCodigo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Digite um texto:");

            string text = Console.ReadLine();
            int qtdNum = 0;
            int qtdChar = 0;
            Console.WriteLine($"Extensão do texto: {text.Length}");

            for (int i = 0; i < text.Length; i++)
            {
                char newChar = text[i];

                for (int j = 48; j <= 57; j++)
                {
                    char num = (char)j;

                    if (newChar == num)
                    {
                        qtdNum++;
                    }
                }

                for (int k = 65; k <= 122; k++)
                {
                    char letra = (char)k;

                    if (newChar == letra)
                    {
                        qtdChar++;
                    }
                }
            }

            Console.WriteLine($"Quantidade de número no texto: {+qtdNum}");
            Console.WriteLine($"Quantidade de letras no texto: {+qtdChar}");
        }
    }
}