using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugManagementSystem.Domain.Entities
{
    public class DrugTrail
    {
        public int ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PurposeOfTrail { get; set; }
        public int InvestigatorID { get; set; }
        public int PatientID { get; set; }
        public int DrugID { get; set; }
        public string TrailResults { get; set; }
        public string TrailStatus { get; set; }
    }
}
