using System;

namespace AdvancePrograming
{
	class Program
	{
		static Staff staff = new Staff();
		static Customer customer = new Customer();

		static void Main(string[] args)
		{
			UI.Title();
			UI.Menu();
			int option;
			try
			{
				do
				{
					option = int.Parse(Console.ReadLine());
					switch (option)
					{

						case 1:
							try
							{
								int ProductID = UI.EnterProductID();
								while (staff.SearchProductID(ProductID))
								{
									UI.IdAlreadyExist();
									ProductID = UI.EnterProductID();
								}
								string nameOfProduct = UI.EnterNameOfProduct();
								double priceToEnter = UI.EnterPriceOfProduct();
								staff.AddProduct(new Product(ProductID, nameOfProduct, priceToEnter));
								Console.ForegroundColor = ConsoleColor.Green;
								UI.AddSuccessful();
								Console.ForegroundColor = ConsoleColor.White;
								UI.Menu();
							}
							
							catch (FormatException ex)
							{
								Console.WriteLine("Please enter the number\n" + ex.Message);
							}
							catch (Exception ex)
							{
								Console.WriteLine("Error " + ex.Message);
							}
							break;
						case 2:
							staff.PrintInformationOfProduct();
							UI.Menu();
					    break;
						case 3:
							try
				      {
					      int idProductToUpdate = UI.EnterProductID();
								while (!staff.SearchProductID(idProductToUpdate))
								{
									Console.ForegroundColor = ConsoleColor.Red;
									UI.UpdateFail();
									Console.ForegroundColor = ConsoleColor.White;
									idProductToUpdate = UI.EnterProductID();
								}
								string nameToEnter = UI.EnterNameOfProduct();
								double priceToEnter = UI.EnterPriceOfProduct();
								staff.UpdateProductByID(idProductToUpdate, nameToEnter, priceToEnter);
								Console.ForegroundColor = ConsoleColor.Green;
								UI.UpdateSuccessful();
								Console.ForegroundColor = ConsoleColor.White;
								UI.Menu();
							}
							catch (FormatException ex)
							{
								Console.WriteLine("Please enter the number\n" + ex.Message);
							}
							catch (Exception ex)
							{
								Console.WriteLine("Error " + ex.Message);
							}
							break;
						case 4:
							try
							{
								int idToDelete = UI.EnterProductID();
								while (!staff.SearchProductID(idToDelete))
								{
									Console.ForegroundColor = ConsoleColor.Red;
									UI.DeleteFail();
									Console.ForegroundColor = ConsoleColor.White;
									idToDelete = UI.EnterProductID();
								}
								staff.DeleteProductByID(idToDelete);
								Console.ForegroundColor = ConsoleColor.Green;
								UI.DeleteSuccessful();
								Console.ForegroundColor = ConsoleColor.White;
								UI.Menu();
							}
							catch (FormatException ex)
							{
								Console.WriteLine("Please enter the number\n" + ex.Message);
							}
							catch (Exception ex)
							{
								Console.WriteLine("Error " + ex.Message);
							}
							break;
						case 5:
							staff.AddInformationCustomer();
							Console.ForegroundColor = ConsoleColor.Green;
							UI.AddSuccessful();
							Console.ForegroundColor = ConsoleColor.White;
							UI.Menu();
							
							break;
						case 6:
							try
							{
								int recordId = UI.EnterRecordID();
								Console.WriteLine("Enter Customer ID to Order Product:");
								Customer newCustomer = new Customer();
								newCustomer.CustomerID = UI.EnterCustomerID();
								while (!staff.SearchCustomerID(newCustomer.CustomerID))
								{
									Console.ForegroundColor = ConsoleColor.Red;
									Console.WriteLine("Customer ID not Exist. Please Enter Customer ID again");
									Console.ForegroundColor = ConsoleColor.White;
									newCustomer.CustomerID = UI.EnterCustomerID();
								}
								Customer customerInList = staff.SearchCustomerObject(newCustomer.CustomerID);
								DateTime date = DateTime.Now.Date;
								Order orderProduct = new Order(recordId, customerInList, date);
								customerInList.AddOrder(orderProduct);
								Console.WriteLine("How many Product You want to Order?");
								int numDetail = int.Parse(Console.ReadLine());
								for (int i = 0; i < numDetail; i++)
								{
									Product product = new Product();
									product.ProductID = UI.EnterProductID();
									while (!staff.SearchProductID(product.ProductID))
									{
										Console.ForegroundColor = ConsoleColor.Red;
										Console.WriteLine("Product ID not Exist. Please Enter Product ID again");
										Console.ForegroundColor = ConsoleColor.White;
										product.ProductID = UI.EnterProductID();
									}
									Product productInList = staff.SearchObjectProduct(product.ProductID);
									Console.WriteLine(productInList.ToString());
									OrderDetail orderDetail = new OrderDetail(UI.EnterQuantity(), productInList, orderProduct);
									orderProduct.AddOrderDetail(orderDetail);
									productInList.AddOrderDetail(orderDetail);
									Console.ForegroundColor = ConsoleColor.Green;
									UI.OrderSuccessfully();
									Console.ForegroundColor = ConsoleColor.White;
								}
								UI.Menu();
							}
							catch (FormatException ex)
							{
								Console.WriteLine("Please enter the number\n" + ex.Message);
							}
							catch (Exception ex)
							{
								Console.WriteLine("Error " + ex.Message);
							}
							break;
						case 7:
							foreach (var customer in staff.Customers)
							{
								Console.WriteLine(customer.ToString());
							}
							UI.Menu();
							break;
						case 8:
							int enterID = UI.EnterCustomerID();
							var customerInListOrder = staff.GetCustomerOrderProductByID(enterID);
							Console.WriteLine(customerInListOrder.ToString());
							UI.Menu();
							break;
						case 9:
							int enterId = UI.EnterCustomerID();
							var customerInListOrders = staff.GetCustomerOrderProductByID(enterId);
							Console.WriteLine(customerInListOrders.ToString());
							int recordID = UI.EnterRecordIdToRemove();
							var searchOrder = customerInListOrders.SearchRecordIDToRemoveOrder(recordID);
							foreach (var removeProductOrder in searchOrder.OrderDetails)
							{
								removeProductOrder.Product.RemoveOrderDetail(searchOrder);
							}
							customerInListOrders.RemoveOrder(searchOrder);
							Console.WriteLine("Remove Order Product Successfully");
							UI.Menu();
							break;
						case 10:
							Console.WriteLine("Thank you for using Library Management");
							break;
					}
				} while (option!=10);
			}
			catch (FormatException ex)
			{
				Console.WriteLine("Please enter the number\n" + ex.Message);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error " + ex.Message);
			}
			Console.ReadLine();
		}
	}
}
