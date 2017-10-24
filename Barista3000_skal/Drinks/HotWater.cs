using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    class HotWater : HotDrink
    {
        public override string Make()
        {
            CupsServed++;
            return "Tevatten";
        }
    }
}
