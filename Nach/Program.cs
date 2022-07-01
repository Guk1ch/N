using System;

namespace Nach
{
	class Program
	{
		static void Main(string[] args)
		{
			Worker worker = new Worker();
			worker.Service();
			Solder solder = new Solder();
			solder.Service();
			Console.WriteLine(solder.HP);
			Helth helth = new Helth();
			helth.Service();
		}
	}
}
