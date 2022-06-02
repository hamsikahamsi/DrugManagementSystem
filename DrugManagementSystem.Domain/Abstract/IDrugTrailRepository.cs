using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrugManagementSystem.Domain.Entities;

namespace DrugManagementSystem.Domain.Abstract
{
    public interface IDrugTrailRepository
    {
        IEnumerable<DrugTrail> DrugTrails { get; }
    }
}
