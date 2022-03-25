using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms; //Message Box
using System.Data; // Data function class

namespace FormLogin
{
    internal class Config
    {
		string connectionString = "";
		public MySqlConnection connection = null;
		public string server = "127.0.0.1";
		public string user = "root";
		public string password = "";
		DataSet ds;
		DataTable dt;
		public string Table = "user_info";
		public string connectionType = "";
		string RecordSource = "";

		DataGridView tempData;

		public Config()
		{

		}

		public void Connect(string databaseName)
		{
			try
			{
				connectionString = $"SERVER={server}; DATABASE={databaseName}; UID={user}; PASSWORD={password};";
				connection = new MySqlConnection(connectionString);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}

		public void ExecuteSql(string sqlCommand)
		{
			Nowquiee(sqlCommand);
		}

		public void Nowquiee(string sqlComm)
		{
			try
			{
				MySqlConnection cs = new MySqlConnection(connectionString);
				cs.Open();
				MySqlCommand myc = new MySqlCommand(sqlComm, cs);
				myc.ExecuteNonQuery();

				cs.Close();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}

		public void Execute(string sqlCommand)
		{
			RecordSource = sqlCommand;
			connectionType = Table;
			dt = new DataTable(connectionType);
			try
			{
				string command = RecordSource.ToUpper();

				//IF SQL CONTAINS SELECT
				MySqlDataAdapter da2 = new MySqlDataAdapter(RecordSource, connection);
				DataSet tempds = new DataSet();
				da2.Fill(tempds, connectionType);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}

		public string Results(int ROW, string COLUMN_NAME)
		{
			try
			{
				return dt.Rows[ROW][COLUMN_NAME].ToString();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
				return dt.Rows[ROW][COLUMN_NAME].ToString();
			}
		}

		public void ExecuteSelect(string sqlCommand)
        {
			RecordSource = sqlCommand;
			connectionType = Table;

			dt = new DataTable(connectionType);
			try
            {
				string command = RecordSource.ToUpper();
				MySqlDataAdapter da = new MySqlDataAdapter(RecordSource, connection);
				ds = new DataSet();
				da.Fill(ds, connectionType);
				da.Fill(dt);
			}
			catch (Exception e)
            {
				MessageBox.Show(e.Message);
            }
        }

		public int Count()
        {
			return dt.Rows.Count;
        }
	}
}
