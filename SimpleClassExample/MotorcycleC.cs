using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    public class MotorcycleC
    {
        class Motorcycle
        {
            public int driverIntensity;
            public string driverName;
            // Constructor chaining.
            public Motorcycle()
            {
                Console.WriteLine("In default constructor");
            }
            public Motorcycle(int intensity)
            : this(intensity, "")
            {
                Console.WriteLine("In constructor taking an int");
            }
            public Motorcycle(string name)
            : this(0, name)
            {
                Console.WriteLine("In constructor taking a string");
            }
            // This is the 'main' constructor that does all the real work.
            public  Motorcycle(int intensity, string name)
            {
                Console.WriteLine("In main constructor");
                if (intensity > 10)
                {
                    intensity = 10;
                }
                driverIntensity = intensity;
                driverName = name;
            }

            public void PopAWheely()
            {
                Console.WriteLine("Yeeeeeee Haaaaaeewww!");

            }

        }
    }
}
