
using System.Reflection;


namespace MyTypeViewer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\nEnter a type name to evaluate");
                Console.Write("or enter Q to quit: ");
                // Get name of type.
                string typeName = Console.ReadLine();
                // Does user want to quit?
                if (typeName.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                // Try to display type.
                try
                {
                    Type t = Type.GetType(typeName);
                    Console.WriteLine("");
                    //ListMethodsB(t);
                    ListFields(t);
                    ListMethods(t);
                    ListProperties(t);
                }
                catch
                {
                    Console.WriteLine("Sorry, can't find type");
                }
            } while (true);
        }

        // Display method names of type.
        static void ListMethods(Type t)
        {
            Console.WriteLine("***** Methods *****");
            MethodInfo[] mi = t.GetMethods();
            foreach (MethodInfo m in mi)
            {
                Console.WriteLine("->{0}", m.Name);
            }
            Console.WriteLine();
        }

        static void ListMethodsB(Type t)
        {
            Console.WriteLine("***** Methods *****");
            var methodNames = from n in t.GetMethods() orderby n.Name select n.Name;
            // Using LINQ extensions:
            // var methodNames = t.GetMethods().OrderBy(m=>m.Name).Select(m=>m.Name);
            foreach (var name in methodNames)
            {
                Console.WriteLine("->{0}", name);
            }
            Console.WriteLine();
        }

        // Display field names of type.
        static void ListFields(Type t)
        {
            Console.WriteLine("***** Fields *****");
            // var fieldNames = from f in t.GetFields() orderby f.Name select f.Name;
            var fieldNames = t.GetFields().OrderBy(m => m.Name).Select(x => x.Name);
            foreach (var name in fieldNames)
            {
                Console.WriteLine("->{0}", name);
            }
            Console.WriteLine();
        }

        static void ListProperties(Type t)
        {
            Console.WriteLine("***** properties *****");

            var propNames = t.GetProperties().OrderBy(x => x.Name).Select(x => x.Name);
            foreach (var name in propNames)
            {
                var property = t.GetProperty(name);
            }
        }
    }
}