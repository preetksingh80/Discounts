namespace Discounts.Discounts
{
	public class SeniorCustomerDiscount : DiscountRule
	{
		public SeniorCustomerDiscount(decimal discount) : base(discount){}


		public override bool IsApplicable(Customer customer)
		{
			return customer.DateOfBirth.Year < 1970;
		}
	}
}