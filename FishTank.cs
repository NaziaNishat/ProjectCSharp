using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentHatchery
{
    
    class FishTank
    {   
        HatcheryInventory hatcheryInventory = HatcheryInventory.getInstance();
        public void checkFishMarket(){
               if(hatcheryInventory.getSetHatcheryRui  < 1000) 
               hatcheryInventory.getSetHatcheryRui = 900;
            
        }

        public void checkFishes(){
            System.Console.WriteLine("Fish in fishtank: {0}",hatcheryInventory.getSetHatcheryRui);
            
        } 
    }
}
