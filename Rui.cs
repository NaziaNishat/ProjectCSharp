using System;
using System.Threading;
using System.Collections.Generic;

namespace AssignmentHatchery
{
    class Rui : Fish
    {   
        List<Rui> ruiList = new List<Rui>();
        // public string name;
        // public int weight;

        public Rui(){}

        public Rui(string ruiName,int ruiWeight){
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

        // public List<Rui> generateRui(int numToGenerate){
        //     for(int i=1;i<=numToGenerate;i++){
        //         ruiList.Add(new Rui("Rui "+i,i));
        //     }

        //     return ruiList;
        // }

        // public void check(){
        //     System.Console.WriteLine(ruiList[1].name);
        // }
    }
}
