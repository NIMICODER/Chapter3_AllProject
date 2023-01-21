namespace PolymorphicShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Polymorphism *****\n");
            var hex = new Hexagon("Beth");
            hex.Draw();
            var cir = new Circle("Cindy");
            // Calls base class implementation!
            cir.Draw();
            Console.ReadLine();
        }
    }

    abstract class Shape
    {
        public string PetName { get; set; }

        protected Shape(string name = "NoName")
        {
            PetName = name;
        }
       
        // A single virtual method.
        public virtual void Draw()
        {
            Console.WriteLine("Inside Shape.Draw()");
        }
    }

    class Circle : Shape
    {
        public Circle() { }
        public Circle(string name) : base(name) { }
    }

    class Hexagon : Shape
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon here", PetName);
        }
    }
}