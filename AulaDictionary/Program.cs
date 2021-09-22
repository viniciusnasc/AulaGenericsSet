using System;
using System.Collections.Generic;

namespace AulaDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "999999999";
            cookies["phone"] = "988888888"; // Sobescreve o primeiro valor, não pode ter mais de um valor com a mesma chave

            cookies.Remove("phone");

            cookies.ContainsKey("phone"); // Verifica com booleano se existe a chave informada

            Console.WriteLine(cookies.Count); // Informa a quantidade de itens

            // Imprimir todos
            foreach(KeyValuePair<string,string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
