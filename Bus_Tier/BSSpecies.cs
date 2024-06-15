using Connector_Tier;
using MySql.Data.MySqlClient;
using Models;
namespace Bus_Tier
{
	public class BSSpecies
	{
		ConnectorFactory connector = null;

		public BSSpecies()
		{
			connector = new ConnectorFactory();
		}

		public bool AddSpecies(string name)
		{
			connector.OpenConnection();
			string query = $"INSERT INTO species (name) VALUES ('{name}')";
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

		public bool UpdateSpecies(Species spc)
		{
			connector.OpenConnection();
			string query = $"UPDATE species SET name = '{spc.Name}' WHERE id = {spc.Id}";
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

		public bool DeleteSpecies(int id)
		{
			connector.OpenConnection();
			string query = $"DELETE FROM species WHERE id = {id}";
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

		public List<Species> GetSpecies()
		{
			connector.OpenConnection();
			string query = "SELECT * FROM species";
			MySqlDataReader reader = connector.ExecuteReader(query);
			List<Species> species = [];
			if (reader != null)
				while (reader.Read())
				{
					Species s = new()
					{
						Id = reader.GetInt32("id"),
						Name = reader.GetString("name")
					};
					species.Add(s);
				}
			connector.CloseConnection();
			return species;
		}
	}
}
