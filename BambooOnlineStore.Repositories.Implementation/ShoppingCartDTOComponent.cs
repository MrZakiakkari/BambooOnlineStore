using System;
using System.Collections.Generic;
using System.Text;

namespace BambooOnlineStore.Repositories.Implementation
{
	public class ShoppingCartDTOComponent: ShoppingCartDTO
	{
		Int32 Id { get; set; }
		Int32 CreatedBy { get; set; }
		DateTime DateCreated { get; set; }
		DateTime DateLastModified { get; set; }
		DateTime EndTime { get; set; }
		Int32 ModifiedBy { get; set; }
		DateTime StartTime { get; set; }
	}
}
