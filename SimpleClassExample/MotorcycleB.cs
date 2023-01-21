using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    public class MotorcycleB
    {
        public int _driverIntensity;
        // New members to represent the name of the driver.
        public string _name;

        public MotorcycleB()
        {

        }

        public void SetDriverName(string name, int driverIntensity) 
        {
            _name = name;
            _driverIntensity = driverIntensity;
        }
        public void PopAWheely()
        {
            Console.WriteLine("Yeeeeeee Haaaaaeewww!");

        }

    }
}
