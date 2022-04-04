using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancePrograming
{
	public class Librarian : ILogin
	{
		List<Book> books = new List<Book>();

		List<Student> students = new List<Student>();

		public int LibrarianID { get; set; }

		public List<Book> Books { get => books; set => books = value; }

		public List<Student> Students { get => students; set => students = value; }

		public Librarian(int librarianID)
		{
			LibrarianID = librarianID;
		}

		public Librarian()
		{
		}

		public bool Login(string usernameToCheck, string passwordToCheck)
		{
			string UserNameCorrect = "Librarian";
			string PasswordCorrect = "Librarian";

			if (usernameToCheck == UserNameCorrect && passwordToCheck == PasswordCorrect)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public void AddBook(Book book)
		{
			Books.Add(book);
		}
		public void PrintInformationOfBook()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(" -----------------Books-List-----------------");
			ConsoleTable.From<Book>(Books).Write();
			Console.ForegroundColor = ConsoleColor.White;
			if (!Books.Any())
			{
				Console.WriteLine("Invalid result, Please Do Select 1");
				Console.WriteLine("*****************");
			}
		}
		public bool SearchBookID(int idBookToSearch)
		{
			var bookInList = Books.FirstOrDefault(n => n.BookID.Equals(idBookToSearch));
			if (bookInList == null)
			{
				return false;
			}
			return true;
		}
		public Book SearchObjectBook(int idBookToSearch)
		{
			var bookInList = Books.FirstOrDefault(n => n.BookID.Equals(idBookToSearch));
			return bookInList;
		}
		public bool UpdateBookByID(int idBookToUpdate, string newName, string newAuthor, string newSubject)
		{
			var bookInList = Books.FirstOrDefault(n => n.BookID.Equals(idBookToUpdate));
			bookInList.Name = newName;
			bookInList.Author = newAuthor;
			bookInList.Subject = newSubject;
			return true;
		}
		public bool DeleteBookByID(int idBookToDelete)
		{
			var bookInList = Books.FirstOrDefault(n => n.BookID.Equals(idBookToDelete));
			books.Remove(bookInList);
			return true;
		}
		
		public Student SearchStudentObject(int idStudentToSearch)
		{
			var studentInList = Students.FirstOrDefault(n => n.StudentID.Equals(idStudentToSearch));
			return studentInList;
		}
		public bool SearchStudentID(int idStudentToSearch)
		{
			var studentInList = Students.FirstOrDefault(n => n.StudentID.Equals(idStudentToSearch));
			if (studentInList == null)
			{
				return false;
			}
			return true;
		}
		public void AddInformationStudent()
		{
			Student newStudent = new Student();
			newStudent.StudentID = UI.EnterStudentID();
			newStudent.InputInformation();
			Students.Add(newStudent);
			UI.MenuForReader();
		}
		public Student GetStudentBorrowBookByID(int idStudentToSearch)
		{
			var studentInList = Students.FirstOrDefault(x => x.StudentID.Equals(idStudentToSearch));
			return studentInList;
		}

		

		//public void InformationOfBorrowBook()
		//{
		//	Console.WriteLine("--The Information Of Borrowing Book--");
		//	Console.WriteLine();
		//	foreach (var borrow in borrows)
		//	{
		//		Console.WriteLine("**********************************");
		//		Console.WriteLine($"-Record of ID: {borrow.RecordId}");
		//		Console.WriteLine($"-ID of Student: {borrow.Student.StudentID}");
		//		Console.WriteLine($"-Name of Student: {borrow.Student.Name}");
		//		Console.WriteLine($"-ID of Book: {borrow.Book.BookID}");
		//		Console.WriteLine($"-Email of Student: {borrow.Student.Email}");
		//		Console.WriteLine($"-Phone Of Student: {borrow.Student.PhoneNumber}");
		//		Console.WriteLine($"-Start Date: {borrow.StartDate}");
		//		Console.WriteLine($"-End Date: {borrow.EndDate}");
		//	}
		//	if (!borrows.Any())
		//	{
		//		Console.WriteLine("Invalid result");
		//	}
		//}
		//public void UpdateBook()
		//{
		//	int idBookToUpdate = UI.EnterBookID();
		//	while (!SearchBookID(idBookToUpdate))
		//	{
		//		Console.ForegroundColor = ConsoleColor.Red;
		//		UI.UpdateFail();
		//		Console.ForegroundColor = ConsoleColor.White;
		//		idBookToUpdate = UI.EnterBookID();
		//	}
		//	string nameToEnter = UI.EnterNameOfBook();
		//	string authorToEnter = UI.EnterAuthorOfBook();
		//	string subjectToEnter = UI.EnterSubjectOfBook();
		//	UpdateBookByID(idBookToUpdate, nameToEnter, authorToEnter, subjectToEnter);
		//	Console.ForegroundColor = ConsoleColor.Green;
		//	UI.UpdateSuccessful();
		//	Console.ForegroundColor = ConsoleColor.White;
		//	UI.MenuForLibrarian();
		//}
		//public void DeleteBook()
		//{
		//	int idToDelete = UI.EnterBookID();
		//	while (!SearchBookID(idToDelete))
		//	{
		//		Console.ForegroundColor = ConsoleColor.Red;
		//		UI.DeleteFail();
		//		Console.ForegroundColor = ConsoleColor.White;
		//		idToDelete = UI.EnterBookID();
		//	}
		//	DeleteBookByID(idToDelete);
		//	Console.ForegroundColor = ConsoleColor.Green;
		//	UI.DeleteSuccessful();
		//	Console.ForegroundColor = ConsoleColor.White;
		//	UI.MenuForLibrarian();
		//}


		//public void StudentBorrowBook()
		//{
		//	int recordId = UI.EnterRecordID();
		//	while (SearchRecordID(recordId))
		//	{
		//		Console.ForegroundColor = ConsoleColor.Red;
		//		UI.IdAlreadyExist();
		//		Console.ForegroundColor = ConsoleColor.White;
		//		recordId = UI.EnterRecordID();
		//	}
		//	Book book = new Book();
		//	book.BookID = UI.EnterBookID();
		//	if (!SearchBookID(book.BookID))
		//	{
		//		Console.ForegroundColor = ConsoleColor.Red;
		//		UI.SearchFail();
		//		Console.ForegroundColor = ConsoleColor.White;
		//		book.BookID = UI.EnterBookID();
		//	}
		//	Book bookInList = books.FirstOrDefault(x => x.BookID.Equals(book.BookID));
		//	Console.WriteLine(bookInList.ToString());
		//	Student newStudent = new Student();
		//	newStudent.StudentID = UI.EnterStudentID();
		//	if (!SearchStudentID(newStudent.StudentID))
		//	{
		//		newStudent.InputInformation();
		//		students.Add(newStudent);
		//		DateTime startDate = DateTime.Now.Date;
		//		DateTime endDate = DateTime.Now.AddDays(10);
		//		AddBorowBook(new Borrow(recordId, newStudent, bookInList, startDate, endDate));
		//		Console.ForegroundColor = ConsoleColor.Green;
		//		UI.BorrowSuccessfully();
		//		Console.ForegroundColor = ConsoleColor.White;
		//		UI.MenuForReader();
		//	}
		//	else
		//	{
		//		Student studentInList = students.FirstOrDefault(x => x.StudentID.Equals(newStudent.StudentID));
		//		Console.WriteLine(studentInList.ToString());
		//		DateTime startDate = DateTime.Now.Date;
		//		DateTime endDate = DateTime.Now.AddDays(10);
		//		AddBorowBook(new Borrow(recordId, studentInList, bookInList, startDate, endDate));
		//		Console.ForegroundColor = ConsoleColor.Green;
		//		UI.BorrowSuccessfully();
		//		Console.ForegroundColor = ConsoleColor.White;
		//		UI.MenuForReader();
		//	}
		//}

		//public void ReturnBook()
		//{
		//	string enterName = UI.EnterStudentName();
		//	var studentInListBorrow = borrows.Where(x => x.Student.Name.Equals(enterName)).ToList();
		//	foreach (var borrow in studentInListBorrow)
		//	{
		//		Console.WriteLine(borrow.ToString());
		//	}
		//	int recordId = UI.EnterRecordIdToReturn();
		//	while (!student.SearchRecordID(recordId))
		//	{
		//		Console.ForegroundColor = ConsoleColor.Red;
		//		Console.WriteLine("ID Invalid");
		//		Console.ForegroundColor = ConsoleColor.White;
		//		recordId = UI.EnterRecordIdToReturn();
		//	}
		//	Borrow returnBook = borrows.FirstOrDefault(x => x.RecordId.Equals(recordId));
		//	borrows.Remove(returnBook);
		//	Console.WriteLine("Return Book Successfully");
		//	UI.MenuForReader();
		//}





		//public void BorrowBook()
		//{
		//	int recordId = UI.EnterRecordID();
		//	while (SearchRecordID(recordId))
		//	{
		//		Console.ForegroundColor = ConsoleColor.Red;
		//		UI.IdAlreadyExist();
		//		Console.ForegroundColor = ConsoleColor.White;
		//		recordId = UI.EnterRecordID();
		//	}
		//	Console.WriteLine("Whose order is this?");
		//	Student newStudent = new Student(); 
		//	newStudent.StudentID = UI.EnterStudentID();
		//	Student studentInList = students.FirstOrDefault(x => x.StudentID.Equals(newStudent.StudentID));

		//	DateTime startDate = DateTime.Now.Date;
		//	DateTime endDate = DateTime.Now.AddDays(10);
		//	Borrow borrowBook =  new Borrow(recordId, studentInList, startDate, endDate);
		//	AddBorowBook(borrowBook);
		//	Console.WriteLine("How many Borrow Book");
		//	int numDetail = int.Parse(Console.ReadLine());
		//	for (int i = 0; i < numDetail; i++)
		//	{
		//		Book book = new Book();
		//		book.BookID = UI.EnterBookID();
		//		if (!SearchBookID(book.BookID))
		//		{
		//			Console.ForegroundColor = ConsoleColor.Red;
		//			UI.SearchFail();
		//			Console.ForegroundColor = ConsoleColor.White;
		//			book.BookID = UI.EnterBookID();
		//		}
		//		Book bookInList = books.FirstOrDefault(x => x.BookID.Equals(book.BookID));
		//		Console.WriteLine(bookInList.ToString());
		//		BorrowDetail borrowDetail = new BorrowDetail(UI.EnterQuantity(), bookInList, borrowBook);
		//		borrowBook.AddBorrowDetail(borrowDetail);
		//		bookInList.AddBorrowDetail(borrowDetail);


		//	}
		//}
	}
}
