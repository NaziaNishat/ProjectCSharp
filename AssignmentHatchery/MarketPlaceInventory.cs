using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentHatchery
{
    class MarketPlaceInventory
    {   
        public static int Rui = 50; 
        public void OnFishRequest(Object o,SaleArgs saleArgs){
            Rui -= saleArgs.numOfFish;
            Console.WriteLine(Rui);
        }
    }
}
