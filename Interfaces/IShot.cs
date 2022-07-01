using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
	public interface IShot : Iweapon
	{
		int Mag { get; }
		public void MakeShot();
	}
}
