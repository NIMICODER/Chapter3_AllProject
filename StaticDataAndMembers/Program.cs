using static System.Console;
using static System.DateTime;

namespace StaticDataAndMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("***** Fun with Static Data *****\n");
            //SavingsAccount s1 = new SavingsAccount(50);
            //SavingsAccount s2 = new SavingsAccount(100);
            //SavingsAccount s3 = new SavingsAccount(10000.75);
            //Console.WriteLine(s1._currBalance);
            //Console.WriteLine(s2._currBalance);
            //Console.WriteLine(s3._currBalance);
            //Console.ReadLine();




            //Console.WriteLine("***** Fun with Static Data *****\n");
            //var s1 = new SavingsAccountC(50);
            //var s2 = new SavingsAccountC(100);
            //// Print the current interest rate.
            //Console.WriteLine("Interest Rate is: {0}", SavingsAccountC.GetInterestRate());
            //// Make new object, this does NOT 'reset' the interest rate.
            //SavingsAccount s3 = new SavingsAccount(10000.75);
            //Console.WriteLine("Interest Rate is: {0}", SavingsAccountC.GetInterestRate());
            //Console.ReadLine();

            //Console.WriteLine();

            //// Make an account.
            //var s1C = new SavingsAccountC(50);
            //// Print the current interest rate.
            //Console.WriteLine("Interest Rate is: {0}", SavingsAccountC.GetInterestRate());
            //// Try to change the interest rate via property.
            //SavingsAccountC.SetInterestRate(0.08);
            //SavingsAccountC.SetInterestRate(0.10000);
            //// Make a second account.
            //var s2C = new SavingsAccountC(100);
            //// Should print 0.08...right??
            //Console.WriteLine("Interest Rate is: {0}", SavingsAccountC.GetInterestRate());
            //Console.ReadLine();

            TimeUtilClass.PrintTime();
        }


    }

    // Static classes can only
    // contain static members!
    static class TimeUtilClass
    {
        public static void PrintTime()
        => Console.WriteLine(DateTime.Now.ToShortTimeString());
        public static void PrintDate()
        => Console.WriteLine(DateTime.Today.ToShortDateString());
    }

    class SavingsAccount
    {
        // Instance-level data.
        public double _currBalance;
        public SavingsAccount(double balance)
        {
            _currBalance = balance;
        }
    }

    class SavingsAccountB
    {
        // A static point of data.
        public static double currInterestRate = 0.04;
        // Instance-level data.
        public double currBalance;
        public SavingsAccountB(double balance)
        {
            currBalance = balance;
        }
    }

    class SavingsAccountC
    {
        // Instance-level data.
        public double currBalance;
        // A static point of data.
        public static double currInterestRate = 0.04;
        public SavingsAccountC(double balance)
        {
            currBalance = balance;
        }
        // Static members to get/set interest rate.
        public static void SetInterestRate(double newRate)
        => currInterestRate = newRate;
        public static double GetInterestRate()
        => currInterestRate;
    }

    //class SavingsAccountD
    //{
    //    public double currBalance;
    //    public static double currInterestRate;
    //    // Notice that our constructor is setting
    //    // the static currInterestRate value.
    //    public SavingsAccountD(double balance)
    //    {
    //        currInterestRate = 0.04; // This is static data!
    //        currBalance = balance;
    //    }
    //}

    static class MyName
    {

    }
}