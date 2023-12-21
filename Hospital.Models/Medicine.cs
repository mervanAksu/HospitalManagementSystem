using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
	public class Medicine	// İlaç Tablosu
	{
		public int Id { get; set; }	
		public string? Name { get; set; }	// İlaç ismi
		public string? Type { get; set; }	// İlaç Türü
		public decimal? Cost { get; set; }	// İlaç fiyatı
		public string? Description { get; set; }	// Açıklaması
        public ICollection<MedicineReport>? MedicineReports { get; set; }
        public ICollection<PrescribedMedicine>? PrescribedMedicines { get; set; }
    }
}
