using RestricoesGenerics.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace RestricoesGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(",");
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name,price));
            }

            CalculationService cS = new();

            Product max = cS.Max(list);

            Console.WriteLine("Max:");
            Console.WriteLine(max);
        }
    }
}
