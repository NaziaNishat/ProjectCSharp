using System;
using System.Threading;
using System.Collections.Generic;

namespace AssignmentHatchery
{
    public abstract class Fish
    {   
        public string name;
        public int weight;

        public Fish(){}

        public Fish(string ruiName,int ruiWeight){
            name = ruiName;
            weight = ruiWeight;
        }

        public string Name{
            get{return name;}
            set{name = value;}
        }

        public int Weight{
            get{return weight;}
            set{weight = value;}
        }


    }
}
