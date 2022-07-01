using System;

namespace weapon
{
	class Program
	{
		static void Main(string[] args)
		{
			MashinGun gun = new MashinGun();
			gun.MakeDamage();
			MashinGun mashin = new MashinGun(12, 15, "не скорострел");
			mashin.MakeDamage();
			
		}
	}
}
