
using System;
namespace Salary
{
	public class salary
	{
		//This answers the 5th and the 4th one;
		abstract class person1
		{
			public int height { get; set; }
			//int id;

			public abstract void DoWork();
			public abstract void salary(int t);


			public static void Main(string[] args)
			{
				var s = new student();
				s.salary(20);


				var i = new instructor();
				i.salary(40);
			}
		}

		class student : person1
		{
			public override void DoWork()
			{//Overide 
				Console.WriteLine("Student : Just study");
			}

			public override void salary(int time)
			{//Overide 
				Console.WriteLine("Salary : {0} for students ", time * 3);
			}
		}

		class instructor : person1
		{
			public override void DoWork()
			{//Overide 
				Console.WriteLine("Instructor : Teach students");
			}
			public override void salary(int time)
			{//Overide 
				Console.WriteLine("Salary : {0} for instructors", time * 100);
			}
		}
	}
}


