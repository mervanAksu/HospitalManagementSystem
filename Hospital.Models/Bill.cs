namespace Hospital.Models
{
	public class Bill			// Fatura 
	{
		public int Id { get; set; }
        public int? BillNumber { get; set; }            // Fatura Numarası
        public ApplicationUser? Patient { get; set; }
        public Insurance? Insurance { get; set; }
		public int? DoctorCharge { get; set; }          // Doktor Ücreti
        public decimal? MedicineCharge { get; set; }    // İlaç Ücreti
        public decimal? RoomCharge { get; set; }        // Yatak Ücreti
        public decimal? OperationCharge { get; set; }   // İşlem(ameliyat vs.) Ücreti
        public int? NoOfDays { get; set; }              // Yatılan Gün Sayısı
        public int? NursingCharge { get; set; }         // Bakım Ücreti
        public int? LabCharge { get; set; }             // Laboratuvar Ücreti
        public decimal? Advance { get; set; }           // Avans
        public decimal? TotalBill { get; set; }         // Toplam Fatura Ücreti
    }
}