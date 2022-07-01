using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
	public class Knife : Imele
	{
		
		public int Damage => 10;

		public int ves => 1;

		public int distance => 1;

		public void MakePush()
		{
			MakeDamage();
			Console.WriteLine("Получай сука!!");
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
