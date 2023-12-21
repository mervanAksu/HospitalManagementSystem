using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
	public class Supplier   // İlaç Tedarikçisi
	{
        public int Id { get; set; }
        public string? Company { get; set; }    // Şirket
        public string? Phone { get; set; }      // Telefon Numarası
        public string? Email { get; set; }      // Email
        public string? Address { get; set; }    // Şirket Adresi
        public ICollection<MedicineReport>? MedicineReports { get; set; }
    }
}
