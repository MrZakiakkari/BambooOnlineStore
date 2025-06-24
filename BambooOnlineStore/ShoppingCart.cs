using System;
using System.Collections.Generic;
using System.Text;

namespace BambooOnlineStore
{
	public interface ShoppingCart
	{
		Int32 Id { get; set; }
		UserAccount CreatedBy { get; set; }
		DateTime DateCreated { get; set; }
		DateTime DateLastModified { get; set; }
		DateTime EndTime { get; set; }
		UserAccount ModifiedBy { get; set; }
		PayPeriod PayPeriodToBill { get; set; }
		DateTime StartTime { get; set; }
		IList<Customer> Customers { get; set; }
		Admin Admin { get; set; }
		#region Statistical Properties
		#endregion
		IList<Items> Items { get; set; }
	}
}
