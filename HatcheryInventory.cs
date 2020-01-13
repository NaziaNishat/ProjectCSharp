using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentHatchery
{   
    class HatcheryInventory
    {  
        public static List<Rui> HatcheryRuiList = new List<Rui>();
  
        private static readonly object hatchLock = new object();  
 
        private static HatcheryInventory obj;

        private int HatcheryRui = 1000;

        private HatcheryInventory(){}

        public static HatcheryInventory getInstance(){
            lock(hatchLock){
            if(obj == null)
                obj = new HatcheryInventory();
            return obj;
            }
        }

        public void generateHatchery(){
            for(int i=1;i<=HatcheryRui;i++){
                HatcheryRuiList.Add(new Rui("Rui "+i,i));
            }
            System.Console.WriteLine("hhhhhhhhh : {0}",HatcheryRuiList.Count);
            
        }


        public void OnFetchFromHatchery(Object o,SaleArgs saleArgs){
            HatcheryRui = HatcheryRui - saleArgs.numOfFish;
            // System.Console.WriteLine("ooooooo:{0}",HatcheryRui);
            // System.Console.WriteLine("aaaaaa:{0}",HatcheryRuiList.Count);

            HatcheryRuiList.RemoveRange(HatcheryRui,HatcheryRuiList.Count-HatcheryRui);

            Console.WriteLine("Available Hatchery Rui now: {0}",HatcheryRuiList.Count);
        }

        public int getSetHatcheryRui   
        {
            get { return HatcheryRui; }   
            set { HatcheryRui = value; }  
        }     


    }
}
