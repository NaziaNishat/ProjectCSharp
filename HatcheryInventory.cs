using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentHatchery
{   
    class HatcheryInventory
    {  
        private static readonly object hatchLock = new object();  
 
        private static HatcheryInventory obj;

        private int HatcheryRui = 1000;

        private HatcheryInventory(){}

        public static HatcheryInventory getInstance(){
            lock(hatchLock){
            if(obj == null)
                obj = new HatcheryInventory();
            return obj;
            }
        }


        public void OnFetchFromHatchery(Object o,SaleArgs saleArgs){
            HatcheryRui = HatcheryRui - saleArgs.numOfFish;
            Console.WriteLine("Available Hatchery Rui now: {0}",HatcheryRui);
        }

        public int getSetHatcheryRui   
        {
            get { return HatcheryRui; }   
            set { HatcheryRui = value; }  
        }     


    }
}
