using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancePrograming
{
	public class Product
	{
		List<OrderDetail> orderDetails = new List<OrderDetail>();

		public int ProductID { get; set; }

		public string Name { get; set; }

		public double Price { get; set; }

		internal List<OrderDetail> OrderDetails { get => orderDetails; set => orderDetails = value; }

		public Product(int productID, string name, double price)
		{
			ProductID = productID;
			Name = name;
			Price = price;
		}
		public Product()
		{
		}

		internal void AddOrderDetail(OrderDetail orderDetail)
		{
			OrderDetails.Add(orderDetail);
		}

		public bool RemoveOrderDetail(Order order)
		{
			var orderDetail = OrderDetails.FirstOrDefault(a => a.Order.Equals(order));
			if (orderDetail == null)
			{
				return false;
			}
			OrderDetails.Remove(orderDetail);
			return true;
		}
		public override string ToString()
		{
			return "Product ID:" + ProductID + " Name:" + Name + " Price:" + Price;
		}
	}
}
