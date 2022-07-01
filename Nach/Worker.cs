using System;
using System.Collections.Generic;
using System.Text;

namespace Nach
{
	public class Worker : IUnit
	{
		public int HP { get => 25; }
		public int Mana { get => 15; }

		public void Service()
		{
			Console.WriteLine("Опять работа");
		}
	}
}
