using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentHatchery
{
    class Hatchery
    {

        public delegate void TransferDelegate(Object o,SaleArgs saleArgs);
        public event TransferDelegate TransferEvent;

        public void publish(int numOfFish){
            HatcheryInventory hatcheryInventory = new HatcheryInventory();
            TransferEvent += hatcheryInventory.OnFetchFromHatchery;
            onFetch(numOfFish);
        }

        public void onFetch(int numOfFish){
            
            Fetchhandler(numOfFish);
        }

        public void Fetchhandler(int numOfFish){
            if(TransferEvent != null){
                TransferEvent(this,new SaleArgs(){numOfFish = numOfFish});
            }           
        }

        public void OnBuyFishRequest(Object o,SaleArgs saleArgs){
            Console.WriteLine("Market is in short of {0} Rui.",saleArgs.numOfFish);
        }


    }
}
