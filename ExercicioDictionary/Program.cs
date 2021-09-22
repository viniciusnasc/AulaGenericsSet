using System;
using System.Collections.Generic;
using System.IO;

namespace ExercicioDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> members = new();

            Console.Write("Enter file full path: ");
            string file = Console.ReadLine();

            using (StreamReader sr = File.OpenText(file))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(",");
                    string nome = line[0];
                    int qtd = int.Parse(line[1]);

                    if (members.ContainsKey(nome))
                        members[nome] += qtd;

                    else
                        members[nome] = qtd;
                }
            }

            foreach (var item in members)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
