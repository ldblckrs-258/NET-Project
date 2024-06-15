namespace Models
{
	public class BaseUser
	{
		public int Id { get; set; } = 0;
		public string Name { get; set; } = "";
		public string BirthDate { get; set; } = "";
		public string Username { get; set; } = "";
	}

	public class User : BaseUser
	{
		public string Password { get; set; } = "";
		public int RoleId { get; set; } = 0;
	}

	public class DisplayUser : BaseUser
	{
		public string Role { get; set; } = "";
	}
	// adminadmin - manager001 - employee002
}
