using System;
using System.Collections.Generic;
using System.Text;

namespace _31_maaay
{
    class Car: Vehicle
    {
        public double FuelCapacity;
         
        public void AddFuel(int litr)
        {
           
            if (FuelCapacity >litr)
            {
                FuelCapacity += litr;
                
            }

        }
    }
}
