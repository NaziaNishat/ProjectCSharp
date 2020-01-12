using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentHatchery
{
    class EventFire{

        public System.EventArgs e = null;

        public event  SalesEvent salesEvent;
        public delegate void SalesEvent(EventFire eventFire,System.EventArgs e);

        public event BuyRequestEvent buyRequestEvent;
        public delegate void BuyRequestEvent(EventFire eventFire,System.EventArgs e);

        public event TransferEvent transferEvent;
        public delegate void TransferEvent(EventFire eventFire,System.EventArgs e);

        public void Start(){
            if(salesEvent != null){
                salesEvent(this,e);
            }

            if(buyRequestEvent != null){
                buyRequestEvent(this,e);
            }
        }
    }

         public class MarketPlace
        {
            public void Subscribe()
            {
                EventFire ef  = new EventFire();
                var eventFire = new Eve
                ef += new EventFire.SalesEvent(SalesEventFired);
                ef += new EventFire.BuyRequestEvent(BuyRequestEventFired);
            }
            public void SalesEventFired()
            {
                Program program = new Program();
                
                System.Console.WriteLine("Sales Event Fired");
            }

            public void BuyRequestEventFired()
            {
                System.Console.WriteLine("Buy Request Event Fired");
            }

        }

}
