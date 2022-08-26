using System;

class URI1078
{

    static void Main(string[] args)
    {

        int N, resultado;
        N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++) 
        {
            
            resultado = N*i;
            Console.WriteLine(i + "x" + N +" = " + resultado);
        }

        


    }

}