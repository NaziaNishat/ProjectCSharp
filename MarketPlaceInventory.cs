using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentHatchery
{
    class MarketPlaceInventory
    {   
        private static readonly object marketLock = new object();
        private int Rui = 1200;

        private static MarketPlaceInventory obj;

        private MarketPlaceInventory(){}

        public static MarketPlaceInventory getInstance(){
        lock(marketLock){
            if(obj == null)
                obj = new MarketPlaceInventory();
            return obj;
        }
        }

        public void OnFishRequest(Object o,SaleArgs saleArgs){
            Rui -= saleArgs.numOfFish;
        }

    }
}
