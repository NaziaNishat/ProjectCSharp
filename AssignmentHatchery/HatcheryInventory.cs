using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentHatchery
{
    class HatcheryInventory
    {
        private Hatchery hatchery;

             public void Subscribe(EventFire ef)
            {
                ef += new EventFire.TransferEvent(TransferEventFired);
            }    
            }
}
