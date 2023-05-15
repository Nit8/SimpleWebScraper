using System;
using System.Net;
using System.Numerics;

namespace SimpleWebScraper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car ferrari =new Ferrari();  
            Car tata = new Tata();
            Person person = new Person(tata);
            person.Drive();

        }
    }
}