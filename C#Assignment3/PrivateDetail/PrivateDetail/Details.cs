using System;
namespace PrivateDetail
{
	 class Details
	{
		private int id { get; set; }
		private int height { get; set; }
		private String name { get; set; }
        //Console.WriteLine("Id: {0} + Height: {1} + Name: {2}", D, int height, String name);


        public static void Main(string[] args)
        {
			var v = new Details();
			v.id = 1;
            Console.WriteLine("ID: "+ v.id);
			v.height = 189;
			v.name = "Y";
			Console.WriteLine("Height: " + v.height);
			Console.WriteLine("Name: " + v.name);

		}
	}
}



