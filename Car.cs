using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebScraper
{
    abstract class Car
    {
        protected bool _on;
        public void TurnOnOff()
        {
            _on = !_on;
            Console.WriteLine(_on ? "The car is On!" : "The car is Off");
        }

        public abstract void Drive();
    }
}
