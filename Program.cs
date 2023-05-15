using System;
using System.Net;
using System.Numerics;

namespace SimpleWebScraper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Nitesh", "Jaiswal", 22, 153, 153);
            Console.WriteLine(person1.FirstName + " " + person1.LastName);
            Person person3= new PersonBuilder().WithAge(15).Build();
            int[][] jagged = new int[10][];
            jagged[0] = new int[90];
            jagged[0][75] = 1;
            int[,] matrix = new int[10, 10];
            matrix[0, 0] = 5;

            //jagged array are performative than the matrix
            Console.WriteLine(person3.FirstName);
        }
    }
}