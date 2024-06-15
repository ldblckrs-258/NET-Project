using System.IO;
using System.Text.Json;
using Models;
namespace Bus_Tier
{
	public class BSStore
	{
		private static readonly string _storePath = "store.json";

		public static void SaveUser(int UserId)
		{
			File.WriteAllText(_storePath, JsonSerializer.Serialize(UserId));
		}

		public static int LoadUser()
		{
			if (File.Exists(_storePath))
			{
				return JsonSerializer.Deserialize<int>(File.ReadAllText(_storePath));
			}
			else
			{
				return 0;
			}
		}

		public static void DeleteUser()
		{
			if (File.Exists(_storePath))
			{
				File.Delete(_storePath);
			}
		}
	}
}
