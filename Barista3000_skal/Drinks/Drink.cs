using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    abstract class Drink
    {

        public static int CupsServed = 0;

        public abstract string Make();

        public int Cups
        {
           get { return CupsServed;}
    }

        
    }
}
