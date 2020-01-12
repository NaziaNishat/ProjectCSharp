using System;
using System.Threading;

namespace AssignmentHatchery
{
    class Program
    {   
        static void Main(string[] args)
        {   
            Thread thr = new Thread(new ThreadStart(checkFish));
            thr.Start();

            
            while(true){

            Console.WriteLine("Enter number of fish you want:");
            String str = Console.ReadLine();
            int numOfFish = Convert.ToInt32(str);

            // if(numOfFish > 0){
                MarketPlace marketPlace = new MarketPlace();
                Hatchery hatchery = new Hatchery();
                MarketPlaceInventory marketPlaceInventory = new MarketPlaceInventory();

                marketPlace.SaleEvent += marketPlaceInventory.OnFishRequest;
                marketPlace.onFishSale(numOfFish);

                
                marketPlace.BuyRequestEvent += hatchery.OnBuyFishRequest;
                marketPlace.onFishBuy(numOfFish);
                hatchery.publish(numOfFish);

                FishTank fishTank = new FishTank();
                fishTank.checkFishes();
                }
                

            // }
        
        
        }

        public static void checkFish(){
            FishTank fishTank = new FishTank();

            while(true){
                System.Threading.Thread.Sleep(100);
                fishTank.checkFishMarket();
            }
        }
    }
}
