using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    class CafeAuLait : HotDrink
    {

        //  public Latte()
        //{
           
        //}

        public override string Make()
        {
            String content = "Cafe au Lait";
        CoffeeContainer.GetContent();
            SugarContainer.GetContent(); 
         MilkContainer.GetContent();
            CupsServed++;
            return content;
    }
}
}
