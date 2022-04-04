using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancePrograming
{
	class BorrowDetail
	{
		public int Quantity { get; set; }

		public Book Book { get; set; }

		public Borrow Borrow { get; set; }

		public BorrowDetail(int quantity, Book book, Borrow borrow)
		{
			Quantity = quantity;
			Book = book;
			Borrow = borrow;
		}
		public BorrowDetail()
		{

		}

		public override string ToString()
		{
			return "Book ID:" + Book.BookID + " Name:" + Book.Name + " Author:" + Book.Author + " Subject:" + Book.Subject + " Quantity:" + Quantity + "\n";
		}
	}
}
