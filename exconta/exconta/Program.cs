
using System;
using System.Globalization;

namespace ExConta
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine());

            conta = 50.00;
            if (minutos > 100) {
                conta = conta + (minutos - 100) * 2.0; 
            }
            Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
