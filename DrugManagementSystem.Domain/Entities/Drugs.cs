using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugManagementSystem.Domain.Entities
{
    public class Drugs
    {
        public int DrugID { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public string Description { get; set; }
        public string ChemicalAnalysis { get; set; }
    }
}
