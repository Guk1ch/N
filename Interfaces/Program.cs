using System;

namespace Interfaces
{
	class Program
	{
		static void Main(string[] args)
		{
			Gun gun = new Gun();
			gun.MakeShot();
			Knife knife = new Knife();
			knife.MakePush();
			Granade granade = new Granade();
			granade.MakeDrop();
		}
	}
}
