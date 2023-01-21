using System.Drawing;

namespace FunWithPartials
{
   

    public partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SayHello());
        }
        public static string SayHello() 
        {
            return "Hello";
            
        }
    }
}