using System;

namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Largura: ");
            int largura = int.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            int altura = int.Parse(Console.ReadLine());


            for (int i = 0; i < altura; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < largura; j++)
                {
                    Console.Write("*");
                }
            }

        }
    }
}
