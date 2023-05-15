using System;
using System.Net;
namespace SimpleWebScraper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Nitesh", "Jaiswal", 22, 153, 153);
            Console.WriteLine(person1.FirstName + " " + person1.LastName);
            Person person3= new PersonBuilder().WithAge(15).Build();
            Console.WriteLine(person3.Age);
        }
    }
}