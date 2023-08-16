using System;
using System.Globalization;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite um múmero inteiro");
        int numero = int.Parse(Console.ReadLine());

        if (numero >= 0)
        {
            Console.WriteLine("NÃO NEGATIVO");
        }

        else 
        {
            Console.WriteLine("NEGATIVO");
        }
    }
}