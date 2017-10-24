using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;



namespace Barista3000
{
     class CoffeeMaker 
    {

        // public void CoffeeMaker()
     
           SugarContainer Sockerburk = new SugarContainer(5);
            MilkContainer Mjölkkanna = new MilkContainer(5);
            CoffeeContainer Kaffeburk = new CoffeeContainer(5);
            ChocolateContainer Chocolatecan = new ChocolateContainer(5);
        CarbonateContainer Kolsyrepatron = new CarbonateContainer(5);
         
        public string MakeDrink(Drink dryck)
        {
            return dryck.Make();
        }

    public void refill()
    {
     
        try
        {
            if (CoffeeContainer.level == 0)
            {
                CoffeeContainer Kaffeburk = new CoffeeContainer(5);
                
                //Console.Write("Coffee container är nu påfylld");
            }
            else
                if (ChocolateContainer.level == 0)
                {
                    ChocolateContainer Chocolatecan = new ChocolateContainer(5);
                   // Console.Write("Choklad container är nu påfylld");
                }
                else
                    if (CarbonateContainer.level == 0)
                    {
                        CarbonateContainer kc = new CarbonateContainer(5);
                       // Console.Write("Karbonat container är nu påfylld");
                    }
                    else
                        if (SugarContainer.level == 0)
                        {
                            SugarContainer sc = new SugarContainer(5);
                          //  Console.Write("Socker container är nu påfylld");
                        }
                        else
                            if (MilkContainer.level == 0)
                            {
                                MilkContainer mc = new MilkContainer(5);
                               // Console.Write("Mjölk container är nu påfylld");
                            }
                            else
                            {
                                Console.WriteLine("Tyväär kan containern bara fylls på om Containern är tom");
                            
                            }

          
        }
        catch(EmptyContainerException e)
        {
            Console.WriteLine(e.Message);
        }
        
    }
  }
}


          