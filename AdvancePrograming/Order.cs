using System;
using System.Collections.Generic;

namespace AdvancePrograming
{
	public class Order
	{
		List<OrderDetail> orderDetails = new List<OrderDetail>();

		public int RecordId { get; set; }

		public Customer Customer { get; set; }

		public DateTime Date { get; set; }

		internal List<OrderDetail> OrderDetails { get => orderDetails; set => orderDetails = value; }

		public Order(int recordId, Customer customer, DateTime date)
		{
			RecordId = recordId;
			Customer = customer;
			Date = date;
		}

		public Order()
		{
		}

		internal void AddOrderDetail(OrderDetail orderDetail)
		{
			OrderDetails.Add(orderDetail);
		}

		public string PrintOrderDetail()
		{
			string x = "";
			foreach (var orderDetail in OrderDetails)
			{
				x += orderDetail.ToString();
			}
			return x;
		}

		public double Total()
		{
			double result = 0;
			foreach (var item in OrderDetails)
			{
				result += item.SubTotal();
			}
			return result;
		}

		public override string ToString()
		{
			return "Record ID:" + RecordId + "\n" + $"{ PrintOrderDetail()}" + "Date:" + Date + "\n" + "Total:" + Total() + "\n";
		}
	}
}
