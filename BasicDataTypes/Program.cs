using System.Runtime.CompilerServices;
using System.Text;

namespace BasicDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Basic Data Types *****");
            //LocalVarDeclarations();
            //LocalVarDeclarationsB();
            //DefaultDeclarations();
            //UseDatesAndTimes();
            //UseDatesAndTimesA();
            //BasicStringFunctionality();
            //EscapeChars();
            //StringInterpolation();
            //StringInterpolationWithDefaultInterpolatedStringHandler();
           // FunWithStringBuilder();
            LinqQueryOverInts();

        }

        static void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            // LINQ query!
            var num = numbers.Where(x => x < 10);
            //var subset = from i in numbers where i < 10 select i;
            Console.Write("Values in subset: ");
            foreach (var i in num)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            // Hmm...what type is subset?
            Console.WriteLine("subset is a: {0}", num.GetType().Name);
            Console.WriteLine("subset is defined in: {0}", num.GetType().Namespace);
        }

        static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Using the StringBuilder:");
            StringBuilder sb = new StringBuilder("**** Fantastic Games ****");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Deus Ex" + "2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", " Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);
            Console.WriteLine();
        }

        static void StringInterpolationWithDefaultInterpolatedStringHandler()
        {
            Console.WriteLine("=> String interpolation under the covers:\a");
            int age = 4;
            string name = "Soren";
            var builder = new DefaultInterpolatedStringHandler(3, 2);
            builder.AppendLiteral("\tHello ");
            builder.AppendFormatted(name);
            builder.AppendLiteral(" you are ");
            builder.AppendFormatted(age);
            builder.AppendLiteral(" years old.");
            var greeting = builder.ToStringAndClear();
            Console.WriteLine(greeting);
        }

        static void StringInterpolation()
        {
            Console.WriteLine("=> String interpolation:\a");
            // Some local variables we will plug into our larger string
            int age = 4;
            string name = "Soren";
            // Using curly-bracket syntax.
            string greeting = string.Format("Hello {0} you are {1} years old.", name, age);
            Console.WriteLine(greeting);
            // Using string interpolation
            string greeting2 = $"Hello {name} you are {age} years old.";
            Console.WriteLine(greeting2);
        }

        static void EscapeChars()
        {
            Console.WriteLine("=> Escape characters:");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name ";
            Console.WriteLine(strWithTabs);
            Console.WriteLine("Everyone loves \n \"Hello World\" ");
            Console.WriteLine("C:\\MyApp\\bin\\Debug ");
            // Adds a total of 4 blank lines (3 escaped, 1 from WriteLine).
            Console.WriteLine("All finished.\n\n\n ");
            Console.WriteLine("space");
        }
        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String functionality:");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine($"Value of firstName: {firstName}");
            Console.WriteLine();
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y?: {0}",
            firstName.Contains("y"));
            Console.WriteLine("New first name: {0}", firstName.Replace("dy", ""));
            Console.WriteLine();
        }

        static void UseDatesAndTimesA()
        {
            Console.WriteLine("=> Dates and Times:");
            
            DateOnly d = new DateOnly(2021, 07, 21);
            Console.WriteLine(d);
            TimeOnly t = new TimeOnly(13, 30, 0, 0);
            Console.WriteLine(t);
        }
        static void UseDatesAndTimes()
        {
            Console.WriteLine("=> Dates and Times:");
            // This constructor takes (year, month, day).
            DateTime dt = new DateTime(2015, 10, 17);
            // What day of the month is this?
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
            // Month is now December.
            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
            // This constructor takes (hours, minutes, seconds).
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);
            // Subtract 15 minutes from the current TimeSpan and
            // print the result.
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
        }

        static void LocalVarDeclarations()
        {
            Console.WriteLine("=> Data Declarations:");
            // Local variables are declared as so:
            // dataType varName;
            int myInt;
            string myString;
            Console.WriteLine();
        }

        static void LocalVarDeclarationsB()
        {
            Console.WriteLine("=> Data Declarations:");
            // Local variables are declared and initialized as follows:
            // dataType varName = initialValue;
            int myInt = 0;
            // You can also declare and assign on two lines.
            string myString;
            myString = "This is my character data";
            Console.WriteLine();
        }

        static void DefaultDeclarations()
        {
            Console.WriteLine("=> Default Declarations:");
            int myInt = default;
            Console.WriteLine(myInt);
        }
    }

}