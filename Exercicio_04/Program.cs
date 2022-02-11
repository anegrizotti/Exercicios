using System;

namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] notas = new double[5];
            double media = 0;

            for (int i = 0; i < 5; i++)
            {
                int aux = i + 1;
                Console.Write("Digite a nota "+aux+": ");
                notas[i] = double.Parse(Console.ReadLine());
                media = media + notas[i];
            }

            media = media / 5;
            Console.WriteLine();
            Console.WriteLine("A média aritmética das 5 notas digitadas é: "+media);
            
        }
    }
}
