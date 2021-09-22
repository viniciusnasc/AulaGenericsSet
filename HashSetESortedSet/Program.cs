using HashSetESortedSet.Entities;
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



            HashSet<string> set2 = new();
            set2.Add("Maria");
            set2.Add("Alex");

            set2.Contains("Maria"); // O contains teste pelo GetHashCode e após testar, testa com o Equals, e retorna booleano, caso o tipo tenha a implementação desses dois

            HashSet<Product> produto = new();
            produto.Add(new("TV", 900));
            produto.Add(new("Notebook", 1200));

            HashSet<Point> point = new();
            point.Add(new(3, 4));
            point.Add(new(5, 10));

            Product prod = new("Notebook", 1200);
            produto.Contains(prod); // Retorna falso, pois como GetHashCode e Equals nao estao implantados em Product, ele esta comparando os espaços em memoria

            Point ponto = new(5, 10);
            point.Contains(ponto); // Retorna true, diferente da classe, por ser struct, ele nao compara por referencia de memoria
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
