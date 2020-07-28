using System;
using System.Collections.Generic;
using System.Text;

namespace BambooOnlineStore.Repositories
{
	public interface ItemsDTO
	{
		Int32 Id { get; set; }
		String Name { get; set; }
		double price { get; set; }
	}
}
