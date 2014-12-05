using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Discounts.Decorators;
using Discounts.Discounts;
using Discounts.Helpers;
using NUnit.Framework;

namespace Discounts.Tests
{
	[TestFixture]
	public class GiveACustomerDiscountEngineShould
	{
		protected IList<DiscountRule> DiscountRules { get; set; }
		protected IRulesEngine RulesEngine { get; set; }

		public GiveACustomerDiscountEngineShould()
		{

			DiscountRules = TestHelper.GetDiscounts();
			
		}

		

		[Test]
		public void GetHighestDiscountAvailable()
		{
			RulesEngine = new SingleBestDiscountRulesEngine(DiscountRules);
			var customer = TestHelper.GetCustomerWithOrders();
			var discounts = RulesEngine.GetBestDiscounts(customer);
			Assert.IsTrue(discounts.Count() == 1);

		}
		[Test]
		public void GetAllDiscountsAvailable()
		{
			RulesEngine = new MultipleDiscountsRuleEngine {Discounts = DiscountRules};
			var customer = TestHelper.GetCustomerWithOrders();
			var discounts = RulesEngine.GetBestDiscounts(customer).ToList();
			var totalDiscounts = discounts.Sum(rule => rule.Discount);
			Order discountedOrder = new DiscountOrder(customer.CurrentOrder, totalDiscounts);
			var date = discountedOrder.OrderDate;
			Assert.IsTrue(discounts.Count() > 1);

		}
	}
}
