using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    class SugarContainer
    {
         public static int level;

        public SugarContainer(int nivå)
        {
            level = nivå;

        }

        public static void GetContent()
        {
            if (level == 0)
                throw new EmptyContainerException("Sockret är slut");
            level--;
        }
       
    }
}
