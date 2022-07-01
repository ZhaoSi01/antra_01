using System;
namespace InterfacesPractice
{
	public interface IDepartment
	{
		//Instructor name as head;
		String head { get; set; }
		decimal budget(int start, int end);
		List<int> courseList { get; set; }
	}
}

