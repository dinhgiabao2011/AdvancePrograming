using System.Collections.Generic;
using System.Linq;

namespace AdvancePrograming
{

	public class Student : Reader, ILogin
	{
		List<Borrow> borrows = new List<Borrow>();

		public int StudentID { get; set; }

		public List<Borrow> Borrows { get => borrows; set => borrows = value; }

		public Student(int studentID)
		{
			StudentID = studentID;
		}
		public Student()
		{
		}

		public bool Login(string usernameToCheck, string passwordToCheck)
		{
			string UserNameCorrect = "Student";
			string PasswordCorrect = "Student";

			if (usernameToCheck == UserNameCorrect && passwordToCheck == PasswordCorrect)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public override void InputInformation()
		{
			this.Name = UI.EnterStudentName();
			this.Email = UI.EnterStudentEmail();
			this.PhoneNumber = UI.EnterStudentPhone();
		}
		public void AddBorrow(Borrow borrow)
		{
			Borrows.Add(borrow);
		}

		//public bool SearchRecordID(int recordIdToSearch)
		//{
		//	var recordInList = Borrows.FirstOrDefault(n => n.RecordId.Equals(recordIdToSearch));
		//	if (recordInList == null)
		//	{
		//		return false;
		//	}
		//	return true;
		//}

		public Borrow SearchRecordIDToReturnBook(int recordIdToSearch)
		{
			var recordInList = Borrows.FirstOrDefault(n => n.RecordId.Equals(recordIdToSearch));
			return recordInList;
		}
		public bool RemoveBorrow(Borrow borrow)
		{
			var borrowInList = Borrows.FirstOrDefault(a => a.RecordId.Equals(borrow.RecordId));
			if (borrowInList == null)
			{
				return false;
			}
			Borrows.Remove(borrowInList);
			return true;
		}
		public string PrintListBorrow()
		{
			string x = "";
			foreach (var borrow in Borrows)
			{
				x += borrow.ToString();
			}
			return x;
		}

		public override string ToString()
		{
			return "Student ID:" + StudentID + " Name:" + Name + " Email:" + Email + " Phone:" + PhoneNumber + "\n" + $"{PrintListBorrow()}\n";
		}
	}
}
