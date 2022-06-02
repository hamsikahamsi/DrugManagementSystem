using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugManagementSystem.Domain.Entities
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public decimal PhoneNo { get; set; }
        public string EmailID { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string Designation { get; set; }
        public int DepartmentID { get; set; }
    }
}
