using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentHatchery
{

    class GetFish
    {
        MarketPlace marketPlace = new MarketPlace();
        Hatchery hatchery = new Hatchery();
        MarketPlaceInventory marketPlaceInventory = MarketPlaceInventory.getInstance();
        HatcheryInventory hatcheryInventory = HatcheryInventory.getInstance();

        // public void fishGenerate()
        // {
        //     System.Console.WriteLine("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
        //     marketPlaceInventory.generate();
        //     hatcheryInventory.generateHatchery();
        // }


        public void BuyRui(int numOfRuiFish)
        {   
            String fishType = "RUI";

            marketPlace.SaleEvent += marketPlaceInventory.OnFishRequest;
            marketPlace.onFishSale(numOfRuiFish,fishType);


            marketPlace.BuyRequestEvent += hatchery.OnBuyFishRequest;
            marketPlace.onFishBuy(numOfRuiFish,fishType);
            hatchery.publish(numOfRuiFish,fishType);
        }

        public void BuyKatla(int numOfKatlaFish)
        {
            String fishType = "KATLA";

            marketPlace.SaleEvent += marketPlaceInventory.OnFishRequest;
            marketPlace.onFishSale(numOfKatlaFish,fishType);


            marketPlace.BuyRequestEvent += hatchery.OnBuyFishRequest;
            marketPlace.onFishBuy(numOfKatlaFish,fishType);
            hatchery.publish(numOfKatlaFish,fishType);
        }

        public void BuyIlish(int numOfIlishFish)
        {
            String fishType = "Ilish";

            marketPlace.SaleEvent += marketPlaceInventory.OnFishRequest;
            marketPlace.onFishSale(numOfIlishFish,fishType);


            marketPlace.BuyRequestEvent += hatchery.OnBuyFishRequest;
            marketPlace.onFishBuy(numOfIlishFish,fishType);
            hatchery.publish(numOfIlishFish,fishType);
        }
    }
}