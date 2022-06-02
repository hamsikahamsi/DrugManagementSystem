﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrugManagementSystem.Domain.Entities;
using System.Data.Entity;

namespace DrugManagementSystem.Domain.Concrete
{
    public class DrugEFDbContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
