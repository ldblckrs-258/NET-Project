using Connector_Tier;
using Models;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Bus_Tier
{
	public class BSUser
	{
		ConnectorFactory connector = null;

		public BSUser()
		{
			connector = new ConnectorFactory();
		}

		private static string HashPassword(string password)
		{
			byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(password));
			StringBuilder builder = new();
			for (int i = 0; i < bytes.Length; i++)
			{
				builder.Append(bytes[i].ToString("x2"));
			}
			return builder.ToString();
		}

		public DisplayUser Login(string username, string password)
		{
			if (connector.OpenConnection() == false)
				return null;
			string query = $"SELECT user.id, user.name, user.birth_date, user.username, role.name AS role" +
				$" FROM user" +
				$" JOIN role ON user.role_id = role.id" +
				$" WHERE username = '{username}' AND password = '{HashPassword(password)}'";
			MySqlDataReader reader = connector.ExecuteReader(query);
			DisplayUser user = null;
			if (reader.Read())
			{
				user = new()
				{
					Id = reader.GetInt32("id"),
					Name = reader.GetString("name"),
					BirthDate = reader.GetDateTime("birth_date").ToString().Substring(0, 10),
					Username = reader.GetString("username"),
					Role = reader.GetString("role")
				};
			}
			connector.CloseConnection();
			return user;
		}

		public bool AddUser(User user)
		{
			if (connector.OpenConnection() == false)
				return false;
			string query = $"INSERT INTO user (name, birth_date, username, password, role_id)" +
				$" VALUES ('{user.Name}', '{user.BirthDate}', '{user.Username}', '{HashPassword(user.Password)}', {user.RoleId})";
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

		public bool ChangePassword(string username, string oldPassword, string newPassword)
		{
			if (connector.OpenConnection() == false)
				return false;
			string confirmQuery = $"SELECT id FROM user WHERE username = '{username}' AND password = '{HashPassword(oldPassword)}'";
			MySqlDataReader reader = connector.ExecuteReader(confirmQuery);

			if (reader.Read())
			{
				connector.CloseConnection();
				string query = $"UPDATE user SET password = '{HashPassword(newPassword)}' WHERE username = '{username}'";
				connector.OpenConnection();
				if (connector.ExecuteQuery(query))
				{
					connector.CloseConnection();
					return true;
				} else
				{
					connector.CloseConnection();
					return false;
				}
			} else
			{
				connector.CloseConnection();
				return false;
			}
		}

		public bool DeleteUser(string username, int id)
		{
			if (connector.OpenConnection() == false)
				return false;
			string query = $"DELETE FROM user WHERE username = '{username}' AND id = '{id}'";
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

		public bool UpdateUserInfo(User user)
		{
			if (connector.OpenConnection() == false)
				return false;
			string query = $"UPDATE user" + $" SET name = '{user.Name}', birth_date = '{user.BirthDate}'";
			if (user.RoleId != 0) query += $", role_id = {user.RoleId}";
			query += $" WHERE id = {user.Id}";
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



		public List<DisplayUser> GetUsers(bool isOwner)
		{
			connector.OpenConnection();
			string query = "SELECT user.id, user.name, user.birth_date, user.username, role.name AS role" +
				" FROM user" + 
				" JOIN role ON user.role_id = role.id";
			if (!isOwner) query += " WHERE role.name = 'Nhân viên'";
			MySqlDataReader reader = connector.ExecuteReader(query);
			List<DisplayUser> users = [];
			if (reader != null)
				while (reader.Read())
				{
					DisplayUser user = new()
					{
						Id = reader.GetInt32("id"),
						Name = reader.GetString("name"),
						BirthDate = reader.GetDateTime("birth_date").ToString().Substring(0, 10),
						Username = reader.GetString("username"),
						Role = reader.GetString("role")
					};
					users.Add(user);
				}
			connector.CloseConnection();
			return users;
		}

		public DisplayUser GetUser(int userId)
		{
			if (connector.OpenConnection() == false)
				return null;
			string query = $"SELECT user.id, user.name, user.birth_date, user.username, role.name AS role" +
				$" FROM user" +
				$" JOIN role ON user.role_id = role.id" +
				$" WHERE user.id = {userId}";
			MySqlDataReader reader = connector.ExecuteReader(query);
			DisplayUser user = null;
			if (reader.Read())
			{
				user = new()
				{
					Id = reader.GetInt32("id"),
					Name = reader.GetString("name"),
					BirthDate = reader.GetDateTime("birth_date").ToString().Substring(0, 10),
					Username = reader.GetString("username"),
					Role = reader.GetString("role")
				};
			}
			connector.CloseConnection();
			return user;
		}

		public string ResetPassword(string username)
		{
			if (connector.OpenConnection() == false)
				return null;
			string newPassword = Guid.NewGuid().ToString().Substring(0, 8);
			string query = $"UPDATE user SET password = '{HashPassword(newPassword)}' WHERE username = '{username}'";
			if (connector.ExecuteQuery(query))
			{
				connector.CloseConnection();
				return newPassword;
			} else
			{
				connector.CloseConnection();
				return null;
			}
		}
	}
}
