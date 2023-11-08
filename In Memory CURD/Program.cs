namespace CL_App_Curd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MockEmployeeRepository mockEmployeeRepository = new MockEmployeeRepository();
            
            Employee e = mockEmployeeRepository.Add(new Employee { name="vijay",salary = 65000, address = "Banglore"});
            Console.WriteLine("Added Employe is {0} {1} {2} {3} ",e.id,e.name, e.salary, e.address);

            Employee e1 = mockEmployeeRepository.Delete(2);
            Console.WriteLine("Deleted Employee is {0} {1} {2} {3} ", e1.id, e1.name, e1.salary, e1.address);

            foreach(Employee emp in mockEmployeeRepository.GetAllEmployee())
            {
                Console.WriteLine("{0} {1} {2} {3} ", emp.id, emp.name, emp.salary, emp.address);
            }
            
            Employee e2 = mockEmployeeRepository.GetEmployee(4);
            Console.WriteLine("Searcher Employee {0} {1} {2} {3} ", e2.id, e2.name, e2.salary, e2.address);

            Employee e3= mockEmployeeRepository.Update(new Employee { id = 3, name = "rohit", salary = 30000, address = "Rohta" });
            Console.WriteLine("Updated data of employee {0} {1} {2} {3} ", e3.id, e3.name, e3.salary, e3.address);

            Console.WriteLine("=================== Updated list ======================");

            foreach( Employee emp in mockEmployeeRepository.GetAllEmployee())
            {
                Console.WriteLine("{0} {1} {2} {3} ", emp.id, emp.name, emp.salary, emp.address);
            }

        }
    }
}