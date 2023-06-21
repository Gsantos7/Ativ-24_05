using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_05_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadevalores = 10;
            int[] valores = new int[quantidadevalores];
            int soma = 0;

            // valores
            for (int i = 0; i < quantidadevalores; i++)
            {
                Console.Write("Digite o valor {0}: ", i + 1);
                valores[i] = int.Parse(Console.ReadLine());
                soma += valores[i];
            }

            // média
            double media = soma / quantidadevalores;

            // valores maiores que a média
            int valoresmaioresqueamedia = 0;
            for (int i = 0; i < quantidadevalores; i++)
            {
                if (valores[i] > media)
                {
                    valoresmaioresqueamedia++;
                }
            }

            Console.WriteLine("Média:{0} ", media);
            Console.WriteLine("Quantidade de valores maiores que a média: {0} ", valoresmaioresqueamedia);

        }
    }
}
