using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Discounts.Discounts;

namespace Discounts.Decorators
{
	public class OrderDecorator: Order
	{
		public decimal Discount { get; set; }
		private readonly Order _order;

		public OrderDecorator(Order order, Decimal discount)
		{
			Discount = discount;
			_order = order;
		}

		public override DateTime OrderDate{ get {return _order.OrderDate;} set { _order.OrderDate = value;}}
		

		public override decimal Total
		{
			get
			{
				return _order.Total - (_order.Total * Discount);
			}
			set
			{
				base.Total = value;
			}
		}

		
	}

	public class DiscountOrder : OrderDecorator
	{
		public DiscountOrder(Order order, decimal discount) : base(order, discount)
		{
		}
	}
}
