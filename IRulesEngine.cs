using System.Collections.Generic;
using Discounts.Discounts;

namespace Discounts
{
	public interface IRulesEngine
	{
		IEnumerable<DiscountRule> Discounts { get; set; }
		IEnumerable<DiscountRule> GetBestDiscounts(Customer customer);
	}
}