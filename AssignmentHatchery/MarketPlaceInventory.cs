using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentHatchery
{
    class MarketPlaceInventory
    {
        public void inform(){

            Subscribe();

        }

                    public void Subscribe()
            {
                EventFire ef = new EventFire();
                
                ef += new EventFire.SalesEvent(SalesEventFired);
                ef += new EventFire.TransferEvent(TransferEventFired);
            }
            public void SalesEventFired()
            {
                System.Console.WriteLine("Sales Event Fired");
            }

            public void TransferEventFired()
            {
                System.Console.WriteLine("Transfer Event Fired");
            }
    }
}
