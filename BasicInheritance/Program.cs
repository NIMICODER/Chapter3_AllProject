namespace BasicInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Inheritance *****\n");
            // Make a Car object, set max speed and current speed.
            var myCar = new Car(80) { _currSpeed = 50 };
            // Print current speed.
            Console.WriteLine("My car is going {0} MPH", myCar._currSpeed);
            Console.ReadLine();



            Console.WriteLine("***** Basic Inheritance *****\n");
            // Now make a MiniVan object.
            var myVan = new MiniVan { _currSpeed = 10 };
            Console.WriteLine("My van is going {0} MPH", myVan._currSpeed);
            Console.ReadLine();
        }
    }

    class Car
    {
        public readonly int MaxSpeed;
        //private int _currSpeed;
        public int _currSpeed { get;  set; }
        public Car(int max)
        {
            MaxSpeed = max;
        }
        public Car()
        {
            MaxSpeed = 55;
        }
        //public int Speed
        //{
        //    get { return _currSpeed; }
        //    set
        //    {
        //        _currSpeed = value;
        //        if (_currSpeed > MaxSpeed)
        //        {
        //            _currSpeed = MaxSpeed;
        //        }
        //    }
        //}
    }

    class MiniVan: Car
    {


    }
}