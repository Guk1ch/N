using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
	public class Gun : IShot
	{
		public int Damage { get => 35; }
		public int Mag { get => 10; }
		public int ves { get => 35; }
		public int distance { get => 35; }

		public void MakeShot()
		{

			for (int i = 0; Mag >= i; i++)
			{
				MakeDamage();
				Console.WriteLine("Shot");

			}
		}
		private void MakeDamage() 
		{
			Random rnd = new Random();
			int realdamage;
			realdamage = Damage + rnd.Next(0, 7);
			Console.WriteLine(realdamage);
		}
	}
}
