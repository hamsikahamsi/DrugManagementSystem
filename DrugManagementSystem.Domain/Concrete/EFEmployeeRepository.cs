using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrugManagementSystem.Domain.Abstract;
using DrugManagementSystem.Domain.Entities;


namespace DrugManagementSystem.Domain.Concrete
{
    public class EFEmployeeRepository:IEmployeeRepository
    {
        private DrugEFDbContext context = new DrugEFDbContext();
        public IEnumerable<Employee> Employees => context.Employees;

    }
}
