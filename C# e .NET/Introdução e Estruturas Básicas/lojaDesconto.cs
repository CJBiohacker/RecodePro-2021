using System;

namespace Recode
{
    class lojaDesconto
    {
        static void Main(string[] args)
        {
            string roupa;
            string ajusteNum = "0,0.00";
            int numRoupa = 0;
            int qtdRoupa = 0;
            decimal precoRoupa = 0.00m;
            decimal precoTotalRoupa = 0.00m;

            Console.WriteLine("Escolha uma peça de roupa: \n(1 -> Camisa , 2 -> Bermuda, 3 -> Calça e Qualquer -> Meia");
            numRoupa = int.Parse(Console.ReadLine());

            switch (numRoupa)
            {
                case 1:
                    roupa = "Camisa";
                    precoRoupa = 15.35m;
                    Console.Write($"Você selecionou um/uma {roupa}. Preço = R$ {precoRoupa}\n");
                    break;
                case 2:
                    roupa = "Bermuda";
                    precoRoupa = 20.45m;
                    Console.Write($"Você selecionou um/uma {roupa}. Preço = R$ {precoRoupa}\n");
                    break;
                case 3:
                    roupa = "Calça";
                    precoRoupa = 38.60m;
                    Console.Write($"Você selecionou um/uma {roupa}. Preço = R$ {precoRoupa}\n");
                    break;
                default:
                    roupa = "Par de meias";
                    precoRoupa = 7.60m;
                    Console.Write($"Você selecionou um/uma {roupa}. Preço = R$ {precoRoupa}\n");
                    break;
            }

            Console.WriteLine("Levando 5+ camisas, 4+ bermudas, 3+ calças ou 6+ meias. Você leva 15% de desconto no total.");
            Console.WriteLine("Escolha a quantidade desta peça.");
            qtdRoupa = Convert.ToInt16(Console.ReadLine());
            precoTotalRoupa = (qtdRoupa) * ((precoRoupa - (decimal.Multiply(precoRoupa, 0.15m))));

            if ((numRoupa == 1) && (qtdRoupa > 4))
            {
                Console.WriteLine($"Você comprou {qtdRoupa} peças de {roupa} com desconto. Preço Total = R$ {precoTotalRoupa.ToString(ajusteNum)}");
            }
            else if ((numRoupa == 2) && (qtdRoupa > 3))
            {
                Console.WriteLine($"Você comprou {qtdRoupa} peças de {roupa} com desconto. Preço Total = R$ {precoTotalRoupa.ToString(ajusteNum)}");
            }
            else if ((numRoupa == 3) && (qtdRoupa > 2))
            {
                Console.WriteLine($"Você comprou {qtdRoupa} peças de {roupa} com desconto. Preço Total = R$ {precoTotalRoupa.ToString(ajusteNum)}");
            }
            else if (((numRoupa != 1) || (numRoupa != 2) || (numRoupa != 3)) && (qtdRoupa > 5))
            {
                Console.WriteLine($"Você comprou {qtdRoupa} peças de {roupa} com desconto. Preço Total = R$ {precoTotalRoupa.ToString(ajusteNum)}");
            }
            else
            {
                precoTotalRoupa = qtdRoupa * precoRoupa;
                Console.WriteLine($"Você comprou {qtdRoupa} peças de {roupa} com desconto. Preço Total = R$ {precoTotalRoupa.ToString(ajusteNum)}");
            }

        }
    }
}
