namespace Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a subclass object and access base class functionality.
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            SalesPerson fred = new SalesPerson
            {
                //Age = 31,
                Name = "Fred",
                SalesNumber = 50
            };
        }
    }

    partial class Employees
    {
        // Field data
        // Properties
    }

    class Employee
    {
        // Field data.
        private string _empName;
        private int _empId;
        private float _currPay;
        // Constructors.
        public Employee() { }
        public Employee(string name, int id, float pay)
        {
            _empName = name;
            _empId = id;
            _currPay = pay;
        }
        // Methods.
        public void GiveBonus(float amount) => _currPay += amount;
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", _empName);
            Console.WriteLine("ID: {0}", _empId);
            Console.WriteLine("Pay: {0}", _currPay);
        }
    }

    class Manager : Employee
    {
        public int StockOptions { get; set; }
    }

    class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }
    }


    public enum EmployeePayTypeEnum
    {
        Hourly,
        Salaried,
        Commission
    }
}