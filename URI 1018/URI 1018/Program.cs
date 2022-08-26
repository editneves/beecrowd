using System;

namespace uri1018
{
    class Program
    {
        static void Main(string[] args)
        {

            int ValorRS, Nota100, Nota50, Nota20, Nota10, Nota5, Nota2, Nota1, resto100, resto50, resto20, resto10, resto5, resto2, resto1;
            

            ValorRS = int.Parse(Console.ReadLine());

            Nota100 = ValorRS / 100;
            resto100 = ValorRS % 100;

            Nota50 = resto100 / 50;
            resto50= resto100 % 50;

            Nota20 = resto50 / 20;
            resto20 = resto50 % 20;

            Nota10 = resto20/ 10;
            resto10 = resto50 % 10;

            Nota5 = resto10/ 5;
            resto5 = resto10 % 5;

            Nota2 = resto5/ 2;
            resto2 = resto5 % 2;

            Nota1 = resto2;

            Console.WriteLine(ValorRS);
            Console.WriteLine(Nota100 + " nota(s) de R$ 100,00");
            Console.WriteLine(Nota50 + " nota(s) de R$ 50,00");
            Console.WriteLine(Nota20 + " nota(s) de R$ 20,00");
            Console.WriteLine(Nota10 + " nota(s) de R$ 10,00");
            Console.WriteLine(Nota5 + " nota(s) de R$ 5,00");
            Console.WriteLine(Nota2 + " nota(s) de R$ 2,00");
            Console.WriteLine(Nota1 + " nota(s) de R$ 1,00");


        }
    }
}