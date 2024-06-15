namespace Models
{
	public class NameBreed
	{
		public int Id { get; set; }
		public string Name { get; set; } = "";
	}

	public class Breed : NameBreed
	{
		public int SpeciesId { get; set; }
		public string Description { get; set; } = "";
	}
}
