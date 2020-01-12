using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentHatchery
{
    class MarketPlace{

        public delegate void SaleDelegate(Object o,SaleArgs saleArgs);
        public event SaleDelegate SaleEvent;

        public delegate void BuyRequestDelegate(Object o,SaleArgs saleArgs);
        public event BuyRequestDelegate BuyRequestEvent;

        public void onFishSale(int numOfFish){
            fishSaleHandler(numOfFish);
        }

        public void onFishBuy(int numOfFish){
            fishBuyHandler(numOfFish);
        }

        protected virtual void fishSaleHandler(int numOfFish){
            if(SaleEvent != null){
                SaleEvent(this,new SaleArgs(){numOfFish = numOfFish});
            }
        }

        protected virtual void fishBuyHandler(int numOfFish){
            if(BuyRequestEvent != null){
                BuyRequestEvent(this,new SaleArgs(){numOfFish = numOfFish});
            }
        }

    }

    public class SaleArgs : EventArgs{
        public int numOfFish{get;set;}
    }


}
