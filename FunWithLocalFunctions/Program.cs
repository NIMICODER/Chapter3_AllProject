using System.Diagnostics.CodeAnalysis;

namespace FunWithLocalFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Methods *****");
            //string str1 = "Flip";
            //string str2 = "Flop";
            //Console.WriteLine("Before: {0}, {1} ", str1, str2);
            //SwapStrings(ref str1, ref str2);
            //Console.WriteLine("After: {0}, {1} ", str1, str2);
            //Console.ReadLine();
            DisplayFancyMessage( ConsoleColor.Blue, ConsoleColor.Red, "My name is David");



        }

        static void DisplayFancyMessage(ConsoleColor textColor,
             ConsoleColor backgroundColor, string message)
        {
            // Store old colors to restore after message is printed.
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldbackgroundColor = Console.BackgroundColor;
            // Set new colors and print message.
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);

            // Restore previous colors.
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldbackgroundColor;
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
        private static void Process(string?[] lines, string mark)
        {
            foreach (var line in lines)
            {
                if (IsValid(line))
                {
                    // Processing logic...
                }
            }
            bool IsValid([NotNullWhen(true)] string? line)
            {
                return !string.IsNullOrEmpty(line) && line.Length >= mark.Length;
            }
        }

        static int AddWrapper(int x, int y)
        {
            //Do some validation here
            return Add();
            int Add()
            {
                return x + y;
            }
        }


    }
}