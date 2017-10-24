using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barista3000
{
    class Chocolate : HotDrink
    {
        
          public Chocolate()
        {
           
        }

        public override string Make()
        {
            String content = "Chocklad";
       ChocolateContainer.GetContent();
            CupsServed++;
            return content;
                 }
            
            }
        }
    

