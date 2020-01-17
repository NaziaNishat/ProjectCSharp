using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentHatchery
{
    class MarketPlaceInventory
    {
        HatcheryInventory HatcheryInventory = HatcheryInventory.getInstance();
        public static List<Rui> marketRuiList = new List<Rui>();
        public static List<Katla> marketKatlaList = new List<Katla>();
        public static List<Ilish> marketIlishList = new List<Ilish>();

        private static readonly object marketLock = new object();

        private int NumRui, NumKatla, NumIlish = 1200;

        private static MarketPlaceInventory obj;

        private MarketPlaceInventory() { }

        public static MarketPlaceInventory getInstance()
        {
            lock (marketLock)
            {
                if (obj == null)
                    obj = new MarketPlaceInventory();
                return obj;
            }
        }


        public void OnFishRequest(Object o, SaleArgs saleArgs, String type)
        {

            if (type == "RUI")
            {
                NumRui -= saleArgs.numOfFish;
                if (NumRui <= 0)
                    NumRui = HatcheryInventory.getSetHatcheryRui;
                System.Console.WriteLine("RUI Fish in market inventory:{0}", NumRui);

            }
            else if (type == "KATLA")
            {
                NumKatla -= saleArgs.numOfFish;
                if (NumKatla <= 0)
                    NumKatla = HatcheryInventory.getSetHatcheryKatla;
                System.Console.WriteLine("KATLA Fish in market inventory:{0}", NumKatla);
            }
            else
            {
                NumIlish -= saleArgs.numOfFish;
                if (NumIlish <= 0)
                    NumIlish = HatcheryInventory.getSetHatcheryIlish;
                System.Console.WriteLine("Ilish Fish in market inventory:{0}", NumIlish);
            }

        }

    }
}
