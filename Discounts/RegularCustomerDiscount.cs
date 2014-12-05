using System;
using System.Linq;

namespace Discounts.Discounts
{
	public class RegularCustomerDiscount : DiscountRule
	{
		public RegularCustomerDiscount(decimal discount) : base(discount)
		{
		}


		public override bool IsApplicable(Customer customer)
		{
			return customer.Orders.Any(order => order.OrderDate < DateTime.Now) && customer.Orders.Count > 2;
		}
	}
}