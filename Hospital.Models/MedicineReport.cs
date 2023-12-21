using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
	public class MedicineReport		// İlaç ve tedarikçi arasındaki  tablo
	{
		public int Id { get; set; }
		public Supplier? Supplier { get; set; }		// Tedarikçi
		public Medicine? Medicine { get; set; }		// İlaç
		public string? Company { get; set; }		// Şirket
		public int? Quantity { get; set; }			// Adet 
		public DateTime? ProductionDate { get; set; }	// Üretim Tarihi
		public DateTime? ExpireDate { get; set; }		// Son Kullanım Tarihi
		public string? Country { get; set; }			// Üretildiği Ülke
	}
}
