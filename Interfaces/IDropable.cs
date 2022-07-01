using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
	public interface IDropable : Iweapon
	{
		int Radious { get; }
		public void MakeDrop();
	}
}
