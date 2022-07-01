using System;
namespace InterfacesPractice
{
	public interface IStudent : IPerson
	{
		ushort[] course { get; set; }
		float gpa { get; set; }


	}
}

