using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    class SparklingWater : ColdDrink
    {

        public override string Make()
        {
           
            CarbonateContainer.GetContent();
            CupsServed++;
            return "Kolsyratvatten";

        }

    }
}
