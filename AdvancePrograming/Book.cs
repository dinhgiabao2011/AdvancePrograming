using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancePrograming
{
	public class Book
	{
		List<BorrowDetail> borrowDetails = new List<BorrowDetail>();

		public int BookID { get; set; }

		public string Name { get; set; }

		public string Author { get; set; }

		public string Subject { get; set; }

		internal List<BorrowDetail> BorrowDetails { get => borrowDetails; set => borrowDetails = value; }

		public Book(int bookID, string name, string author, string subject)
		{
			BookID = bookID;
			Name = name;
			Author = author;
			Subject = subject;
		}
		public Book()
		{
		}

		internal void AddBorrowDetail(BorrowDetail borrowDetail)
		{
			BorrowDetails.Add(borrowDetail);
		}

		public bool RemoveBorrowDetail(Borrow borrow)
		{
			var borrowDetail = BorrowDetails.FirstOrDefault(a => a.Borrow.Equals(borrow));
			if (borrowDetail == null)
			{
				return false;
			}
			BorrowDetails.Remove(borrowDetail);
			return true;
		}
		public override string ToString()
		{
			return "Book ID:" + BookID + " Name:" + Name + " Author:" + Author + " Subject:" + Subject;
		}
	}
}
