using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    class CarbonateContainer //Behållare för kolsyra och håller koll på om det tar slut.
   {
       public static int level;

        public CarbonateContainer(int nivå)
        {
            level = nivå;

        }

        public static void GetContent()
        {
            if (level == 0)
                throw new EmptyContainerException("Kolsyran är slut");
            level--;
        }
       
    }
}
