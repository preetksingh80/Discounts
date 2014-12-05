using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Discounts.Discounts;

namespace Discounts
{
	public class MultipleDiscountsRuleEngine:IRulesEngine
	{

		public IEnumerable<DiscountRule> Discounts { get; set; }
		public IEnumerable<DiscountRule> GetBestDiscounts(Customer customer)
		{
			return Discounts.Where(rule => rule.IsApplicable(customer));
		}

		
	}
}
