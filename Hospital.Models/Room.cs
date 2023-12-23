namespace Hospital.Models
{
	public class Room
	{
		public int? Id { get; set; }	
		public string? RoomNumber { get; set; }
		public string? Status { get; set; }
		public string? Type { get; set; }
        public int? HospitalId { get; set; }
		public Hospitalinfo? Hospital { get; set; }

	}
}