using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    internal class Motorcycle
    {
        public void PopAWheelyA()
        {
            Console.WriteLine("Yeeeeeee Haaaaaeewww!");

        }
        public int driverIntensity;

        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaaeewww!");
            }
        }
        // Put back the default constructor, which will
        // set all data members to default values.
        public Motorcycle() { }
        // Our custom constructor.
        public Motorcycle(int intensity)
        {
            driverIntensity = intensity;
        }
    }

}

