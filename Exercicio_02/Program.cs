using System;

namespace Exercicio_02
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
                    if(i % 2 == 0)
                    {
                        Console.Write("A");
                    } else
                    {
                        Console.Write("B");
                    }
                }
            }
        }
    }
}
