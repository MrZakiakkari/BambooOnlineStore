using System;
using System.Collections.Generic;
using System.Text;

namespace BambooOnlineStore
{
	public interface PayPeriod
	{
		Int32 Id { get; set; }
		DateTime EndDate { get; set; }
		String Name { get; set; }
		DateTime StartDate { get; set; }
	}
}
