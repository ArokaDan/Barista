using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    class Coffee : HotDrink
    {
        public bool milk, sugar;

        public Coffee(bool mjölk, bool socker)
        {
            this.milk = mjölk;
            this.sugar = socker;
        }

        public override string Make()
        {
            String content = "Svart kaffe";
        CoffeeContainer.GetContent();
            CupsServed++;
            if (milk)
            {
                MilkContainer.GetContent();
                content += " med mjölk";
            }
            if (sugar)
            {
                SugarContainer.GetContent();
                content += " och socker";
            }
            return content;
        

    }
    }
}
