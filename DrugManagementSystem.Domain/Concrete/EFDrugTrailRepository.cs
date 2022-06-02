using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrugManagementSystem.Domain.Abstract;
using DrugManagementSystem.Domain.Entities;

namespace DrugManagementSystem.Domain.Concrete
{
    public class EFDrugTrailRepository:IDrugTrailRepository
    {
        private DrugTrailEFDbContext context = new DrugTrailEFDbContext();
      

        public IEnumerable<DrugTrail> DrugTrails => context.DrugTrails;
    }
}
