using MySql.Data.MySqlClient;
using Models;
using Connector_Tier;

namespace Bus_Tier
{
	public class BSBreed
	{
		ConnectorFactory connector = null;

		public BSBreed()
		{
			connector = new ConnectorFactory();
		}

		public bool AddBreed(Breed breed)
		{
			connector.OpenConnection();
			string query = $"INSERT INTO breed (name, species_id, description) VALUES ('{breed.Name}', {breed.SpeciesId}, '{breed.Description}')";
			if (connector.ExecuteQuery(query))
			{
				connector.CloseConnection();
				return true;
			} else
			{
				connector.CloseConnection();
				return false;
			}
		}

		public bool UpdateBreed(Breed breed)
		{
			connector.OpenConnection();
			string query = $"UPDATE breed SET name = '{breed.Name}', species_id = {breed.SpeciesId}, description = '{breed.Description}' WHERE id = {breed.Id}";
			if (connector.ExecuteQuery(query))
			{
				connector.CloseConnection();
				return true;
			} else
			{
				connector.CloseConnection();
				return false;
			}
		}

		public bool DeleteBreed(int id)
		{
			connector.OpenConnection();
			string query = $"DELETE FROM breed WHERE id = {id}";
			if (connector.ExecuteQuery(query))
			{
				connector.CloseConnection();
				return true;
			} else
			{
				connector.CloseConnection();
				return false;
			}
		}

		public List<Breed> GetBreeds()
		{
			connector.OpenConnection();
			string query = "SELECT * FROM breed";
			MySqlDataReader data = connector.ExecuteReader(query);
			List<Breed> breeds = [];
			if (data != null)
				while (data.Read())
				{
					Breed breed = new()
					{
						Id = data.GetInt32("id"),
						Name = data.GetString("name"),
						SpeciesId = data.GetInt32("species_id"),
						Description = data.GetString("description")
					};
					breeds.Add(breed);
				}
			connector.CloseConnection();
			return breeds;
		}

		public List<NameBreed> GetBreedsName()
		{
			connector.OpenConnection();
			string query = "SELECT id, name FROM breed";
			MySqlDataReader data = connector.ExecuteReader(query);
			List<NameBreed> breeds = [];
			if (data != null)
				while (data.Read())
				{
					NameBreed breed = new()
					{
						Id = data.GetInt32("id"),
						Name = data.GetString("name")
					};
					breeds.Add(breed);
				}
			connector.CloseConnection();
			return breeds;
		}

		public string GetSpeciesName(int id)
		{
			connector.OpenConnection();
			string query = $"SELECT species.name FROM breed JOIN species ON breed.species_id = species.id WHERE breed.id = {id}";
			MySqlDataReader data = connector.ExecuteReader(query);
			string species = "Undefined";
			if (data != null)
				while (data.Read())
				{
					species = data.GetString("name");
				}
			connector.CloseConnection();
			return species;
		}
	}
}
