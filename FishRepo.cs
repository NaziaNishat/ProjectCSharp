using System;
using System.Threading;
using System.Collections.Generic;

namespace AssignmentHatchery
{
    class FishRepo{

        private static FishRepo obj;

        private FishRepo(){

        }

        public static FishRepo getInstance(){
            if(obj == null){
                obj = new FishRepo();
            }
            return obj;
        }

        public List<Katla> katlaList = new List<Katla>();
        public List<Rui> ruiList = new List<Rui>();
        public List<Ilish> ilishList = new List<Ilish>();
    }
}
