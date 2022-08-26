using System;

class URI1071
{

    static void Main(string[] args)
    {

        int x, y, min,max, soma;
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        if (x < y)
        {
            min = x;
            max = y;
            //Console.WriteLine(min + " " + max);
        }
        else { 
            min = y;
            max = x;
            //Console.WriteLine(min + " " + max);
        }
        soma = 0;
        for (int i = min + 1; i < max; i++)
            if (i % 2 != 0)
                soma = soma + i;

        Console.WriteLine(soma);
    }

}