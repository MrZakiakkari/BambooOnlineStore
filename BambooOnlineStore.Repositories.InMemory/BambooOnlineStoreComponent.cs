namespace BambooOnlineStore.Repositories.InMemory
{
	using System;
	using BambooOnlineStore.Repositories;
	public partial class BambooOnlineStoreComponent : BambooOnlineStoreSystem
	{
		public BambooOnlineStoreComponent(String name)
		{
			Name = name;
			//
			//	repositories
			//
			this.UserAccountRepository = new UserAccountRepositoryComponent();
			this.UserGroupRepository = new UserGroupRepositoryComponent();
		}
		#region Public Properties
		#endregion
		public String Name { get; }
		#region Public Properties - Repositories
		#endregion
		public UserAccountRepositoryComponent UserAccountRepository { get; }
		public UserGroupRepositoryComponent UserGroupRepository { get; }
		#region BambooOnlineStoreSystem - Members
		#endregion
		UserAccountRepository BambooOnlineStoreSystem.UserAccountRepository { get { return UserAccountRepository; } }
		UserGroupRepository BambooOnlineStoreSystem.UserGroupRepository { get { return UserGroupRepository; } }
	}
}