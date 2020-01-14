using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentHatchery
{
    class MarketPlace{

        public delegate void SaleDelegate(Object o,SaleArgs saleArgs,String Type);
        public event SaleDelegate SaleEvent;

        public delegate void BuyRequestDelegate(Object o,SaleArgs saleArgs,String type);
        public event BuyRequestDelegate BuyRequestEvent;

        public void onFishSale(int numOfFish,String type){
            fishSaleHandler(numOfFish,type);
        }

        public void onFishBuy(int numOfFish,String type){
            fishBuyHandler(numOfFish,type);
        }

        protected virtual void fishSaleHandler(int numOfFish,String type){
            if(SaleEvent != null){
                SaleEvent(this,new SaleArgs(){numOfFish = numOfFish},type);
            }
        }

        protected virtual void fishBuyHandler(int numOfFish,String type){
            if(BuyRequestEvent != null){
                BuyRequestEvent(this,new SaleArgs(){numOfFish = numOfFish},type);
            }
        }

    }

    public class SaleArgs : EventArgs{
        public int numOfFish{get;set;}
    }


}
