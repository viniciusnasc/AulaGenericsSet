using ExercicioResolvidoConjuntos.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace ExercicioResolvidoConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(" ");
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new() { UserName = name, Instant = instant });
                    }
                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
