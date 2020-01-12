using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentHatchery
{
    
    class FishTank
    {   
        HatcheryInventory hatcheryInventory = new HatcheryInventory();
        public void checkFishMarket(){
               if(HatcheryInventory.HatcheryRui < 1000) 
               HatcheryInventory.HatcheryRui = 900;
            
        }

        public void checkFishes(){
            System.Console.WriteLine("Fish in fishtank: {0}",HatcheryInventory.HatcheryRui);
            
        } 
    }
}
