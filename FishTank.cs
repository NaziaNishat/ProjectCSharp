using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentHatchery
{
    
    class FishTank
    {   
        static bool fishDecrease;
        HatcheryInventory hatcheryInventory = HatcheryInventory.getInstance();
        public void checkFishMarket(){
               if(hatcheryInventory.getSetHatcheryRui  < 700) 
               {
                   hatcheryInventory.getSetHatcheryRui = 1000;
                   fishDecrease = true;
               }
               else fishDecrease = false;
            
        }

        public void checkFishes(){
            if(fishDecrease)
            System.Console.WriteLine("Generated Fish: {0}",1000 - hatcheryInventory.getSetHatcheryRui);
            else{
            System.Console.WriteLine("No Fishes generated this time..");
            }
            
        } 
    }
}
