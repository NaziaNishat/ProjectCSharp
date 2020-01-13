using System;
using System.Threading;

namespace AssignmentHatchery
{
    class Program
    {   
        static void Main(string[] args)
        {   
            // Rui rui = new Rui();
            // rui.generateRui();
            // rui.check();

            //----------------------------------------------------------------------------
            
            Thread thr = new Thread(new ThreadStart(checkFish));
            thr.Start();

            
            while(true){
            System.Console.WriteLine("****************************************************");


            Console.WriteLine("Enter number of fish you want:");
            String str = Console.ReadLine();
            int numOfFish = Convert.ToInt32(str);

            if(numOfFish > 1200)
            System.Console.WriteLine("Sorry! We don't have that much fishes");

            else{

            // if(numOfFish > 0){
                MarketPlace marketPlace = new MarketPlace();
                Hatchery hatchery = new Hatchery();
                MarketPlaceInventory marketPlaceInventory = MarketPlaceInventory.getInstance();
                HatcheryInventory hatcheryInventory = HatcheryInventory.getInstance();

                marketPlaceInventory.generate();
                hatcheryInventory.generateHatchery();

                marketPlace.SaleEvent += marketPlaceInventory.OnFishRequest;
                marketPlace.onFishSale(numOfFish);

                
                marketPlace.BuyRequestEvent += hatchery.OnBuyFishRequest;
                marketPlace.onFishBuy(numOfFish);
                hatchery.publish(numOfFish);

                FishTank fishTank = new FishTank();
                fishTank.checkFishes();

            System.Console.WriteLine("****************************************************");
                }
            }
                

            // }
        
        
        }

        public static void checkFish(){
            FishTank fishTank = new FishTank();

            while(true){
                System.Threading.Thread.Sleep(3000);
                fishTank.checkFishMarket();
            }
        }
    }
}
