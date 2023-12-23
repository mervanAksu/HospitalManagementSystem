using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
	public class ApplicationUser : IdentityUser
	{
        public string? Name { get; set; }
        public Gender? Gender { get; set; }
        public string? Nationality { get; set; }
        public string? Address { get; set; }
        public DateTime? DOB { get; set; } // DOB = Date of Birth - Dogum Tarihi
        public string? Specialist { get; set; } // Uzmanlık - uzman
        public bool IsDoctor { get; set; }
        public Department? Department { get; set; }
        [NotMapped]
        public ICollection<Appointment>? Appointments { get; set; }
        [NotMapped]
        public ICollection<Payroll>? Payrolls { get; set; } // Payroll - Maaş Bordrosu
    }
}

namespace Hospital.Models
{
	public enum Gender
	{
		Male, Female, Other
	}
}