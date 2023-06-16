using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancePrograming
{
	public class Staff
	{
		List<Product> products = new List<Product>();

		List<Customer> customers = new List<Customer>();

		public int StaffID { get; set; }

		public List<Product> Products { get => products; set => products = value; }

		public List<Customer> Customers { get => customers; set => customers = value; }

		public Staff(int staffID)
		{
			StaffID = staffID;
		}

		public Staff()
		{
		}

		public void AddProduct(Product product)
		{
			Products.Add(product);
		}
		public void PrintInformationOfProduct()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(" -----------------Product-List-----------------");
			ConsoleTable.From<Product>(Products).Write();
			Console.ForegroundColor = ConsoleColor.White;
			if (!Products.Any())
			{
				Console.WriteLine("Invalid result, Please Do Select 1");
				Console.WriteLine("*****************");
			}
		}
		public bool SearchProductID(int idProductToSearch)
		{
			var productInList = Products.FirstOrDefault(n => n.ProductID.Equals(idProductToSearch));
			if (productInList == null)
			{
				return false;
			}
			return true;
		}
		public Product SearchObjectProduct(int idProductToSearch)
		{
			var productInList = Products.FirstOrDefault(n => n.ProductID.Equals(idProductToSearch));
			return productInList;
		}
		public bool UpdateProductByID(int idProductToUpdate, string newName, double newPrice)
		{
			var productInList = Products.FirstOrDefault(n => n.ProductID.Equals(idProductToUpdate));
			productInList.Name = newName;
			productInList.Price = newPrice;
			return true;
		}
		public bool DeleteProductByID(int idProductToDelete)
		{
			var productInList = Products.FirstOrDefault(n => n.ProductID.Equals(idProductToDelete));
			Products.Remove(productInList);
			return true;
		}
		
		public Customer SearchCustomerObject(int idCustomerToSearch)
		{
			var customerInList = Customers.FirstOrDefault(n => n.CustomerID.Equals(idCustomerToSearch));
			return customerInList;
		}
		public bool SearchCustomerID(int idCustomerToSearch)
		{
			var customerInList = Customers.FirstOrDefault(n => n.CustomerID.Equals(idCustomerToSearch));
			if (customerInList == null)
			{
				return false;
			}
			return true;
		}
		public void AddInformationCustomer()
		{
			Customer newCustomer = new Customer();
			newCustomer.CustomerID = UI.EnterCustomerID();
			while (SearchCustomerID(newCustomer.CustomerID))
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Customer ID already Exist. Please Enter Customer ID again");
				Console.ForegroundColor = ConsoleColor.White;
				newCustomer.CustomerID = UI.EnterCustomerID();
			}
			newCustomer.EnterInformation();
			Customers.Add(newCustomer);
		}
		public Customer GetCustomerOrderProductByID(int idCustomerToSearch)
		{
			var customerInList = Customers.FirstOrDefault(x => x.CustomerID.Equals(idCustomerToSearch));
			return customerInList;
		}
	}
}
