using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discounts
{
	public class Customer
	{
		public Customer(IList<Order> orders)
		{
			Name = "";
			DateOfBirth = DateTime.Now;
			Orders = orders;
			CurrentOrder = Orders.FirstOrDefault(order => DateTime.Now.Day == order.OrderDate.Day);
		}
		public string Name { get; set; }
		public DateTime DateOfBirth { get; set; }
		public IList<Order> Orders { get; set; }
		public Order CurrentOrder { get; private set; }
	}
}
