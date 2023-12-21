using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
	public class PatientReport      // Hasta Raporu
	{
        public int Id { get; set; }
        public string? Diagnose { get; set; }           // Konulan Teşhis
        public ApplicationUser? Doctor { get; set; }    
        public ApplicationUser? Patient { get; set; }
        public ICollection<PrescribedMedicine>? PrescribedMedicines { get; set; }   // Hastanın birden fazla reçeteli ilacı olabilir.
    }
}
