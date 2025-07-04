﻿namespace BambooOnlineStore.Repositories.SQLite
{
	using System;
	partial class BambooOnlineStoreSqlStatements
	{
		public String GetActiveUserAccounts => "SELECT * FROM UserAccount WHERE IsActive = 1;";
		public String GetUserAccountByCredentials => "SELECT * FROM UserAccount WHERE Username = $Username AND Password = $Password;";
		public String GetLastInsertRowId => "SELECT last_insert_rowid()";
	}
}