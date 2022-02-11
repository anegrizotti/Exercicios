using System;

namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int vitoriasJogadorUm = 0, vitoriasJogadorDois = 0, aux = 0;


            Console.Write("Jogador 1: ");
            string jogadorUm = Console.ReadLine();

            Console.Write("Jogador 2: ");
            string jogadorDois = Console.ReadLine();

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                aux = aux + 1;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Rodada " + aux);
                Console.ResetColor();
                int dadoUm = Convert.ToInt32(random.Next(0, 6).ToString());
                int dadoDois = Convert.ToInt32(random.Next(0, 6).ToString());

                Console.WriteLine("Jogador 1: " + dadoUm);
                Console.WriteLine("Jogador 2: " + dadoDois);

                if (dadoUm > dadoDois)
                {
                    Console.WriteLine("O jogador " + jogadorUm + " tirou " + dadoUm + " e venceu a rodada "+i+"!");
                    vitoriasJogadorUm++;    
                } else if (dadoDois > dadoUm)
                {
                    Console.WriteLine("O jogador " + jogadorDois + " tirou " + dadoDois + " e venceu a rodada " + i + "!");
                    vitoriasJogadorDois++;
                } else if (dadoUm == dadoDois)
                {
                    Console.WriteLine("Houve um empate na rodada "+i+"!");
                }

                Console.WriteLine();

            }

            if (vitoriasJogadorUm > vitoriasJogadorDois)
            {
                Console.WriteLine(jogadorUm+" é o vencedor da partida.");
            } else if (vitoriasJogadorDois > vitoriasJogadorUm)
            {
                Console.WriteLine(jogadorDois + " é o vencedor da partida.");
            } else if (vitoriasJogadorUm == vitoriasJogadorDois)
            {
                Console.WriteLine("Houve um empate.");
            }

        }    
    }
}
