using System;
using System.Collections.Generic;
namespace MyStack
{
    
    public class MyStack<T>
    {
        int capacity;
        int top = 0;
        //public int top { get; set; }
        T[] stack;
        //The index of the first element in stack
        //When push one element, top++;

        public MyStack(int cap)
        {
            capacity = cap;
            stack = new T[capacity];
        }

        public void push(T Element)
        {
            //Check Overflow
            if (top == capacity - 1)
            {
                Console.WriteLine("Fullfilled, Please create a new stack");
            }
            else
            {
                top = top ++;
                stack[top] = Element;
                Console.WriteLine("Successfully");
            }
            
        }

        public int Count()
        {
            return top;
        }

        public T pop()
        {
            T RemovedElement;
            //T temp = default(T);

            if (top > 0)
            {
                RemovedElement = stack[top];
                Console.WriteLine(  "Pop : {0}", RemovedElement);
                top = top - 1;
                return RemovedElement;
            }
            //Classes - null
            //Nullable < T > -null
            //Numerics structs(int, double, decimal, etc) -0
            //DateTime structs -01 / 01 / 0001.
            //Char structs    -empty char.
            //Bool structs -false
            return default(T);

        }
        //= new T[capacity];

        //Stack<T> myStack = new Stack<T>();
        //      public int Count(MyStack<T> myStack)
        //      {
        //          return myStack.Count;
        //      }

    }
}

    

