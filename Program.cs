using System;
using System.Net;
using System.Numerics;

namespace SimpleWebScraper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hobbie[] hobbies = { new Hobbie(1, "WALKING"), new Hobbie(2, "RUNNING"), new Hobbie(3, "GYM") };
            var hobbie = hobbies.Where(h => h.Name.Equals("Walking"));
            var hobbiewithidgreaterthan1 = hobbies.Where(h => h.Id>1);
            var anotherHobbie=from h in hobbies where h.Name.Equals("Walking") select h.Name;
            Console.WriteLine(anotherHobbie);
        }
    }
    class Hobbie
    {
        public Hobbie(int id,string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; private set; }
        public string Name { get; private set; }
    }
}