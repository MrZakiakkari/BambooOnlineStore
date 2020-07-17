namespace BambooOnlineStore.Repositories.SQLite
{
	using System;
	public partial class BambooOnlineStoreDatabase : BambooOnlineStoreSystem, DatabaseAgent
	{
		public BambooOnlineStoreDatabase(String connectionString)
		{
			this.ConnectionString = connectionString;
			var timeFactorsSqlStatements = new BambooOnlineStoreSqlStatements();
			//
			//	repositories
			//
			this.UserAccountRepository = new UserAccountRepositoryComponent(this, timeFactorsSqlStatements);
			this.UserGroupRepository = new UserGroupRepositoryComponent(this, timeFactorsSqlStatements);
		}
		#region Public Properties
		#endregion
		public UserAccountRepository UserAccountRepository { get; }
		public UserGroupRepository UserGroupRepository { get; }
		public String ConnectionString { get; }
	}
}