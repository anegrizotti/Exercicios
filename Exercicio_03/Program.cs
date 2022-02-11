using System;

namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hora atual: ");
            double horaAtual = double.Parse(Console.ReadLine());

            if (horaAtual <= 12)
            {
                Console.WriteLine("Bom dia!");
            } else if (horaAtual > 12 && horaAtual <= 18)
            {
                Console.WriteLine("Boa tarde!");
            } else if (horaAtual > 18)
            {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}
