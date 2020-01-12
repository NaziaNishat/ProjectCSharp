using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentHatchery
{
    class Hatchery
    {
        private RuiFishTank ruiFishTank;
        private KatlaFishTank katlaFishTank;

                    public void Subscribe(EventFire ef)
            {
                ef += new EventFire.BuyRequestEvent(BuyRequestEventFired);
                ef += new EventFire.TransferEvent(TransferEventFired);
            }



    }
}
