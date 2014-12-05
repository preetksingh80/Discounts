using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Discounts.Discounts;

namespace Discounts.Helpers
{
	public static class TestHelper
	{
		public static Customer GetCustomerWithOrders()
		{
			var orders = new List<Order> {new Order {OrderDate = DateTime.Now, Total = 100.00m},
										 new Order {OrderDate = new DateTime(2013,1,1), Total = 50.00m},
										 new Order {OrderDate = new DateTime(2012,1,1), Total = 20.00m}};
			return new Customer(orders)
			{
				Name = "Preet",
				DateOfBirth = new DateTime(1960, 1, 1)
			};
			
		}

		public static IList<DiscountRule> GetDiscounts()
		{
			return new List<DiscountRule> { 
				new BirthdayCustomerDiscount(0.05m),
				new RegularCustomerDiscount(0.15m),
				new SeniorCustomerDiscount(0.20m)
			};
		}

		public static IRulesEngine GetRulesEngine(IEnumerable<DiscountRule> discounts )
		{
			return new SingleBestDiscountRulesEngine(discounts);
		}
	}
}
