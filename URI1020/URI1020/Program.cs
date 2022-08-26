using System;

namespace uri1020
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade, restoAnos, restoMeses, anos, meses, dias;


            idade = int.Parse(Console.ReadLine());

            anos = idade / 365;
            restoAnos = idade % 365;

            meses = restoAnos / 30;
            restoMeses = restoAnos % 30;

            dias = restoMeses;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
           


        }
    }
}