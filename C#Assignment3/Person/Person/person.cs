using System;
namespace Person
{
	//This answers the 2th and the 4th one;
	abstract class person1
	{//int height;
		public int height { get; set; }
		

		public abstract void DoWork();


		public static void Main(string[] args)
		{
            var s = new student();
            s.DoWork();


            var i = new instructor();
            i.DoWork();
        }
	}

	 class student : person1
    {
		public override void DoWork()
        {
            Console.WriteLine("Student : Just study");
        }
	}

	 class instructor : person1
	{
		public override void DoWork()
		{
			Console.WriteLine("Instructor : Teach students");
		}
	}
}

