using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentHatchery
{
    class MarketPlaceInventory
    {   
        private int Rui = 500;

        private static MarketPlaceInventory obj;

        private MarketPlaceInventory(){}

        public static MarketPlaceInventory getInstance(){
            if(obj == null)
                obj = new MarketPlaceInventory();
            return obj;
        }

        public void OnFishRequest(Object o,SaleArgs saleArgs){
            Rui -= saleArgs.numOfFish;
        }

    }
}
