using System;
using System.Collections.Generic;
using System.Text;

namespace Nach
{
	public interface IUnit
	{
		int HP { get; }
		int Mana { get;}
		void Service(); 

	}
}
