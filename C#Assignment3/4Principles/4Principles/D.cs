using System;
namespace _4Principles
{
    //public abstract class D
    //{
    //	public abstract void work();
    //}
    
    public class D
    {
        public static void Main(string[] args)
        {
            D d = new D();
            d.DoWork(1);
        }
        public virtual void DoWork(int i)
        {//The data and variable in a unit
            i = 1;
            int j = 2;
            Console.WriteLine("Encapsulation  " + i + " "+ j);
        }
    }
    //E : D Inheritance
    public abstract class E : D
    {   //Abstraction
        public abstract override void DoWork(int i);
    }

    public class F : E
    {
        public override void DoWork(int i)
        {
            Console.WriteLine(" Override in Ploymorohism");
        }
    }

}




