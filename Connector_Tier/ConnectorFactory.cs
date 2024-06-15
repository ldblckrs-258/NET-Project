using MySql.Data.MySqlClient;
using System.IO;
namespace Connector_Tier
{
	public class ConnectorFactory
	{
		public string strConn = "SERVER=localhost;DATABASE=netproject;UID=root;PASSWORD=;";
		private MySqlConnection conn;
		private MySqlCommand cmd;

		public ConnectorFactory()
		{
			conn = new MySqlConnection(strConn);
		}

		public bool OpenConnection()
		{
			try
			{
				if (conn.State == System.Data.ConnectionState.Closed)
				{
					conn.Open();
				}
				return true;
			} catch (MySqlException ex)
			{
				Log(ex.Message);
				return false;
			}
		}

		public bool CloseConnection()
		{
			try
			{
				if (conn.State == System.Data.ConnectionState.Open)
				{
					conn.Close();
				}
				return true;
			} catch (MySqlException ex)
			{
				Log(ex.Message);
				return false;
			}
		}

		public Boolean ExecuteQuery(string query)
		{
			try
			{
				Log(query);
				cmd = new MySqlCommand(query, conn);
				cmd.ExecuteNonQuery();
				return true;
			} catch (MySqlException ex)
			{
				Log(ex.Message);
				return false;
			}

		}

		public MySqlDataReader ExecuteReader(string query)
		{
			try
			{
				Log(query);
				cmd = new MySqlCommand(query, conn);
				return cmd.ExecuteReader();
			} catch (MySqlException ex)
			{
				Log(ex.Message);
				return null;
			}
		}

		public void Log(string message)
		{
			string timeStr = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			File.AppendAllText("log.txt", timeStr + " | " + message + "\n");
		}
	}
}
