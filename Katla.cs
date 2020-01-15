using System;
using System.Threading;
using System.Collections.Generic;

namespace AssignmentHatchery
{
    class Katla : Fish
    {   
        // public string name;
        // public int weight;

        public List<Katla> katlaList = new List<Katla>();

        public Katla(){}

        public Katla(string ruiName,int ruiWeight){
            name = ruiName;
            weight = ruiWeight;
        }

        // public string Name{
        //     get{return name;}
        //     set{name = value;}
        // }

        // public int Weight{
        //     get{return weight;}
        //     set{weight = value;}
        // }


    }
}
