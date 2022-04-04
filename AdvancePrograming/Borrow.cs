using System;
using System.Collections.Generic;

namespace AdvancePrograming
{
	public class Borrow
	{
		List<BorrowDetail> borrowDetails = new List<BorrowDetail>();

		public int RecordId { get; set; }

		public Student Student { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		internal List<BorrowDetail> BorrowDetails { get => borrowDetails; set => borrowDetails = value; }

		public Borrow(int recordId, Student student, DateTime startDate, DateTime endDate)
		{
			RecordId = recordId;
			Student = student;
			StartDate = startDate;
			EndDate = endDate;
		}

		public Borrow()
		{
		}

		internal void AddBorrowDetail(BorrowDetail borrowDetail)
		{
			BorrowDetails.Add(borrowDetail);
		}

		public string PrintBorrowDetail()
		{
			string x = "";
			foreach (var borrowDetail in BorrowDetails)
			{
				x += borrowDetail.ToString();
			}
			return x;
		}

		public override string ToString()
		{
			return "Record ID:" + RecordId + "\n" + $"{ PrintBorrowDetail()}" + "StartDate:" + StartDate + " EndDate:" + EndDate + "\n";
		}
	}
}
