using System;
using System.Collections.Generic;
using System.Text;

namespace Nach
{
	public class Solder : IUnit
	{
		public int HP { get => 55; }
		public int Mana { get => 25; }

		public void Service()
		{
			Console.WriteLine("Опять Убивать!");
		}
	}
}
