using GetHashCode.Entities;
using System;

namespace GetHashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new() {Name = "Maria", Email = "maria@gmail.com" };
            Client b = new() {Name = "Alex", Email = "maria@gmail.com" };

            Console.WriteLine(a.Equals(b)); // Retorna verdadeiro, devido o Equals estar configurado para verificar o e-mail
        }
    }
}
