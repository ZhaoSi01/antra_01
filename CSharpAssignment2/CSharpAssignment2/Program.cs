// See https://aka.ms/new-console-template for more information
Console.WriteLine("C# Assignment 2");

//1.String VS String Builder
//•	•	While working with the String class, every time you perform some operations on your string, you recreate the entire string in the memory over and over again, whereas StringBuilder allocates some buffer space in the memory and applies modifications into that buffer space.
//•	•	As the StringBuilder object is mutable可变的, it provides better performance as compared to the String object when heavy string manipulations are involved.
//•	•	String operations use more memory as compared to StringBuilder because String creates intermediate garbage instances after each operation.
//•	•	String is in System namespace but StringBuilder is in System.Text namespace

//2. What is the base class for all arrays in C#?
//		Array Class
//3. How do you sort an array in C#?
//	Use Array.Sort(arr) method
//4. What property of an array object can be used to get the total number of elements in an array?  -- Length Property
//5. Can you store multiple data types in System.Array?
//No, we cannot store multiple datatype in an Array
//6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
//Clone() method makes a clone of the original array.It returns an exact length array.On the other hand, CopyTo() copies the elements from the original array to the destination array starting at the specified destination array index.Note that, this adds elements to an already existing array.


//Copy array
int[] array1 = new int[] { 1, 2,3,4, 5,6, 7,8, 9,10 };
int[] array2 = (int[])array1.Clone();
Console.WriteLine(array2[0]);


