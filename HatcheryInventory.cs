using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentHatchery
{
    class HatcheryInventory
    {
        public static List<Rui> HatcheryRuiList = new List<Rui>();
        public static List<Katla> HatcheryKatlaList = new List<Katla>();
        public static List<Ilish> HatcheryIlishList = new List<Ilish>();

        private static readonly object hatchLock = new object();

        private static HatcheryInventory obj;

        private int HatcheryRui = 1000, HatcheryKatla = 1000, HatcheryIlish = 1000;

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

                System.Console.WriteLine("generatehatchery: {0}", HatcheryRuiList.Count);
            }

        }


        public void OnFetchFromHatchery(Object o, SaleArgs saleArgs, String type)
        {
            if (type == "RUI")
            {
                HatcheryRui = HatcheryRui - saleArgs.numOfFish;
                System.Console.WriteLine("MarketCount: {0}", HatcheryRuiList.Count);


                HatcheryRuiList.RemoveRange(HatcheryRui , HatcheryRuiList.Count - HatcheryRui);

                Console.WriteLine("Available Hatchery Rui now: {0}", HatcheryRuiList.Count);
            }
            else if (type == "KATLA")
            {
                // System.Console.WriteLine("first hHatcheryKatla: {0}", HatcheryKatla);

                HatcheryKatla = HatcheryKatla - saleArgs.numOfFish;
                // System.Console.WriteLine("hHatcheryKatla: {0}", HatcheryKatla);
                // System.Console.WriteLine("hHatcheryCount list: {0}", HatcheryKatlaList.Count);

                HatcheryKatlaList.RemoveRange(HatcheryKatla, HatcheryKatlaList.Count - HatcheryKatla);

                Console.WriteLine("Available Hatchery Katla now: {0}", HatcheryKatlaList.Count);
            }
            else
            {
                // System.Console.WriteLine("first hHatcheryIlish: {0}", HatcheryIlish);

                HatcheryIlish = HatcheryIlish - saleArgs.numOfFish;

                // System.Console.WriteLine("hHatcheryIlish: {0}", HatcheryIlish);
                // System.Console.WriteLine("hHatcheryIlishList: {0}", HatcheryIlishList.Count);

                HatcheryIlishList.RemoveRange(HatcheryIlish, HatcheryIlishList.Count - HatcheryIlish);

                Console.WriteLine("Available Hatchery Ilish now: {0}", HatcheryIlishList.Count);
            }
        }

        public List<Rui> getSetHatcheryRuiList
        {
            get { return HatcheryRuiList; }
            set { HatcheryRuiList = value; }
        }

        public List<Katla> getSetHatcheryKatlaList
        {
            get { return HatcheryKatlaList; }
            set { HatcheryKatlaList = value; }
        }

        // public List<Ilish> getSetHatcheryIlishList
        // {
        //     get { return HatcheryIlishList; }
        //     set { HatcheryIlishList = value; }
        // }

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
            get { return HatcheryIlish; }
            set { HatcheryIlish = value; }
        }


    }
}
