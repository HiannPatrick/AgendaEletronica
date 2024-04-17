using AgendaEletronica.Database.AgendaEletronicaDataSetTableAdapters;

using DatabaseConnections.Connections;
using DatabaseConnections.Enums;
using DatabaseConnections.Interfaces;

using System.Data.SqlClient;

using static AgendaEletronica.Database.AgendaEletronicaDataSet;

namespace AgendaEletronica.Controller
{
	public static class UserController
	{
		public static UserDataTable GetUsers()
		{
			IConnection iConnection = ConnectionsFactory.GetConnection(DatabasesEnum.SqlServer2019, 0);

			var conn = iConnection.GetConnection<SqlConnection>();

			using( var taUsers = new UserTableAdapter { Connection = conn } )
			{
				taUsers.Connection.Open();

				UserDataTable dtUsers = taUsers.GetData();

				taUsers.Connection.Close();

				return dtUsers;
			}
		}

		public static UserDataTable GetUser( int id )
		{
			IConnection iConnection = ConnectionsFactory.GetConnection(DatabasesEnum.SqlServer2019, 0);

			var conn = iConnection.GetConnection<SqlConnection>();

			using( var taUsers = new UserTableAdapter { Connection = conn } )
			{
				taUsers.Connection.Open();

				var dtUser = taUsers.GetDataById(id);

				taUsers.Connection.Close();

				return dtUser;
			}
		}

		public static bool SaveUser( UserDataTable dtUser )
		{
			try
			{
				IConnection iConnection = ConnectionsFactory.GetConnection(DatabasesEnum.SqlServer2019, 0);

				var conn = iConnection.GetConnection<SqlConnection>();

				using( var taUsers = new UserTableAdapter { Connection = conn } )
				{
					taUsers.Connection.Open();

					int iReturn = taUsers.Update(dtUser);

					taUsers.Connection.Close();

					return iReturn > 0;
				}
			}
			catch
			{
				return false;
			}
		}

		public static bool DeleteUser( int id )
		{
			try
			{
				IConnection iConnection = ConnectionsFactory.GetConnection(DatabasesEnum.SqlServer2019, 0);

				var conn = iConnection.GetConnection<SqlConnection>();

				using( var taUsers = new UserTableAdapter { Connection = conn } )
				{
					taUsers.Connection.Open();

					int iReturn = taUsers.DeleteQuery(id);

					taUsers.Connection.Close();

					return iReturn > 0;
				}
			}
			catch
			{
				return false;
			}
		}
	}
}
