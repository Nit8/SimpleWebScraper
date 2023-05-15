using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebScraper
{
    //creates a layer of abbstraction
    internal interface ICar
    {
        void TurnOnOff();
        void Drive();
    }
}
