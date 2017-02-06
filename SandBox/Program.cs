using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox {
	class Program {
		static void Main(string[] args)
		{
			Tester();
		}
		static void Tester()
		{
			Test person1 = new Test("Jackson New", 45);
			Console.WriteLine(person1.ToString());
			person1.Age = -12;
			Console.WriteLine(person1.ToString());

		}
	}
	class Test {
		public string Name { get; set; }
		
		private int age;
		public int Age
		{
			get { return age; }
			set {
				age = value;
				if (age < 0) {
					age = 0;
				}
			}
		}
		public Test(string _name, int _age)
		{
			Name = _name;
			Age = _age;
		}
		public override string ToString()
		{
			string tmp = string.Format("Name {0}, Age {1}", Name, Age);
			return tmp;
		}
	}
}
