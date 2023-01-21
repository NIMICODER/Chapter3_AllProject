namespace OopExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Fun with OOP examples ---");
            // Call is forwarded to Radio internally.
            Car viper = new Car();
            viper.TurnOnRadio(false);

        }
    }

    public class SportsCar
    {
        // OK! Nested types can be marked private.
        private enum CarColor
        {
            Red, Green, Blue
        }
    }

    class Radio
    {
        public void Power(bool turnOn)
        {
            Console.WriteLine("Radio on: {0}", turnOn);
        }
    }

    class Car
    {
        // Car 'has-a' Radio.
        private Radio myRadio = new Radio();
        public void TurnOnRadio(bool onOff)
        {
            // Delegate call to inner object.
            myRadio.Power(onOff);
        }
    }
}