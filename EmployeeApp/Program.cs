namespace EmployeeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var employee = new EmployeeB();
            ////employee._empName = "Marv";

            //employee.DisplayStats();

            //Console.WriteLine("***** Fun with Encapsulation *****\n");
            //var employeeA = new Employee();
            //employeeA.SetName("David");
            //Console.WriteLine($"Employee is named: {employeeA.GetName()}" );
            ////employeeA.GetName();
            //Console.ReadLine();


           
            //Console.WriteLine("***** Fun with Encapsulation *****\n");
            //var employ = new EmployeeC();
            //employ.GiveBonus(1000);
            //employ.DisplayStats();
            //// Reset and then get the Name property.
            //employ.Name = "David";
            //Console.WriteLine("Employee is named: {0}", employ.Name);
            //Console.ReadLine();

            Console.WriteLine("***** Fun with Encapsulation *****\n");
            var emp = new EmployeeD();
            emp.Age = 28;
            emp.name = "David";
            
            emp.DisplayStats();
        }
    }

    class EmployeeD
    {
        private string _empName;
        private int _empId;
        private float _currPay;

        // New field and property.
        private int _empAge;
        public int Age
        {
            get { return _empAge; }
            set { _empAge = value; }
        }
        public string name
        {
            get { return _empName; }
            set { _empName = value; }
        }
        // Updated constructors.
        public EmployeeD() { }
        public EmployeeD(string name, int id, float pay)
        : this(name, 0, id, pay) { }
        public EmployeeD(string name, int age, int id, float pay)
        {
            _empName = name;
            _empId = id;
            _empAge = age;
            _currPay = pay;
        }
        // Updated DisplayStats() method now accounts for age.
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", _empName);
            Console.WriteLine("ID: {0}", _empId);
            Console.WriteLine("Age: {0}", _empAge);
            Console.WriteLine("Pay: {0}", _currPay);
        }
    }

    class EmployeeC
    {
        // Field data.
        private string _empName;
        private int _empId;
        private float _currPay;
        // Properties!
        public string Name
        {
            get { return _empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else
                {
                    _empName = value;
                }
            }
        }
        // We could add additional business rules to the sets of these properties;
        // however, there is no need to do so for this example.
        public int Id
        {
            get { return _empId; }
            set { _empId = value; }
        }
        public float Pay
        {
            get { return _currPay; }
            set { _currPay = value; }
        }

        public void GiveBonus(float amount) => _currPay += amount;
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", _empName);
            Console.WriteLine("ID: {0}", _empId);
            Console.WriteLine("Pay: {0}", _currPay);
        }
    }

    class Employee
    {
        // Field data.
        private string _employeeName;
        // Accessor (get method).
        public string GetName() => _employeeName;
        // Mutator (set method).
        public void SetName(string name)
        {
            // Do a check on incoming value
            // before making assignment.
            if (name.Length > 15)
            {
                Console.WriteLine("Error! Name length exceeds 15 characters!");
            }
            else
            {
                _employeeName = name;
            }
        }
    }



    class EmployeeB
    {
        // Field data.
        private string _empName;
        private int _empId;
        private float _currPay;
        // Constructors.
        public EmployeeB() { }
        public EmployeeB(string name, int id, float pay)
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
}