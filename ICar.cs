using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebScraper
{
    //creates a layer of abbstraction
    //CANNOT HAVE FIELDS, CONSTRUCTORS
    //JUST HAVE THE SIGNATURES

    internal interface ICar
    {
        void TurnOnOff();
        void Drive();
    }
}
