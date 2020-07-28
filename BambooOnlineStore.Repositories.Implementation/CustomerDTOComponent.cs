using System;
using System.Collections.Generic;
using System.Text;

namespace BambooOnlineStore.Repositories.Implementation
{
	public class CustomerDTOComponent: CustomerDTO
	{
		Int32 Id { get; set; }
		Int32 CreatedBy { get; set; }
		DateTime DateCreated { get; set; }
		DateTime DateLastModified { get; set; }
		DateTime DateOfBirth { get; set; }
		String Email { get; set; }
		String FirstName { get; set; }
		Boolean IsActive { get; set; }
		String LastName { get; set; }
		Int32 ModifiedBy { get; set; }
		String CustomerId { get; set; }
		String TelephoneNumber { get; set; }
	}
}
