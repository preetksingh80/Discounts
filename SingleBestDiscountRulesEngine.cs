using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Discounts.Discounts;

namespace Discounts
{
	public class SingleBestDiscountRulesEngine : IRulesEngine
	{
		public IEnumerable<DiscountRule> Discounts { get; set; }
		

		public SingleBestDiscountRulesEngine(IEnumerable<DiscountRule> discounts)
		{
			Discounts = discounts;
		}

		public IEnumerable<DiscountRule> GetBestDiscounts(Customer customer)
		{
			return new List<DiscountRule> { Discounts.OrderByDescending(discount => discount.Calculate(customer)).FirstOrDefault() };
		}

		
	}
}
