using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BearAdapter
{
    public class BrownBear : IBear
    {
        public bool Hibernating { get; set; }

        public void Roar()
        {
            Console.WriteLine("Wraaahh");
        }
        public void  LookAt(object objectToLookAt)
        {
            Console.WriteLine("Bear is looking at " + objectToLookAt);
        }
        public void GoTowards(object objectToWalkTowards)
        {
            Console.WriteLine("Go towards" + objectToWalkTowards);
        }
        public bool TryEat(object objectToEat)
        {
            if(Hibernating)
                return false;
            else
                return true;
        }
    }
}