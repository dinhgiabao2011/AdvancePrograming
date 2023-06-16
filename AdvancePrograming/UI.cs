using System;

namespace AdvancePrograming
{
	class UI
	{
		public static void Title()
		{
			Console.WriteLine("*****************************");
			Console.WriteLine("** Welcom to Tra Sua Store **");
			Console.WriteLine("*****************************");
		}
		
		public static void Menu()
		{
			Console.WriteLine();
			Console.WriteLine("1. Add Product");
			Console.WriteLine("2. View Product");
			Console.WriteLine("3. Update Product");
			Console.WriteLine("4. Delete Product");
			Console.WriteLine("5. Add Information Customer ");
			Console.WriteLine("6. Order Product ");
			Console.WriteLine("7. Customer Order Product Management");
			Console.WriteLine("8. Search Order Product");
			Console.WriteLine("9. Remove Order Product");
			Console.WriteLine("10. Exit");
			Console.WriteLine();
			Console.WriteLine("Please choose your option");

		}
	
		public static int EnterProductID()
		{
			Console.Write("* Enter Product ID: ");
			return int.Parse(Console.ReadLine());
		}
		public static int EnterQuantity()
		{
			Console.Write("* Enter Quantity: ");
			return int.Parse(Console.ReadLine());
		}
		public static int EnterRecordID()
		{
			Console.Write("* Enter Record ID: ");
			return int.Parse(Console.ReadLine());
		}
		public static int EnterRecordIdToRemove()
		{
			Console.Write("* Enter Record ID to remove Product: ");
			return int.Parse(Console.ReadLine());
		}
		public static string EnterNameOfProduct()
		{
			Console.Write("* Enter Name of Product: ");
			return Console.ReadLine();
		}
		public static double EnterPriceOfProduct()
		{
			Console.Write("* Enter Price of Product: ");
			return double.Parse(Console.ReadLine());
		}
		public static string TypeExitToFinish()
		{
			Console.WriteLine("Type Exit to Finish Option!!!");
			return Console.ReadLine();
		}
		public static void UpdateSuccessful()
		{
			Console.WriteLine("Update successfully!!!");
		}
		public static void UpdateFail()
		{
			Console.WriteLine("Update Fail!!!");
			Console.WriteLine("Please enter ID Again!!!");
		}
		public static void SearchFail()
		{
			Console.WriteLine("Invalid Result!!!");
			Console.WriteLine("Please enter ID Again!!!");
		}
		public static void SearchNameCustomerFail()
		{
			Console.WriteLine("Invalid Result!!!");
			Console.WriteLine("Please enter Name Again!!!");
		}
		public static void DeleteFail()
		{
			Console.WriteLine("Delete Fail!!!");
			Console.WriteLine("Please enter ID Again!!!");
		}
		public static void AddSuccessful()
		{
			Console.WriteLine("Add Successfully!!!");
		}
		public static void DeleteSuccessful()
		{
			Console.WriteLine("Delete successfully!!!");
		}
		public static int EnterCustomerID()
		{
			Console.Write("* Enter Customer ID: ");
			return int.Parse(Console.ReadLine());
		}
		public static int EnterCustomerAge()
		{
			Console.Write("* Enter Customer Age: ");
			return int.Parse(Console.ReadLine());
		}
		public static string EnterCustomerName()
		{
			Console.Write("* Enter Customer Name: ");
			return Console.ReadLine();
		}
		public static string EnterCustomerAddress()
		{
			Console.Write("* Enter Customer Address: ");
			return Console.ReadLine();
		}
		public static string EnterCustomerPhone()
		{
			Console.Write("* Enter Customer Phone: ");
			return Console.ReadLine();
		}
		public static void IdAlreadyExist()
		{
			Console.WriteLine("Id Already Exist. Please Enter Another ID !!!");
		}
		public static void OrderSuccessfully()
		{
			Console.WriteLine("Order Successfully");
		}
	}
}
