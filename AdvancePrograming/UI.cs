using System;

namespace AdvancePrograming
{
	class UI
	{
		public static void Title()
		{
			Console.WriteLine("*********************************************");
			Console.WriteLine("** Welcom to The Library Management System **");
			Console.WriteLine("*********************************************");
		}
		public static void MenuForLogin()
		{
			Console.WriteLine();
			Console.WriteLine("1. Login as a Librarian");
			Console.WriteLine("2. Login as a Student");
			Console.WriteLine("3. Exit");
			Console.WriteLine();
		}
		public static void MenuForLibrarian()
		{
			Console.WriteLine();
			Console.WriteLine("1. Add Book");
			Console.WriteLine("2. View Book");
			Console.WriteLine("3. Update Book");
			Console.WriteLine("4. Delete Book");
			Console.WriteLine("5. Borrow Book Management");
			Console.WriteLine("6. Search Borrow Book");
			Console.WriteLine("7. Logout");
			Console.WriteLine();
			Console.WriteLine("Please choose your option");

		}
		public static void MenuForReader()
		{
			Console.WriteLine();
			Console.WriteLine("1. View Book");
			Console.WriteLine("2. Add Information Student");
			Console.WriteLine("3. Borrow Book");
			Console.WriteLine("4. Return Book");
			Console.WriteLine("5. Logout");
			Console.WriteLine();
			Console.WriteLine("Please choose your option");

		}

		public static int EnterBookID()
		{
			Console.Write("* Enter Book ID: ");
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
		public static int EnterRecordIdToReturn()
		{
			Console.Write("* Enter Record ID to return Book: ");
			return int.Parse(Console.ReadLine());
		}
		public static string EnterNameOfBook()
		{
			Console.Write("* Enter Name of Book: ");
			return Console.ReadLine();
		}
		public static string EnterAuthorOfBook()
		{
			Console.Write("* Enter Author of Book: ");
			return Console.ReadLine();
		}
		public static string EnterSubjectOfBook()
		{
			Console.Write("* Enter Subject of Book: ");
			return Console.ReadLine();
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
		public static void SearchNameStudentFail()
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
		public static int EnterStudentID()
		{
			Console.Write("* Enter Student ID: ");
			return int.Parse(Console.ReadLine());
		}
		public static string EnterStudentName()
		{
			Console.Write("* Enter Student Name: ");
			return Console.ReadLine();
		}
		public static string EnterStudentEmail()
		{
			Console.Write("* Enter Student Email: ");
			return Console.ReadLine();
		}
		public static string EnterStudentPhone()
		{
			Console.Write("* Enter Student Phone: ");
			return Console.ReadLine();
		}
		public static void IdAlreadyExist()
		{
			Console.WriteLine("Id Already Exist. Please Enter Another ID !!!");
		}
		public static void BorrowSuccessfully()
		{
			Console.WriteLine("Borrow Successfully");
		}
	}
}
