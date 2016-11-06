using System;
using System.Collections.Generic;
namespace Tema1
{
	public class Discipline
	{
		private List<string> _materie;

		public List<string> Materie
		{
			set { _materie = value; }
			get { return _materie; }
		}

	}
}
