using System;
using System.Collections.Generic;

namespace ExercicioPropostoConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> setA = new();
            HashSet<int> setB = new();
            HashSet<int> setC = new();
            HashSet<int> totalAlunos = new();

            Console.Write("How many students for curse A? ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
                setA.Add(int.Parse(Console.ReadLine()));

            Console.Write("How many students for curse B? ");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
                setB.Add(int.Parse(Console.ReadLine()));

            Console.Write("How many students for curse C? ");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
                setC.Add(int.Parse(Console.ReadLine()));

            totalAlunos = setA;
            totalAlunos.UnionWith(setB);
            totalAlunos.UnionWith(setC);

            Console.WriteLine($"Total students: {totalAlunos.Count}");
        }
    }
}
