using System;
namespace ReverseArray
{
	public class ReverseArr
	{
		public static void Main(string[] args)


		{
           int[] arr = create();
           Console.WriteLine("Array Reverse");
		   Console.WriteLine("Array is ：");
            print(arr);
            //foreach (int i in arr)
            //{
            //    Console.Write("{0} ", i);
            //}
            Console.WriteLine(" ");
            Console.WriteLine("New Array is ：");
            arr = reverse(arr);
            print(arr);






        }
        static int[] create()
        {
            int[] arr1 = new int[10];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = new Random().Next(10) + 1;
            }

            return arr1;
        }
        static int[] reverse(int[] arr1)
        {
            int length = arr1.Length;

            for (int i = 0; i < (arr1.Length) / 2; i++)
            {
                int tmp = arr1[i];
                arr1[i] = arr1[length - i - 1];
                arr1[length - i - 1] = tmp;
            }

            return arr1;
        }

        static void print(int[] arr1)
        {
            int length = arr1.Length;

            foreach (int i in arr1)
            {
                Console.Write("{0} ", i);
            }


        }


    }
}

