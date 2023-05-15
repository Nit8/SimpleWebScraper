using System;
using System.Net;
using System.Numerics;

namespace SimpleWebScraper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ferrari ferrari =new Ferrari();  
            Tata tata = new Tata();
            Person person = new Person(tata);
            person.Drive();

        }
    }
}