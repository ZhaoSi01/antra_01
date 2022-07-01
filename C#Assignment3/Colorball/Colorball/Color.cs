using System;
namespace Colorball
{
	public class Color
	{
		byte red { get; set; }
		byte blue { get; set; }
		byte green { get; set; }
		byte alpha { get; set; }
		byte scale { get; set; }

		
		public byte ColorGet(byte Red, byte Blue, byte Green, byte Alpha)
		{
			red = Red;
			blue = Blue;
			green = Green;
			alpha = Alpha;
            Console.WriteLine("Color is {0}", (byte)((red + Blue + green) / 3));
			return (byte)((red + Blue + green )/ 3);
		}
	}
}

