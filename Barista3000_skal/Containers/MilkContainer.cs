using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    class MilkContainer 
{
        public static int level;

        public MilkContainer(int niva)
        {
            level = niva;

        }

        public static void GetContent()
        {
            if (level == 0)
                throw new EmptyContainerException("Mjölken är slut");
            level--;
        }
     
    }
}
