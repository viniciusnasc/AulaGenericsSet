using System;
using System.Collections.Generic;

namespace HashSetESortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new();

            set.Add("Tv");
            set.Add("NoteBook");
            set.Add("Tablet");

            set.Contains("Notebook"); // Retorna booleano, no caso, true
            set.Contains("Computer"); // Retorna falso

            SortedSet<int> a = new() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new() { 5, 6, 7, 8, 9, 10 };

            // Union
            SortedSet<int> c = new(a);
            c.UnionWith(b); // Inclui em c todos elementos do b que nao existem em c

            // Intersection
            SortedSet<int> d = new(a);
            d.IntersectWith(b); // Altera d para que os elementos contido nele sejam somente os que estão presentes em b

            // Difference
            SortedSet<int> e = new(a);
            e.ExceptWith(b); // Altera e para que exclua os elementos que existem em b

            PrintCollection(a);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        { 
        foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
