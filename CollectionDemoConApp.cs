using System.Collections;

namespace CollectionDemoConApp;
class Program
{
    class Employee
    {
        public int id;
        public string name;
        public int age;
        public float salary;
        public string gender;

        public Employee(int i, string n, int a, float sal, string g)
        {
            this.id = i;
            this.name = n;
            this.age = a;
            this.salary = sal;
            this.gender = g;
        }
    }




    static void Main(string[] args)
    {

        List<Employee> employees = new List<Employee>() {
        new Employee(1, "John Smith", 40, 5000, "male"),
        new Employee(2, "Vanessa Baker", 30, 6000, "female"),
        new Employee(3, "Austin McLean", 20, 4000, "male"),
        new Employee(4, "Trish Stone", 36, 6000, "female"),
        new Employee(5, "Karen Brown", 28, 5750, "female")
    };
     
        foreach (Employee e in employees)
        {
            Console.WriteLine("ID: {0} \tName: {1} \tAge: {2} \tSalary: {3} \t Gender: {4}",e.id,e.name,e.age,e.salary,e.gender);
        }
    }
}

