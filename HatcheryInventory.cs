using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentHatchery
{
    class HatcheryInventory
    {
        public static List<Rui> HatcheryRuiList = new List<Rui>();
        public static List<Katla> HatcheryKatlaList = new List<Katla>();

        private static readonly object hatchLock = new object();

        private static HatcheryInventory obj;

        private int HatcheryRui, HatcheryKatla, HatcheryIlish = 1000;

        private HatcheryInventory() { }

        public static HatcheryInventory getInstance()
        {
            lock (hatchLock)
            {
                if (obj == null)
                    obj = new HatcheryInventory();
                return obj;
            }
        }

        public void generateHatchery()
        {
            for (int i = 0; i <= HatcheryRui; i++)
            {
                HatcheryRuiList.Add(new Rui("Rui " + i, i));
                HatcheryKatlaList.Add(new Katla("Katla " + i, i));

                System.Console.WriteLine("generatehatchery: {0}",HatcheryRuiList.Count);
            }

        }


        public void OnFetchFromHatchery(Object o, SaleArgs saleArgs, String type)
        {
            if (type == "RUI")
            {
                HatcheryRui = HatcheryRui - saleArgs.numOfFish;
                System.Console.WriteLine("MarketCount: {0}",HatcheryRuiList.Count);


                HatcheryRuiList.RemoveRange(HatcheryRui, HatcheryRuiList.Count-1 - HatcheryRui);

                Console.WriteLine("Available Hatchery Rui now: {0}", HatcheryRuiList.Count);
            }
            else if (type == "KATLA")
            {
                HatcheryKatla = HatcheryKatla - saleArgs.numOfFish;
                System.Console.WriteLine("hHatcheryCount: {0}",HatcheryKatlaList.Count);

                HatcheryKatlaList.RemoveRange(HatcheryKatla, HatcheryKatlaList.Count - HatcheryKatla);

                Console.WriteLine("Available Hatchery Katla now: {0}", HatcheryKatlaList.Count);
            }
        }

        public int getSetHatcheryRui
        {
            get { return HatcheryRui; }
            set { HatcheryRui = value; }
        }

        public int getSetHatcheryKatla
        {
            get { return HatcheryKatla; }
            set { HatcheryKatla = value; }
        }
        public int getSetHatcheryIlish
        {
            get { return HatcheryRui; }
            set { HatcheryIlish = value; }
        }


    }
}
