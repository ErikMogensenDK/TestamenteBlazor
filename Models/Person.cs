namespace FluentTestamente.Models
{
	public class Person
	{
		public string Name { get; set; }
		public string Address { get; set; }
		public DateTime? BirthDate { get; set; }
		public bool IsAlive { get; set; } = true;
		public string DateOnlyBirthDateString { get; set; }
	}
}