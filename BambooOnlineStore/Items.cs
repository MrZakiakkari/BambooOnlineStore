using System;
using System.Collections.Generic;
using System.Text;

namespace BambooOnlineStore
{
	public interface Items
	{
		double price { get; set; }
		Int32 Id { get; set; }
		String Name { get; set; }
		IList<Items> Items { get; set; }
	}
}
