namespace AutoProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("***** Fun with Automatic Properties *****\n");
            //Car c = new Car();
            //c.PetName = "Frank";
            //c.Speed = 55;
            //c.Color = "Red";
            //Console.WriteLine("Your car is named {0}? That's odd...",
            // c.PetName);
            //c.DisplayStats();
            //Console.ReadLine();

            //Garage g = new Garage();
            //// OK, prints default value of zero.
            //Console.WriteLine("Number of Cars: {0}", g.NumberOfCars);
            //// Runtime error! Backing field is currently null!
            //Console.WriteLine(g.MyAuto.PetName);
            //Console.ReadLine();

            Console.WriteLine("***** Fun with Automatic Properties *****\n");
            // Make a car.
            Car c = new Car();
            c.PetName = "Frank";
            c.Speed = 55;
            c.Color = "Red";
            //c.NumberOfCars = 20;
            c.DisplayStats();
            // Put car in the garage.
            var g = new GarageB();
            g.MyAuto = c;
            Console.WriteLine("Number of Cars in garage: {0}", g.NumberOfCars);
            Console.WriteLine("Your car is named: {0}", g.MyAuto.PetName);
            Console.ReadLine();
        }
    }

    class GarageB
    {
        // The hidden backing field is set to zero!
        public int NumberOfCars { get; set; }
        // The hidden backing field is set to null!
        public Car MyAuto { get; set; }
        // Must use constructors to override default
        // values assigned to hidden backing fields.
        public GarageB()
        {
            MyAuto = new Car();
            NumberOfCars = 5;
        }
        public GarageB(Car car, int number)
        {
            MyAuto = car;
            NumberOfCars = number;
        }
    }

    class Garage
    {
        // The hidden int backing field is set to zero!
        public int NumberOfCars { get; set; }
        // The hidden Car backing field is set to null!
        public Car MyAuto { get; set; }
    }
}
