using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebScraper
{
    internal class Person
    {
        private Car _car;
        public Person(Car car)
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
