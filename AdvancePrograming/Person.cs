using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancePrograming
{
	public abstract class Person
	{
		public string Name { get; set; }

		public int Age { get; set; }

		public string Address { get; set; }

		public string PhoneNumber { get; set; }

		public Person(string name, int age, string address, string phoneNumber)
		{
			Name = name;
			Age = age;
			Address = address;
			PhoneNumber = phoneNumber;
		}
		public Person()
		{
		}
		public abstract void EnterInformation();
	}
}
