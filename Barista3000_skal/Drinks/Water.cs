using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    class Water : ColdDrink
    {

        public override string Make()
        {
            string content = "Vatten ";
            CupsServed++;
            return content;
        }
    }
}
