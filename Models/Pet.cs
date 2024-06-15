namespace Models
{
	public class Pet
	{
		public int Id { get; set; } = 0;
		public string Name { get; set; } = "";
		public bool IsMale { get; set; }
		public int BreedId { get; set; } = 0;
		public int BornYear { get; set; }
		public float Weight { get; set; }
		public string Description { get; set; } = "";
		public string Image { get; set; } = "";
		public int Price { get; set; }
		public bool IsSold { get; set; } = false;

	}
	public class BasePet
	{
		public int Id { get; set; } = 0;
		public string Name { get; set; } = "";
		public string Breed { get; set; } = "";
		public int BornYear { get; set; }
		public int Price { get; set; }
		public bool IsSold { get; set; } = false;
	}

	public class DisplayPet : BasePet
	{
		public bool IsMale { get; set; }
		public float Weight { get; set; }
		public string Description { get; set; } = "";
		public string Image { get; set; } = "";
		public int BreedId { get; set; }
		public string Breed { get; set; } = "";
		public string Species { get; set; } = "";
	}


}
