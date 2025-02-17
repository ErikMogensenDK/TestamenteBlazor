namespace FluentTestamente.Models;

public class Person
{
	public Guid Id { get; set; }
	public string Name { get; set; }
	public string Address { get; set; }
	public DateTime BirthDate { get; set; }
	public bool IsAlive { get; set; } = true;
	public string DateOnlyBirthDateString { get => BirthDate.ToString("dd-MM-yyyy"); }
	public Guid? FatherId { get; set; }
	public Guid? MotherId { get; set; }
	public Guid? SpouseId { get; set; }
	public Guid CreatedById { get; set; }
}