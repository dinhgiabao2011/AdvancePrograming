using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancePrograming
{
	public class OrderDetail
	{
		public int Quantity { get; set; }

		public Product Product { get; set; }

		public Order Order { get; set; }

		public OrderDetail(int quantity, Product product, Order order)
		{
			Quantity = quantity;
			Product = product;
			Order = order;
		}
		public OrderDetail()
		{

		}

		public double SubTotal()
		{
			return Quantity * Product.Price;
		}

		public override string ToString()
		{
			return "Product ID:" + Product.ProductID + " Name:" + Product.Name + " Price:" + Product.Price + " Quantity:" + Quantity + "\n" + "Sub Total:" + SubTotal() + "\n";
		}
	}
}
