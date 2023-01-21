Console.WriteLine("***** Basic Console I/O *****");
GetUserData();
ObjectFunctionality();
Console.ReadLine();
static void GetUserData()
{
    // Get name and age.
    Console.Write("Please enter your name: ");
    string? userName = Console.ReadLine();
    Console.Write("Please enter your age: ");
    string? userAge = Console.ReadLine();
    // Change echo color, just for fun.
    ConsoleColor prevColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;
    // Echo to the console.
    Console.WriteLine("Hello {0}! You are {1} years old.",
    userName, userAge);
    // Restore previous color.
    Console.ForegroundColor = prevColor;
}

static void ObjectFunctionality()
{
    Console.WriteLine("=> System.Object Functionality:");
    // A C# int is really a shorthand for System.Int32,
    // which inherits the following members from System.Object.
    Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
    Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
    Console.WriteLine("12.ToString() = {0}", 12.ToString());
    Console.WriteLine("12.GetType() = {0}", 12.GetType());
    Console.WriteLine();
}