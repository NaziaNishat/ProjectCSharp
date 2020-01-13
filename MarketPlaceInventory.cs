using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentHatchery
{
    class MarketPlaceInventory
    {   
        public static List<Rui> marketRuiList = new List<Rui>();
  
        private static readonly object marketLock = new object();
    
        private int NumRui = 1200;

        private static MarketPlaceInventory obj;

        private MarketPlaceInventory(){}

        public static MarketPlaceInventory getInstance(){
        lock(marketLock){
            if(obj == null)
                obj = new MarketPlaceInventory();
            return obj;
         }
        }

        public void generate(){
            for(int i=1;i<=NumRui;i++){
                marketRuiList.Add(new Rui("Rui "+i,i));
            }
                        // System.Console.WriteLine("hhhhhhhhh : {0}",marketRuiList.Count);
            
        }

        public void OnFishRequest(Object o,SaleArgs saleArgs){
            NumRui -= saleArgs.numOfFish;
            // System.Console.WriteLine("oooooooooo : {0}",marketRuiList.Count);
            // System.Console.WriteLine("oooooooooo : {0}",NumRui);
            marketRuiList.RemoveRange(NumRui,marketRuiList.Count-NumRui);
            System.Console.WriteLine("Fish in market inventory:{0}",marketRuiList.Count);
        }

    }
}
