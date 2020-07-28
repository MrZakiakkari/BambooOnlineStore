using System;
using System.Collections.Generic;
using System.Text;

namespace BambooOnlineStore
{
	public interface Customer
	{
		Int32 Id { get; set; }
		UserAccount CreatedBy { get; set; }
		DateTime DateCreated { get; set; }
		DateTime DateLastModified { get; set; }
		DateTime DateOfBirth { get; set; }
		String Email { get; set; }
		String FirstName { get; set; }
		Boolean IsActive { get; set; }
		String LastName { get; set; }
		UserAccount ModifiedBy { get; set; }
		IList<Items> Items { get; set; }
		String StudentId { get; set; }
		String TelephoneNumber { get; set; }
	}
}
