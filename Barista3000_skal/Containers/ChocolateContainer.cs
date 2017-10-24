using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    class ChocolateContainer
   {
         public static int level;

         public ChocolateContainer(int nivå)
        {
            level = nivå;

        }

        public static void GetContent()
        {
            if (level == 0)
                throw new EmptyContainerException("Chockladen är slut");
            level--;
        }
       
      
    }
}
