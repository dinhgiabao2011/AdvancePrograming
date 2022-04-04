using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancePrograming
{
	public abstract class Reader
	{
		public string Name { get; set; }

		public string Email { get; set; }

		public string PhoneNumber { get; set; }

		public Reader(string name, string email, string phoneNumber)
		{
			Name = name;
			Email = email;
			PhoneNumber = phoneNumber;
		}
		public Reader()
		{

		}
		public abstract void InputInformation();
	}
}
