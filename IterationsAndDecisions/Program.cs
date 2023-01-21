namespace IterationsAndDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoopExample();
            //ForEachLoopExample();
            //LinqQueryOverInts();

            //WhileLoopExample();
            //DoWhileLoopExample();

            SwitchExample();
        }

        // Switch on a numerical value.
        static void SwitchExample()
        {
            try
            {
                Console.WriteLine("1 [C#], 2 [VB]");
                Console.Write("Please pick your language preference: ");
                string langChoice = Console.ReadLine();
                int n = int.Parse(langChoice);
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Good choice, C# is a fine language.");
                        break;
                    case 2:
                        Console.WriteLine("VB: OOP, multithreading, and more!");
                        break;
                    default:
                        Console.WriteLine("Wrong input...");
                        SwitchExample();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("incorrect selection, Try again");
                SwitchExample();
            }
        }

        //Using the while and do/while Looping Constructs

        static void DoWhileLoopExample()
        {
            string userIsDone = "";
            do
            {
                Console.WriteLine("In do/while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            } while (userIsDone.ToLower() != "yes"); // Note the semicolon!
        }

        static void WhileLoopExample()
        {
            try
            {
                string userIsDone = "";
                // Test on a lower-class copy of the string.
                while (userIsDone.ToLower() != "yes")
                {
                    Console.WriteLine("In while loop");
                    Console.Write("Are you done? [yes] [no]: ");
                    userIsDone = Console.ReadLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Enter correct input");
            }
        }

        //Using Implicit Typing Within foreach Constructs
        static void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            // LINQ query!
            var subset =  numbers.Where(x => x < 10);
            Console.Write("Values in subset: ");
            foreach (var i in subset)
            {
                Console.Write("{0} ", i);
            }
        }

        //Using the foreach Loop
        static void ForEachLoopExample()
        {
            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
            foreach (string c in carTypes)
            {
                Console.WriteLine("The car brands are: " + c);
            }
            int[] myInts = { 10, 20, 30, 40 };
            foreach (int i in myInts)
            {
                Console.WriteLine("The numbers in the array are: " + i);
            }
        }

        //Using FORLOOP
        static void ForLoopExample()
        {
            // Note! "i" is only visible within the scope of the for loop.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Number is: {0} ", i);
            }
            // "i" is not visible here.
        }
    }
}