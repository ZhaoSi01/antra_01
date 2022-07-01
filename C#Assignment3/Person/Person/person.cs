using System;
namespace Person
{
	abstract class person1
	{
		public int height { get; set; }
		//int id;

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

