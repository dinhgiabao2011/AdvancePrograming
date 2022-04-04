using System;

namespace AdvancePrograming
{
	class Program
	{
		static Librarian librarian = new Librarian();
		static Student student = new Student();

		static void Main(string[] args)
		{
			UI.Title();
		MenuCommand:
			UI.MenuForLogin();
			try
			{
				int optionForLogin = int.Parse(Console.ReadLine());
				do
				{
					switch (optionForLogin)
					{
						case 1:
							do
							{
								Console.ForegroundColor = ConsoleColor.Cyan;
								Console.WriteLine("Librarian-Login-----------");
								Console.ForegroundColor = ConsoleColor.White;
								Console.Write("Enter Username of Librarian: ");
								string EnterUserName = Console.ReadLine();
								Console.Write("Enter Password of Librarian: ");
								string EnterPassword = Console.ReadLine();
								if (librarian.Login(EnterUserName, EnterPassword))
								{
									Console.WriteLine();
									Console.ForegroundColor = ConsoleColor.Green;
									Console.WriteLine("Login Successfully");
									Console.ForegroundColor = ConsoleColor.White;
									UI.MenuForLibrarian();
									do
									{
										int optionForMenuLibrarian = int.Parse(Console.ReadLine());
										switch (optionForMenuLibrarian)
										{
											case 1:
												try
												{
													int bookID = UI.EnterBookID();
													while (librarian.SearchBookID(bookID))
													{
														UI.IdAlreadyExist();
														bookID = UI.EnterBookID();
													}
													string nameOfBook = UI.EnterNameOfBook();
													string authorOfBook = UI.EnterAuthorOfBook();
													string subjectOfBook = UI.EnterSubjectOfBook();
													librarian.AddBook(new Book(bookID, nameOfBook, authorOfBook, subjectOfBook));
													Console.ForegroundColor = ConsoleColor.Green;
													UI.AddSuccessful();
													Console.ForegroundColor = ConsoleColor.White;
													UI.MenuForLibrarian();
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
												librarian.PrintInformationOfBook();
												UI.MenuForLibrarian();
												break;
											case 3:
												try
												{
													int idBookToUpdate = UI.EnterBookID();
													while (!librarian.SearchBookID(idBookToUpdate))
													{
														Console.ForegroundColor = ConsoleColor.Red;
														UI.UpdateFail();
														Console.ForegroundColor = ConsoleColor.White;
														idBookToUpdate = UI.EnterBookID();
													}
													string nameToEnter = UI.EnterNameOfBook();
													string authorToEnter = UI.EnterAuthorOfBook();
													string subjectToEnter = UI.EnterSubjectOfBook();
													librarian.UpdateBookByID(idBookToUpdate, nameToEnter, authorToEnter, subjectToEnter);
													Console.ForegroundColor = ConsoleColor.Green;
													UI.UpdateSuccessful();
													Console.ForegroundColor = ConsoleColor.White;
													UI.MenuForLibrarian();
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
													int idToDelete = UI.EnterBookID();
													while (!librarian.SearchBookID(idToDelete))
													{
														Console.ForegroundColor = ConsoleColor.Red;
														UI.DeleteFail();
														Console.ForegroundColor = ConsoleColor.White;
														idToDelete = UI.EnterBookID();
													}
													librarian.DeleteBookByID(idToDelete);
													Console.ForegroundColor = ConsoleColor.Green;
													UI.DeleteSuccessful();
													Console.ForegroundColor = ConsoleColor.White;
													UI.MenuForLibrarian();
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
												foreach (var student in librarian.Students)
												{
													Console.WriteLine(student.ToString());
												}
												UI.MenuForLibrarian();
												break;
											case 6:
												int enterID = UI.EnterStudentID();
												var studentInListBorrow = librarian.GetStudentBorrowBookByID(enterID);
												Console.WriteLine(studentInListBorrow.ToString());
												UI.MenuForLibrarian();
												break;
											case 7:
												goto MenuCommand;
										}
									} while (true);
								}
								else
								{
									Console.WriteLine();
									Console.ForegroundColor = ConsoleColor.Red;
									Console.WriteLine("Login Fail");
									Console.ForegroundColor = ConsoleColor.White;
									UI.MenuForLogin();
								}
							}
							while (optionForLogin != 3);
							break;
						case 2:
							do
							{
								Console.ForegroundColor = ConsoleColor.Cyan;
								Console.WriteLine("Student-Login-----------");
								Console.ForegroundColor = ConsoleColor.White;
								Console.Write("Enter Username of Student: ");
								string EnterUserName = Console.ReadLine();
								Console.Write("Enter Password of Student: ");
								string EnterPassword = Console.ReadLine();
								student.Login(EnterUserName, EnterPassword);
								if (student.Login(EnterUserName, EnterPassword))
								{
									Console.WriteLine();
									Console.ForegroundColor = ConsoleColor.Green;
									Console.WriteLine("Login Successfully");
									Console.ForegroundColor = ConsoleColor.White;
									UI.MenuForReader();
									do
									{
										int optionForMenuReader = int.Parse(Console.ReadLine());
										switch (optionForMenuReader)
										{
											case 1:
												librarian.PrintInformationOfBook();
												UI.MenuForReader();
												break;
											case 2:
												librarian.AddInformationStudent();
												break;
											case 3:
												try
												{
													int recordId = UI.EnterRecordID();
													Console.WriteLine("Enter Student ID to Borow Book:");
													Student newStudent = new Student();
													newStudent.StudentID = UI.EnterStudentID();
													while (!librarian.SearchStudentID(newStudent.StudentID))
													{
														Console.ForegroundColor = ConsoleColor.Red;
														Console.WriteLine("Student ID not Exist. Please Enter Student ID again");
														Console.ForegroundColor = ConsoleColor.White;
														newStudent.StudentID = UI.EnterStudentID();
													}
													Student studentInList = librarian.SearchStudentObject(newStudent.StudentID);
													DateTime startDate = DateTime.Now.Date;
													DateTime endDate = DateTime.Now.AddDays(10);
													Borrow borrowBook = new Borrow(recordId, studentInList, startDate, endDate);
													studentInList.AddBorrow(borrowBook);
													Console.WriteLine("How many Book You want to Borrow?");
													int numDetail = int.Parse(Console.ReadLine());
													for (int i = 0; i < numDetail; i++)
													{
														Book book = new Book();
														book.BookID = UI.EnterBookID();
														while (!librarian.SearchBookID(book.BookID))
														{
															Console.ForegroundColor = ConsoleColor.Red;
															Console.WriteLine("Book ID not Exist. Please Enter Book ID again");
															Console.ForegroundColor = ConsoleColor.White;
															book.BookID = UI.EnterBookID();
														}
														Book bookInList = librarian.SearchObjectBook(book.BookID);
														Console.WriteLine(bookInList.ToString());
														BorrowDetail borrowDetail = new BorrowDetail(UI.EnterQuantity(), bookInList, borrowBook);
														borrowBook.AddBorrowDetail(borrowDetail);
														bookInList.AddBorrowDetail(borrowDetail);
														Console.ForegroundColor = ConsoleColor.Green;
														UI.BorrowSuccessfully();
														Console.ForegroundColor = ConsoleColor.White;
													}
													UI.MenuForReader();
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
												int enterID = UI.EnterStudentID();
												var studentInListBorrow = librarian.GetStudentBorrowBookByID(enterID);
												Console.WriteLine(studentInListBorrow.ToString());
												int recordID = UI.EnterRecordIdToReturn();
												var searchBorrow = studentInListBorrow.SearchRecordIDToReturnBook(recordID);
												foreach (var retrunBookBorrow in searchBorrow.BorrowDetails)
												{
													retrunBookBorrow.Book.RemoveBorrowDetail(searchBorrow);
												}
												studentInListBorrow.RemoveBorrow(searchBorrow);
												Console.WriteLine("Return Book Successfully");
												UI.MenuForReader();
												break;
											case 5:
												goto MenuCommand;
										}
									}
									while (true);
								}
								else
								{
									Console.WriteLine();
									Console.ForegroundColor = ConsoleColor.Red;
									Console.WriteLine("Login Fail");
									Console.ForegroundColor = ConsoleColor.White;
									UI.MenuForLogin();
								}
							}
							while (optionForLogin != 3);
							break;
						case 3:
							Console.WriteLine("Thank you for using Library Management");
							break;
					}
				}
				while (optionForLogin < 3);
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
