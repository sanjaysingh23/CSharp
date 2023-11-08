using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_App_Curd
{
     class MockEmployeeRepository : IEmployeeRepository
    {
        public static List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){ id = 1, name = "arun", salary = 50000, address = "Jarua"},
                new Employee(){id = 2, name = "ajay", salary = 40000, address = "Agra"},
                new Employee(){id = 3, name = "reetesh", salary = 60000, address = "Jarua katra"},
                new Employee(){id = 4, name = "saurabh", salary = 35000, address = "Mathura"},
            };

        }
        public Employee Add(Employee employee)
        {
            employee.id = _employeeList.Max(x => x.id)+1;
            return employee;

        }

        public Employee Delete(int Id)
        {
            Employee Emp = _employeeList.FirstOrDefault(n => n.id == Id);
            if (Emp != null)
            {
                _employeeList.Remove(Emp);
            }
            return Emp;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            Employee employee = _employeeList.FirstOrDefault(n => n.id==Id);
            return employee;
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeeList.FirstOrDefault(x => x.id == employeeChanges.id);
            if (employee != null)
            {
                employee.id = employeeChanges.id;
                employee.name = employeeChanges.name;
                employee.address = employeeChanges.address;
                employee.salary = employeeChanges.salary;
            }
            return employee;
        }
    }
}
