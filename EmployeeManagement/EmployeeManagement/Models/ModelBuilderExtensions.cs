using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = -1,
                    Name = "Kulli Hirvi",
                    Email = "HulliKirvi@gmail.com",
                    Department = Dept.Payroll
                },
                new Employee
                {
                    Id = -2,
                    Name = "Juite Mäkinen",
                    Email = "DuonVessa@gmail.com",
                    Department = Dept.Hr
                });
        }
    }
}
