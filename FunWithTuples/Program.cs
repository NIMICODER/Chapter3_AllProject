namespace FunWithTuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var values = ("a", 5, "c");

            //Console.WriteLine($"First item: {values.Item1}");
            //Console.WriteLine($"Second item: {values.Item2}");
            //Console.WriteLine($"Third item: {values.Item3}");

            //var valuesWithNames = (FirstLetter: "a", TheNumber: 5, SecondLetter: "c");

            //Console.WriteLine($"First item: {valuesWithNames.FirstLetter}");
            //Console.WriteLine($"Second item: {valuesWithNames.TheNumber}");
            //Console.WriteLine($"Third item: {valuesWithNames.SecondLetter}");
            ////Using the item notation still works!
            //Console.WriteLine($"First item: {valuesWithNames.Item1}");
            //Console.WriteLine($"Second item: {valuesWithNames.Item2}");
            //Console.WriteLine($"Third item: {valuesWithNames.Item3}");
            var samples = FillTheseValues();
            Console.WriteLine($"Int is: {samples.a}");
            Console.WriteLine($"String is: {samples.b}");
            Console.WriteLine($"Boolean is: {samples.c}");

        }

        static string RockPaperScissors( (string first, string second) value)
        {
            return value switch
            {
                //omitted for brevity
            };
        }

        //Tupleswithswitch
        static string RockPaperScissors(string first, string second)
        {
            return (first, second) switch
            {
                ("rock", "paper") => "Paper wins.",
                ("rock", "scissors") => "Rock wins.",
                ("paper", "rock") => "Paper wins.",
                ("paper", "scissors") => "Scissors wins.",
                ("scissors", "rock") => "Rock wins.",
                ("scissors", "paper") => "Scissors wins.",
                (_, _) => "Tie.",
            };
        }

        static (int a, string b, bool c) FillTheseValues()
        {
            return (9, "Enjoy your string.", true);
        }
    }
}