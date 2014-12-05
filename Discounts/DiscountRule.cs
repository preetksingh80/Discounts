using System;

namespace Discounts.Discounts
{
	public abstract class DiscountRule
	{
		public decimal Discount { get; private set; }
		abstract public Boolean IsApplicable(Customer customer);

		protected DiscountRule(decimal discount)
		{
			Discount = discount;
			
		}

		public virtual decimal Calculate(Customer customer)
		{
			return customer.CurrentOrder.Total * Discount;
		}
		
	}
}