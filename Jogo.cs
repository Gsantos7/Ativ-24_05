using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração
           
            int limitemax;
            int limitemin;
            int oculto;
            int jogador;
            int palpite;
            int njogadores;

            //identificação

            Console.WriteLine("Digite a quantidade de jogadores: ");
            njogadores = int.Parse(Console.ReadLine());

            string[] nomes = new string[njogadores];

            for (int i = 0; i < njogadores; i++)
            {
                Console.WriteLine("Digite o nome do jogador {0}: ", i + 1);
                nomes[i] = Console.ReadLine();
            }

            //número oculto 

            Random random = new Random();
            oculto = random.Next(1, 100);

            Console.Clear();

            limitemax = 100;
            limitemin = 1;

            //palpite

            jogador = 0;

            do
            {
                jogador = (jogador + 1) % njogadores;
                if (jogador == 0)
                    jogador = njogadores;

                Console.WriteLine("{0}, digite um valor inteiro entre {1} e {2}", nomes[jogador - 1], limitemin, limitemax);
                palpite = int.Parse(Console.ReadLine());

                Console.Clear(); 

                if (palpite == oculto)
                    Console.WriteLine(" Parabéns {0}, você perdeu.", nomes[jogador - 1]);
                else if (palpite < limitemin || palpite > limitemax)
                {
                    do
                    {
                        Console.WriteLine("Digite um valor válido: ");
                        palpite = int.Parse(Console.ReadLine());
                    } while (palpite < limitemin || palpite > limitemax);

                    Console.Clear(); 
                }
                else if (palpite > oculto)
                    limitemax = palpite;
                else
                    limitemin = palpite;

            } while (palpite != oculto);
        }
    }
}
