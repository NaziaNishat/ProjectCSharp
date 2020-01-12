using System;

namespace AssignmentHatchery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of fish you want:");
            String str = Console.ReadLine();
            int numOfFish = Convert.ToInt32(str);

            // if(numOfFish > 0){
                MarketPlace marketPlace = new MarketPlace();
                MarketPlaceInventory marketPlaceInventory = new MarketPlaceInventory();

                marketPlace.SaleEvent += marketPlaceInventory.OnFishRequest;
                marketPlace.onFishSale(numOfFish);
            // }
        
        
        }
    }
}
