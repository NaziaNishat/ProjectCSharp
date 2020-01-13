using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentHatchery
{
    
    class FishTank
    {   
        HatcheryInventory hatcheryInventory = HatcheryInventory.getInstance();
        public void checkFishMarket(){
               if(hatcheryInventory.getSetHatcheryRui  < 700) 
               hatcheryInventory.getSetHatcheryRui = 1000;
            
        }

        public void checkFishes(){
            System.Console.WriteLine("Fish in fishtank: {0}",hatcheryInventory.getSetHatcheryRui);
            
        } 
    }
}
