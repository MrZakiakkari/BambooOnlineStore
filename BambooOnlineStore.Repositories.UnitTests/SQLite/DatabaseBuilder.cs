namespace BambooOnlineStore.Repositories.UnitTests.SQLite
{
	using BambooOnlineStore.Repositories.SQLite;
	public class DatabaseBuilder : DatabaseBuilderBase
	{
		// Use Manager User Secrets and add: "SQLiteTestDatabaseConnectionString": "DataSource=bambooonlinestore-v1.sqlite3"
		public DatabaseBuilder() : base(connectionStringKey: "SQLiteTestDatabaseConnectionString")
		{
		}
		public BambooOnlineStoreDatabase Build()
		{
			return new BambooOnlineStoreDatabase(GetConnectionString());
		}
	}
}