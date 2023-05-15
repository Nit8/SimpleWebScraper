using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebScraper
{
    internal class Tata : Car
    {

        public override void Drive()
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
