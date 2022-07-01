using System;
using System.Collections.Generic;
using System.Text;

namespace weapon
{
	public class BaseWeapon
	{
	 	public int Damage;
		public int Mag;
		public string Type;
		public void MakeDamage() 
		{
			Random rnd = new Random();
			int realdamage;
			realdamage = Damage + rnd.Next(0, 7);
			Console.WriteLine(realdamage);
		}
	}
}
