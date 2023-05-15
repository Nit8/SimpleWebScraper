using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebScraper
{
    internal class Tata : ICar
    {
        private bool _on;
        public void TurnOnOff()
        {
            _on = !_on;
            Console.WriteLine(_on ? "The Tata is On!" : "The Tata is Off");
        }
        public void Drive()
        {
            if (_on)
            {
                Console.WriteLine("Drive Tata");
            }
            else
            {
                Console.WriteLine("Have to Start Tata First");
            }
        }
    }
}
