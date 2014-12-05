using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discounts
{
	public class DiscountedOrder: Order
	{
		public decimal Discount { get; private set; }
		
		public DiscountedOrder(Order order, decimal discount)
		{
			Discount = discount;
			order.Total =	order.Total - (order.Total * Discount);
		}

		
	}
}
