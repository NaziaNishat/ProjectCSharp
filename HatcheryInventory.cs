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

        Repository repository = new Repository();

        // public KatlaRepository katlaRepository = new KatlaRepository();
        // public RuiRepository ruiRepository = new RuiRepository();
        // public IlishRepository ilishRepository = new IlishRepository();

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

        public void OnFetchFromHatchery(Object o, SaleArgs saleArgs, String type)
        {
            if (type == "RUI")
            {
                HatcheryRui = HatcheryRui - saleArgs.numOfFish;

                // for (int i = HatcheryRui; i < ruiRepository.Length(); i++)
                for (int i = HatcheryRui; i < repository.getList<Rui>().Count; i++)
                {
                    repository.Delete(i,type);
                }


                // HatcheryRuiList.RemoveRange(HatcheryRui , HatcheryRuiList.Count - HatcheryRui);

                Console.WriteLine("Available Hatchery Rui now: {0}", repository.getList<Rui>().Count);
            }
            else if (type == "KATLA")
            {
                // System.Console.WriteLine("first hHatcheryKatla: {0}", HatcheryKatla);

                HatcheryKatla = HatcheryKatla - saleArgs.numOfFish;
                // System.Console.WriteLine("hHatcheryKatla: {0}", HatcheryKatla);
                // System.Console.WriteLine("hHatcheryCount list: {0}", HatcheryKatlaList.Count);

                // for (int i = HatcheryKatla; i < katlaRepository.Length(); i++)
                for (int i = HatcheryKatla; i < repository.getList<Katla>().Count; i++)
                {
                    repository.Delete(i,type);
                }

                // HatcheryKatlaList.RemoveRange(HatcheryKatla, HatcheryKatlaList.Count - HatcheryKatla);

                Console.WriteLine("Available Hatchery Katla now: {0}", repository.getList<Katla>().Count);
            }
            else
            {
                HatcheryIlish = HatcheryIlish - saleArgs.numOfFish;

                // for (int i = HatcheryIlish; i < ilishRepository.Length(); i++)
                for (int i = HatcheryIlish; i < repository.getList<Ilish>().Count; i++)
                {
                    repository.Delete(i,type);
                }

                // HatcheryIlishList.RemoveRange(HatcheryIlish, HatcheryIlishList.Count - HatcheryIlish);

                Console.WriteLine("Available Hatchery Ilish now: {0}", repository.getList<Ilish>().Count);
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
            get { return HatcheryIlish; }
            set { HatcheryIlish = value; }
        }


    }
}
