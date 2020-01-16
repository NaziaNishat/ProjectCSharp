using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentHatchery
{
    class HatcheryInventory
    {
        // public static List<Rui> HatcheryRuiList = new List<Rui>();
        // public static List<Katla> HatcheryKatlaList = new List<Katla>();
        // public static List<Ilish> HatcheryIlishList = new List<Ilish>();

        Repository<Fish> repository = new Repository<Fish>();

        public KatlaRepository katlaRepository = new KatlaRepository();
        public RuiRepository ruiRepository = new RuiRepository();
        public IlishRepository ilishRepository = new IlishRepository();

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
                // HatcheryRuiList.Add(new Rui("Rui " + i, i));
                // HatcheryKatlaList.Add(new Katla("Katla " + i, i));
                katlaRepository.Add(new Katla("Katla " + i, i));

                System.Console.WriteLine("generatehatchery: {0}", katlaRepository.Length());
            }

        }


        public void OnFetchFromHatchery(Object o, SaleArgs saleArgs, String type)
        {
            if (type == "RUI")
            {
                HatcheryRui = HatcheryRui - saleArgs.numOfFish;
                // System.Console.WriteLine("MarketCount: {0}", HatcheryRuiList.Count);

                for (int i = HatcheryRui; i < ruiRepository.Length(); i++)
                {
                    repository.Delete(i,type);
                }


                // HatcheryRuiList.RemoveRange(HatcheryRui , HatcheryRuiList.Count - HatcheryRui);

                Console.WriteLine("Available Hatchery Rui now: {0}", repository.LengthOfList(type));
            }
            else if (type == "KATLA")
            {
                // System.Console.WriteLine("first hHatcheryKatla: {0}", HatcheryKatla);

                HatcheryKatla = HatcheryKatla - saleArgs.numOfFish;
                // System.Console.WriteLine("hHatcheryKatla: {0}", HatcheryKatla);
                // System.Console.WriteLine("hHatcheryCount list: {0}", HatcheryKatlaList.Count);

                for (int i = HatcheryKatla; i < katlaRepository.Length(); i++)
                {
                    repository.Delete(i,type);
                }

                // HatcheryKatlaList.RemoveRange(HatcheryKatla, HatcheryKatlaList.Count - HatcheryKatla);

                Console.WriteLine("Available Hatchery Katla now: {0}", repository.LengthOfList(type));
            }
            else
            {
                // System.Console.WriteLine("first hHatcheryIlish: {0}", HatcheryIlish);

                HatcheryIlish = HatcheryIlish - saleArgs.numOfFish;

                for (int i = HatcheryIlish; i < ilishRepository.Length(); i++)
                {
                    repository.Delete(i,type);
                }

                // System.Console.WriteLine("hHatcheryIlish: {0}", HatcheryIlish);
                // System.Console.WriteLine("hHatcheryIlishList: {0}", HatcheryIlishList.Count);

                // HatcheryIlishList.RemoveRange(HatcheryIlish, HatcheryIlishList.Count - HatcheryIlish);

                Console.WriteLine("Available Hatchery Ilish now: {0}", repository.LengthOfList(type));
            }
        }

        // public List<Rui> getSetHatcheryRuiList
        // {
        //     get { return HatcheryRuiList; }
        //     set { HatcheryRuiList = value; }
        // }

        // public List<Katla> getSetHatcheryKatlaList
        // {
        //     get { return HatcheryKatlaList; }
        //     set { HatcheryKatlaList = value; }
        // }

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
