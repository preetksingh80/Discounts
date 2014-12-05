using System;

namespace Discounts.Discounts
{
	public class BirthdayCustomerDiscount : DiscountRule
	{
		public BirthdayCustomerDiscount(decimal discount) : base(discount)
		{
		}


		public override bool IsApplicable(Customer customer)
		{
			return customer.DateOfBirth.Date == DateTime.Now.Date;
		}
	}
}