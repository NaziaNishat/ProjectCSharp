using System;
using System.Threading;

namespace AssignmentHatchery
{
    class Program
    {



        static void Main(string[] args)
        {   

            Repository repository = new Repository();
            
            // KatlaRepository katlaRepository = new KatlaRepository();
            // RuiRepository ruiRepository = new RuiRepository();
            // IlishRepository ilishRepository = new IlishRepository();

            int numOfRuiFish, numOfKatlaFish,numOfIlishFish, marketFish = 1200;

            Thread thr = new Thread(new ThreadStart(checkFish));
            thr.Start();

            for (int i = 0; i <= marketFish; i++)
            {
                MarketPlaceInventory.marketRuiList.Add(new Rui("Rui " + i, i));
                MarketPlaceInventory.marketKatlaList.Add(new Katla("Katla " + i, i));
                MarketPlaceInventory.marketIlishList.Add(new Ilish("Ilish " + i, i));

                repository.Add(new Rui("Rui " + i, i));
                repository.Add(new Katla("Katla " + i, i));
                repository.Add(new Ilish("Ilish " + i, i));


                System.Console.WriteLine("hlwwwwwww:{0}",repository.getList<Katla>().Count);

                // ruiRepository.Add(new Rui("Rui " + i, i));
                // katlaRepository.Add(new Katla("Katla " + i, i));
                // ilishRepository.Add(new Ilish("Ilish " + i, i));
                // katlaRepository.Add(new Ilish("Ilish " + i, i));


                // HatcheryInventory.HatcheryRuiList.Add(new Rui("Rui " + i, i));
                // HatcheryInventory.HatcheryKatlaList.Add(new Katla("Katla " + i, i));
                // HatcheryInventory.HatcheryIlishList.Add(new Ilish("Ilish " + i, i));
            }
            // System.Console.WriteLine("aaaaaaaa:{0}",katlaRepository.Length());

            // System.Console.WriteLine("marketKatlaCount:{0}", MarketPlaceInventory.marketKatlaList.Count);
            // System.Console.WriteLine("marketRuiCount:{0}", MarketPlaceInventory.marketRuiList.Count);
            // System.Console.WriteLine("marketIlishCount:{0}", MarketPlaceInventory.marketIlishList.Count);


            // for (int i = 0; i <= hatcheryFish; i++)
            // {
            //     // HatcheryInventory.HatcheryRuiList.Add(new Rui("Rui " + i, i));
            //     HatcheryInventory.HatcheryKatlaList.Add(new Katla("Katla " + i, i));

            // }

            while (true)
            {
                GetFish getFish = new GetFish();

                System.Console.WriteLine("****************************************************");


                Console.WriteLine("If you want Rui Fish,type 1:");
                Console.WriteLine("If you want Katla Fish,type 2:");
                Console.WriteLine("If you want Ilish Fish,type 3:");

                String str = Console.ReadLine();
                int inputOption = Convert.ToInt32(str);

                if (inputOption == 1)
                {
                    Console.WriteLine("Enter number of Rui fish you want:");
                    str = Console.ReadLine();
                    numOfRuiFish = Convert.ToInt32(str);

                    getFish.BuyRui(numOfRuiFish);

                }
                else if (inputOption == 2)
                {
                    Console.WriteLine("Enter number of Katla fish you want:");
                    str = Console.ReadLine();
                    numOfKatlaFish = Convert.ToInt32(str);

                    getFish.BuyKatla(numOfKatlaFish);
                }
                else if (inputOption == 3)
                {
                    Console.WriteLine("Enter number of Ilish fish you want:");
                    str = Console.ReadLine();
                    numOfIlishFish = Convert.ToInt32(str);

                    getFish.BuyIlish(numOfIlishFish);
                }
                else
                {
                    System.Console.WriteLine("Wrong option chosen...");
                }



                FishTank fishTank = new FishTank();
                fishTank.checkFishes();

                System.Console.WriteLine("****************************************************");
            }

        }

        public static void checkFish()
        {
            FishTank fishTank = new FishTank();

            while (true)
            {
                System.Threading.Thread.Sleep(3000);
                fishTank.checkFishMarket();
            }
        }

    }
}
