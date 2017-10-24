using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    class CoffeeContainer
    {
        public static int level;
        public CoffeeContainer(int nivå)
        {
            level = nivå;

        }

        public static void GetContent()
        {
            if (level == 0)
                throw new EmptyContainerException("Kaffet är slut");
            level--;
        }
    }
}
