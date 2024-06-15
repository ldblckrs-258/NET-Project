using Connector_Tier;
using Models;
using MySql.Data.MySqlClient;

namespace Bus_Tier
{
	public class BSRole
	{
		ConnectorFactory connector = null;

		public BSRole()
		{
			connector = new ConnectorFactory();
		}

		public bool AddRole(string name)
		{
			connector.OpenConnection();
			string query = $"INSERT INTO role (name) VALUES ('{name}')";
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

		public bool UpdateRole(int id, string name)
		{
			connector.OpenConnection();
			string query = $"UPDATE role SET name = '{name}' WHERE id = {id}";
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

		public bool DeleteRole(int id)
		{
			connector.OpenConnection();
			string query = $"DELETE FROM role WHERE id = {id}";
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

		public List<Role> GetRoles()
		{
			connector.OpenConnection();
			string query = "SELECT * FROM role";
			MySqlDataReader reader = connector.ExecuteReader(query);
			List<Role> roles = [];
			if (reader != null)
				while (reader.Read())
				{
					roles.Add(new Role
					{
						Id = reader.GetInt32("id"),
						Name = reader.GetString("name")
					});
				}
			connector.CloseConnection();
			return roles;
		}
	}
}
