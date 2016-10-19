using System;
namespace Tema1
{
	public class Student
	{
		public string nume;
		public string prenume;
		public int varsta;
		public int anul;

		public void SetNume(string _nume)
		{
			nume = _nume;
		}

		public void SetPreunume(string _preunume)
		{
			prenume = _preunume;
		}

		public void SetVarsta(int _varsta)
		{
			varsta = _varsta;
		}

		public void SetAn(int _an)
		{
			anul = _an;
		}
	}
}
