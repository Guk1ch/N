using System;
using System.Collections.Generic;
using System.Text;

namespace weapon
{
	public class MashinGun : BaseWeapon
	{
		public MashinGun()
		{
			Damage = 54;
			Mag = 400;
			Type = "Скорострел";

		}
		public MashinGun(int Dmg, int mag, string tp)
		{
			Damage = Dmg;
			Mag = mag;
			Type = tp;
			
		}

	}
}
