using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentHatchery
{
    class HatcheryInventory
    {
        public static int HatcheryRui = 1000;
        public void OnFetchFromHatchery(Object o,SaleArgs saleArgs){
            HatcheryRui = HatcheryRui - saleArgs.numOfFish;
            Console.WriteLine("Available Hatchery Rui now: {0}",HatcheryRui);
        }

    }
}
