using System;
using System.Collections.Generic;

namespace ADO.API.Models
{
	public class Customer
	{
		public Guid CustomerId { get; set; }
		public string Name { get; set; }
		public string LastName { get; set; }
		public List<Order> Orders { get; set; }
	}

}
