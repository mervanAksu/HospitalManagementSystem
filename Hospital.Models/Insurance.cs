using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
	public class Insurance		// Sigorta
	{
        public int Id { get; set; }
        public string? PolicyNumber { get; set; }       // Poliçe Numarası
        public string? StartDate { get; set; }          // Başlangıç Tarihi
        public string? EndDate { get; set; }            // Bitiş Tarihi
        public ICollection<Bill>? Bill { get; set; }
    }
}
