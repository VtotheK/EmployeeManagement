using System;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee{Id=1,Name="Ville",Email="KurwaMac@gmail.com",Department=Dept.IT},
                new Employee{Id=2,Name="Juite",Email="Karvaperse@gmail.com",Department=Dept.None},
                new Employee{Id=3,Name="Joona",Email="Joonane@gmail.com",Department=Dept.Payroll}
            };
        }
        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(emp => emp.Id == id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee Add(Employee employee)
        {
            int maxId = _employeeList.Max((x) => x.Id);
            employee.Id = ++maxId;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Update(Employee employee)
        {
            Employee emp = _employeeList.FirstOrDefault(e => e == employee);
            if (emp != null)
            {
                emp.Name= employee.Name;
                emp.Email = employee.Email;
                emp.Department = employee.Department;
            }
            return emp;
        }

        public Employee Delete(int id)
        {
            Employee emp = _employeeList.FirstOrDefault(e => e.Id == id);
            if(emp != null)
            {
                _employeeList.Remove(emp);
            }
            return emp;
        }
    }
}
