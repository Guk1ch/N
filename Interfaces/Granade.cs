using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
	public class Granade : IDropable
	{
		public int Radious => 10;

		public int Damage => 100;

		public int ves => 5;

		public int distance => 5;

		public void MakeDrop()
		{
			MakeDamage();
			Console.WriteLine("Granade!!");
		}
		private void MakeDamage()
		{
			Random rnd = new Random();
			int realdamage;
			realdamage = Damage + rnd.Next(0, 50);
			Console.WriteLine(realdamage);
		}
	}
}
