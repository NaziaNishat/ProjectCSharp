using System;
using System.Threading;

namespace AssignmentHatchery
{
    class Program
    {



        static void Main(string[] args)
        {
            int numOfRuiFish, numOfKatlaFish,marketFish = 1200,hatcheryFish = 1200;

            Thread thr = new Thread(new ThreadStart(checkFish));
            thr.Start();

            // GetFish getFish = new GetFish();
            // getFish.fishGenerate();

                            for (int i = 0; i <= marketFish; i++)
                {
                    // MarketPlaceInventory.marketRuiList.Add(new Rui("Rui " + i, i));
                    System.Console.WriteLine("aaaaaaaaaaaaaa:{0}",MarketPlaceInventory.marketKatlaList.Count);
                    MarketPlaceInventory.marketKatlaList.Add(new Katla("Katla " + i, i));

                }

                for (int i = 0; i <= hatcheryFish; i++)
                {
                    // HatcheryInventory.HatcheryRuiList.Add(new Rui("Rui " + i, i));
                    HatcheryInventory.HatcheryKatlaList.Add(new Katla("Katla " + i, i));

                }

            while (true)
            {
                GetFish getFish = new GetFish();
                // getFish.fishGenerate();

                // MarketPlaceInventory marketPlaceInventory = MarketPlaceInventory.getInstance();
                // marketPlaceInventory.generate();

                // HatcheryInventory hatcheryInventory = HatcheryInventory.getInstance();
                // hatcheryInventory.generateHatchery();


                // System.Console.WriteLine("generatehatchery: {0}", HatcheryInventory.HatcheryRuiList.Count);

                // System.Console.WriteLine("ccc: {0}", MarketPlaceInventory.marketRuiList.Count);

                // for (int i = 1; i <= NumKatla; i++)
                // {
                //     marketKatlaList.Add(new Katla("Katla " + i, i));
                // }

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

                }
                else
                {
                    System.Console.WriteLine("Wrong option chosen...");
                }



                FishTank fishTank = new FishTank();
                fishTank.checkFishes();

                System.Console.WriteLine("****************************************************");
            }
            // }


            // }


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
