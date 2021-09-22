using System;
using System.Collections.Generic;

namespace AulaGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> pS = new();

            Console.Write("How Many values?");
            int numValues = int.Parse(Console.ReadLine());

            for(int i = 0; i<numValues; i++)
            {
                pS.AddValue(int.Parse(Console.ReadLine()));
            }

            pS.Print();
            Console.WriteLine("First: " + pS.First());
        }
    }
}
