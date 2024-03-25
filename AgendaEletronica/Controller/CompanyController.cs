using AgendaEletronica.Database.AgendaEletronicaDataSetTableAdapters;

using DatabaseConnections.Connections;
using DatabaseConnections.Enums;
using DatabaseConnections.Interfaces;

using System.Data.SqlClient;

using static AgendaEletronica.Database.AgendaEletronicaDataSet;

namespace AgendaEletronica.Controller
{
	public static class CompanyController
	{
		public static CompanyDataTable GetCompanies()
		{
			IConnection iConnection = ConnectionsFactory.GetConnection(DatabasesEnum.SqlServer2019, 0);

			var conn = iConnection.GetConnection<SqlConnection>();

			using( var taCompanies = new CompanyTableAdapter{ Connection = conn } )
			{
				taCompanies.Connection.Open();

				CompanyDataTable dtCompanies = taCompanies.GetData();

				taCompanies.Connection.Close();

				return dtCompanies;
			}
		}

		public static CompanyDataTable GetCompany(int id)
		{
			IConnection iConnection = ConnectionsFactory.GetConnection(DatabasesEnum.SqlServer2019, 0);

			var conn = iConnection.GetConnection<SqlConnection>();

			using( var taCompanies = new CompanyTableAdapter { Connection = conn } )
			{
				taCompanies.Connection.Open();

				var dtCompany = taCompanies.GetDataById(id);

				taCompanies.Connection.Close();

				return dtCompany;
			}
		}

		public static bool SaveCompany( CompanyDataTable dtCompany )
		{
			try
			{
				IConnection iConnection = ConnectionsFactory.GetConnection(DatabasesEnum.SqlServer2019, 0);

				var conn = iConnection.GetConnection<SqlConnection>();

				using( var taCompanies = new CompanyTableAdapter { Connection = conn } )
				{
					taCompanies.Connection.Open();

					int iReturn = taCompanies.Update(dtCompany);

					taCompanies.Connection.Close();

					return iReturn > 0;
				}
			}
			catch
			{
				return false;
			}
		}

		public static bool DeleteCompany(int id) 
		{
			try
			{
				IConnection iConnection = ConnectionsFactory.GetConnection(DatabasesEnum.SqlServer2019, 0);

				var conn = iConnection.GetConnection<SqlConnection>();

				using( var taCompanies = new CompanyTableAdapter { Connection = conn } )
				{
					taCompanies.Connection.Open();

					int iReturn = taCompanies.DeleteQuery(id);

					taCompanies.Connection.Close();

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
