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

            if(numOfFish > 0){
                EventFire eventFire = new EventFire();
                MarketPlace marketPlace = new MarketPlace();
                marketPlace.Subscribe();
                eventFire.Start();

                MarketPlaceInventory marketPlaceInventory = new MarketPlaceInventory();
                marketPlaceInventory.inform();
            }

        }
    }
}
