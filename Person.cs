using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebScraper
{
    internal class Person
    {
        private ICar _car;
        public Person(ICar car)
        {
            _car = car;
        }
        public void Drive()
        {
            _car.TurnOnOff();
            _car.Drive();
        }
    }
}
