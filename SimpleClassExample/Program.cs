namespace SimpleClassExample
{
    internal partial class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine();

            var c = new MotorcycleB();
            c.SetDriverName("Tiny", 50);
            c.PopAWheely();
            Console.WriteLine($"Rider name is {c._name}"); // Prints an empty name value!
            Console.WriteLine();
            var bike = new Motorcycle();
            bike.PopAWheely();
            Console.WriteLine();

            Console.WriteLine("***** Fun with Class Types *****\n");
            // Invoking the default constructor.
            Car chuck = new Car();
            // Prints "Chuck is going 10 MPH."
            chuck.PrintState();
            Console.WriteLine();

            var car = new Car();
            car.carName = "Toyota";
            Console.WriteLine($"my car name is : {car.carName}");

            Console.WriteLine("***** Fun with Class Types *****\n");
            // Allocate and configure a Car object.
            Car myCar = new Car();
            myCar.carName = "Henry";
            myCar.currentSpeed = 10;
            // Speed up the car a few times and print out the
            // new state.
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }
            Console.ReadLine();

        }
    }
}