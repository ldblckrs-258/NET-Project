using MySql.Data.MySqlClient;
using Models;
using Connector_Tier;

namespace Bus_Tier
{
	public class BSPet
	{
		ConnectorFactory connector = null;

		public BSPet()
		{
			connector = new ConnectorFactory();
		}

		public bool AddPet(Pet pet)
		{
			connector.OpenConnection();
			string query = $"INSERT INTO pet(name, is_male, born_year, breed_id, weight, description, image, price, is_sold) VALUES('{pet.Name}', {pet.IsMale}, {pet.BornYear}, {pet.BreedId}, {pet.Weight}, '{pet.Description}', '{pet.Image}', {pet.Price}, {pet.IsSold})";
			if (connector.ExecuteQuery(query))
			{
				connector.CloseConnection();
				return true;
			}
			else
			{
				connector.CloseConnection();
				return false;
			}
		}

		public bool UpdatePet(Pet pet)
		{
			connector.OpenConnection();
			string query = $"UPDATE pet SET name = '{pet.Name}', is_male = '{pet.IsMale}', born_year = '{pet.BornYear}', breed_id = '{pet.BreedId}', weight = '{pet.Weight}', description = '{pet.Description}', image = '{pet.Image}', price = '{pet.Price}' WHERE id = {pet.Id}";
			if (connector.ExecuteQuery(query))
			{
				connector.CloseConnection();
				return true;
			}
			else
			{
				connector.CloseConnection();
				return false;
			}
		}

		public bool DeletePet(int id)
		{
			connector.OpenConnection();
			string query = $"DELETE FROM pet WHERE id = {id}";
			if (connector.ExecuteQuery(query))
			{
				connector.CloseConnection();
				return true;
			}
			else
			{
				connector.CloseConnection();
				return false;
			}
		}

		public bool SellPet(int id)
		{
			connector.OpenConnection();
			string query = $"UPDATE pet SET is_sold = true WHERE id = {id}";
			if (connector.ExecuteQuery(query))
			{
				connector.CloseConnection();
				return true;
			}
			else
			{
				connector.CloseConnection();
				return false;
			}
		}

		public List<BasePet> GetListPets(string searchValue = "", int isSoldValue = 0)
		{
			connector.OpenConnection();
			string query = "SELECT pet.id, pet.name, breed.name AS breed, pet.born_year, pet.weight, pet.price, pet.is_sold" +
				" FROM pet" +
				" JOIN breed ON pet.breed_id = breed.id";
			// if ( searchValue != string.Empty)
				query += $" WHERE pet.name LIKE '%{searchValue}%'";
			if (isSoldValue == 1) query += " AND pet.is_sold = true";
			else if (isSoldValue == 2) query += " AND pet.is_sold = false";

			MySqlDataReader reader = connector.ExecuteReader(query);
			List<BasePet> pets = [];
			if (reader != null)
				while (reader.Read())
				{
					BasePet pet = new()
					{
						Id = reader.GetInt32("id"),
						Name = reader.GetString("name"),
						Breed = reader.GetString("breed"),
						BornYear = reader.GetInt32("born_year"),
						Price = reader.GetInt32("price"),
						IsSold = reader.GetBoolean("is_sold")
					};
					pets.Add(pet);
				}

			return pets;
		}

		public DisplayPet GetPet(int id)
		{
			connector.OpenConnection();
			string query = "SELECT pet.id, pet.name, breed_id, species.name AS species, breed.name AS breed, pet.born_year, pet.weight, pet.description, pet.image, pet.price, pet.is_sold" + 
				" FROM pet" +
				" JOIN breed ON pet.breed_id = breed.id" +
				" JOIN species ON breed.species_id = species.id" + 
				$" WHERE pet.id = {id}";
			MySqlDataReader reader = connector.ExecuteReader(query);
			DisplayPet pet = new();
			if (reader.Read())
			{
				pet.Id = reader.GetInt32("id");
				pet.Name = reader.GetString("name");
				pet.Species = reader.GetString("species");
				pet.BreedId = reader.GetInt32("breed_id");
				pet.Breed = reader.GetString("breed");
				pet.BornYear = reader.GetInt32("born_year");
				pet.Weight = reader.GetFloat("weight");
				pet.Description = reader.GetString("description");
				pet.Image = reader.GetString("image");
				pet.Price = reader.GetInt32("price");
				pet.IsSold = reader.GetBoolean("is_sold");
			}
			connector.CloseConnection();
			return pet;
		}

		public int TotalPriceSold()
		{
			connector.OpenConnection();
			string query = "SELECT SUM(price) AS total_price FROM pet WHERE is_sold = true";
			MySqlDataReader reader = connector.ExecuteReader(query);
			int total = 0;
			if (reader.Read())
			{
				total = reader.GetInt32("total_price");
			}
			connector.CloseConnection();
			return total;
		}
	}
}
