using System;

namespace Discounts
{
	public class Order
	{
		public virtual decimal Total { get; set; }
		public virtual DateTime OrderDate { get; set; }

	}
}