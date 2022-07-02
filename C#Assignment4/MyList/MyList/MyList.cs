using System;
using System.Collections.Generic;
using System.Collections;　

namespace MyList
{
	public class MyList<T>
	{

		List<T> list;
		public List<T> Mylist(){
			list = new List<T>();
			return list;
		}
		

		public static void Add(T element, List<T> list)
		{
            list.Add(element);
            Console.WriteLine("Add {0} Successfully", element);
		}

		public T Remove(int index)
		{
			T tmp = list[index]; ;
			list.RemoveAt(index);
			return tmp;
		}

		public bool Contains(T element)
        {
			return list.Contains(element);
        }

		public void Clear()
        {
			list.Clear();

        }

		public void InsertAt(T ele, int index)
		{
			list.Insert(index, ele);

		}

		public void DeleteAt(int index)
		{
			//return type is void not T
			//list.Remove(index);
			list.RemoveAt(index);
		}


		public T find(int index)
		{
			return list[index];
		}

		
	}
}

