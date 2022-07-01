using System;
namespace InterfacesPractice
{
	public interface IPerson : IDepartment
	{
		//Salary cannot be negative
		//ushort salary(int time);
		/*
		 * salary method
		 */
		decimal salary(decimal time);
		byte age(int bornYear)
        {
			return (byte)(2022 - bornYear);
        }
		String[] add { get; set; }
		bool head { get; set; }

	}
}

