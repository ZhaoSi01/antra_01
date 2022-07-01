using System;

namespace Colorball
{
	public class Ball : Color
	{
        public static void Main(string[] args)
        {
			var b1 = new Ball();
			b1.ColorGet(0, 12, 0, 0);
			b1.r = 3;
			b1.thr();
			b1.showR();

			var b2 = new Ball();
			b2.ColorGet(10, 12, 10, 0);
			b2.r = 3;
			b2.thr();
			b2.showR();


		}
		//unsigned_char color;
		//0 - 255
		//byte color;
		////byte color { get; set; }
		//public byte colorSet(byte i)
		//      {
		//          Console.WriteLine(	"Color is : {0}", i);
		//	return i;
		//      }
		//public byte graySet(byte j)
		//{
		//	Console.WriteLine("Grey Scale is : {0}", j);
		//	return j;
		//}
		//byte color { get; set; }

		int r { set; get; }

		public void pop()
		{
			r = 0;
            Console.WriteLine("Pop successfully");
		}

		public void thr(){
			if(r != 0)
            {
				r++;
				Console.WriteLine("Throw successfully");
			}
		}

		public int showR()
		{
			Console.WriteLine("radius is : {0} cm", r);
			return r;
		}





	}
	
}

