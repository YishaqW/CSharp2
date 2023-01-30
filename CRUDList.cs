using System.Collections;

namespace CRUDList;
class Program
{

    class Employee
    {
        public string name;
        public string designation;
        public int salary;
        public string joinDate;

        public Employee(string n, string d, int s,string jD)
        {
            this.name =n;
            this.designation =d;
            this.salary = s;
            this.joinDate = jD;
        }
    }


    static void Main(string[] args)
    {

        List<Employee> employees = new List<Employee>()
        {
        new Employee("John Smith", "Manager", 5000, "male"),
        new Employee("Vanessa Baker", "CFO", 6000, "female"),
        new Employee("Austin McLean", "Reception", 4000, "male"),
        new Employee("Trish Stone", "Director", 6000, "female"),
        new Employee("Karen Brown", "Analyst", 5750, "female")
        };

        foreach (Employee e in employees)
        {
            Console.WriteLine("Employee names are: {0}",e.name);
        }



        // Add new employee
        List<Employee> employees2 = new List<Employee>()
        {
            new Employee("Jacob Johnson", "Security", 3500, "male")
        };

        employees.AddRange(employees2);

       

        //Update Employee
        Employee employee = employees.Find(e => e.salary < 4000);
        employee.name = "Jacob James";

        Console.WriteLine(employee.name);

        
        // Remove employee
        employees.RemoveAt(5);

       

    }
}

