using employee;

namespace Labb_6_OOP_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Employee> employees = new Stack<Employee>();

            employees.Push(new Employee(1, "Anna", "Female", 2m));
            employees.Push(new Employee(2, "Ali", "Male", 1m));
            employees.Push(new Employee(3, "Anders", "Male", 3m));
            employees.Push(new Employee(4, "Felicia", "Female", 4m));
            employees.Push(new Employee(5, "Frida", "Female", 6m));

            
            foreach (Employee e in employees)
            {
                Console.WriteLine(e.Name);
                Console.WriteLine(e.Id);
                Console.WriteLine(e.Salary);
                Console.WriteLine(e.Gender);
                Console.WriteLine(employees.Count);
            }

            
            while (employees.Count > 0)
            {
                Employee person = employees.Pop();

                Console.WriteLine(person.Name);
                Console.WriteLine(person.Id);
                Console.WriteLine(person.Salary);
                Console.WriteLine(person.Gender);
                Console.WriteLine(employees.Count);
            }

            
            employees.Push(new Employee(1, "Anna", "Female", 2m));
            employees.Push(new Employee(2, "Ali", "Male", 1m));
            employees.Push(new Employee(3, "Anders", "Male", 3m));
            employees.Push(new Employee(4, "Felicia", "Female", 4m));
            employees.Push(new Employee(5, "Frida", "Female", 6m));

            
            Employee personPeek = employees.Peek();
            Console.WriteLine(personPeek.Name);
            Console.WriteLine(employees.Count);

            
            personPeek = employees.Peek();
            Console.WriteLine(personPeek.Name);
            Console.WriteLine(employees.Count);

            List<Employee> employees1 = new List<Employee>();
            employees1.Add(new Employee(1, "Hanna", "Female", 2m));
            employees1.Add(new Employee(2, "Zlatan", "Male", 4m));
            employees1.Add(new Employee(3, "Lina", "Female", 6m));
            employees1.Add(new Employee(4, "Ronaldo", "Male", 8m));
            employees1.Add(new Employee(5, "Lena", "Female", 10m));

            Employee search = employees1[1];
            bool exists = employees1.Contains(search);
            Console.WriteLine(exists);


            if (exists)
            {
                Console.WriteLine("Employee2 object exists in the list");
            }

            else
            {
                Console.WriteLine("Employee2 object does not exist in the list");
            }

            List<Employee> find = employees1.FindAll(e => e.Gender == "Male");
            Console.WriteLine("FindAll");

            foreach (Employee employee in find)
            {
                Console.WriteLine(employee.Name);
            }


           

        }
    }
}