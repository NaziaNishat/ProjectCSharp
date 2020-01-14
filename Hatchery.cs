using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentHatchery
{
    class Hatchery
    {

        public delegate void TransferDelegate(Object o,SaleArgs saleArgs,string type);
        public event TransferDelegate TransferEvent;

        public void publish(int numOfFish,String type){
            HatcheryInventory hatcheryInventory = HatcheryInventory.getInstance();
            TransferEvent += hatcheryInventory.OnFetchFromHatchery;
            onFetch(numOfFish,type);
        }

        public void onFetch(int numOfFish,String type){
            
            Fetchhandler(numOfFish,type);
        }

        public void Fetchhandler(int numOfFish,String type){
            if(TransferEvent != null){
                TransferEvent(this,new SaleArgs(){numOfFish = numOfFish},type);
            }           
        }

        public void OnBuyFishRequest(Object o,SaleArgs saleArgs,String type){
            Console.WriteLine("Market is in short of {0} {1}.",saleArgs.numOfFish,type);
        }


    }
}
