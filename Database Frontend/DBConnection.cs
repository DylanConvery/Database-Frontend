using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Database_Frontend {
	 class DBConnection {
		//string used for making connection possible with specific version of Microsoft Access
		public string connection_string { set; get;}

		//used to create and interact with a microsoft access database
		private OleDbConnection connection = new OleDbConnection();

        //default and overloaded constructor
		#region Connection Related
		public DBConnection(){}
		public DBConnection(string connection_string) {
			this.connection_string = connection_string;
		}

		///attempts to open connection to database
		public void Open() {
			try {
				connection.ConnectionString = connection_string;
				connection.Open();
			} catch(Exception err) {
				MessageBox.Show(err.Message);
			}
		}

		///closes connection to database
		public void Close() {
			try {
				connection.Close();
			} catch(Exception err) {
				MessageBox.Show(err.Message);
			}
		}

		///returns whether a connection is open or not
		public ConnectionState ConnectionState() {
			return connection.State;
		}
		#endregion

		#region Query Related
		///executes an SQL query against the connected database
		public void SQLQuery(string SQL) {
			try {
				OleDbCommand command = new OleDbCommand(SQL, connection);
				command.ExecuteNonQuery();
			} catch (Exception err){
				MessageBox.Show(err.Message);
			}
		}

		///returns the entire table from the connected database
		public DataTable GetTable() {
			String SQL = "SELECT * FROM Cars";
			DataTable table = new DataTable();
			try {
				OleDbCommand command = new OleDbCommand(SQL, connection);
				OleDbDataReader reader = command.ExecuteReader();
				table.Load(reader);
			} catch (Exception err) {
				MessageBox.Show(err.Message);
			}
			return table;
		}
		#endregion
	}
}
