using System;
using System.Collections.Generic;
using System.Text;

namespace BambooOnlineStore
{
	public interface Admin
	{
		Int32 Id { get; set; }
		UserAccount CreatedBy { get; set; }
		DateTime DateCreated { get; set; }
		DateTime DateLastModified { get; set; }
		String Email { get; set; }
		String FirstName { get; set; }
		Boolean IsActive { get; set; }
		String LastName { get; set; }
		UserAccount ModifiedBy { get; set; }
		String TelephoneNumber { get; set; }
	}
}
