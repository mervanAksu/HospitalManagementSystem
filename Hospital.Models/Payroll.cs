namespace Hospital.Models
{
	public class Payroll
	{
		public int Id { get; set; }
        public ApplicationUser? EmployeeId { get; set; }
        public decimal? Salary { get; set; }        // Maaş
        public decimal? NetSalary { get; set; }     // Net Maaş
        public decimal? HourlySalary { get; set; }  // Saatlik Ücret
        public decimal? BonusSalary { get; set; }   // Bonus Maaş
        public decimal? Compensation { get; set; }  // Tazminat
        public string? AccountNumber { get; set; }  // Hesap Numarası
    }
}