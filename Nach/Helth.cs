using System;
using System.Collections.Generic;
using System.Text;

namespace Nach
{
	public class Helth : IUnit
	{
		public int HP { get => 35; }
		public int Mana { get => 55; }

		public void Service()
		{
			Console.WriteLine("Опять KЛечить");
		}
	}
}
