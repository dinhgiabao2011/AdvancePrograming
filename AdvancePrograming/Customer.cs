using System.Collections.Generic;
using System.Linq;

namespace AdvancePrograming
{

	public class Customer : Person
	{
		List<Order> orders = new List<Order>();

		public int CustomerID { get; set; }

		public List<Order> Orders { get => orders; set => orders = value; }

		public Customer(int customerID)
		{
			CustomerID = customerID;
		}
		public Customer()
		{
		}

		public override void EnterInformation()
		{
			this.Name = UI.EnterCustomerName();
			this.Age = UI.EnterCustomerAge();
			this.Address = UI.EnterCustomerAddress();
			this.PhoneNumber = UI.EnterCustomerPhone();
		}
		public void AddOrder(Order order)
		{
			Orders.Add(order);
		}

		public Order SearchRecordIDToRemoveOrder(int recordIdToSearch)
		{
			var recordInList = Orders.FirstOrDefault(n => n.RecordId.Equals(recordIdToSearch));
			return recordInList;
		}
		public bool SearchRecordID(int idRecordToSearch)
		{
			var recordInList = Orders.FirstOrDefault(n => n.RecordId.Equals(idRecordToSearch));
			if (recordInList == null)
			{
				return false;
			}
			return true;
		}
		public bool RemoveOrder(Order order)
		{
			var orderInList = Orders.FirstOrDefault(a => a.RecordId.Equals(order.RecordId));
			if (orderInList == null)
			{
				return false;
			}
			Orders.Remove(orderInList);
			return true;
		}
		public string PrintListOrder()
		{
			string x = "";
			foreach (var order in Orders)
			{
				x += order.ToString();
			}
			return x;
		}

		public override string ToString()
		{
			return "Customer ID:" + CustomerID + " Name:" + Name + " Age:" + Age + " Phone:" + PhoneNumber +" Address:" + Address + "\n" + $"{PrintListOrder()}\n";
		}
	}
}
