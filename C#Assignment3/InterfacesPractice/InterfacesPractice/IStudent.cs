using System;
namespace InterfacesPractice
{
	public interface IStudent : IPerson 
	{
		ushort[] course { get; set; }
		//From A to F
		char[] grade { get; set; }
		//Folat
		float gpa { get; set; }


	}
}

