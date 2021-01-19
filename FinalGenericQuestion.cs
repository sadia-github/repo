using System;

namespace FinalGenericQuestion
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;


    public class Program
    {
        public static void Main()
        {

            var myCollection = new MyClass<int>();

            myCollection.Add(1);
            myCollection.Add(2);
            myCollection.Add(3);
            myCollection.Sort();

            myCollection.Remove(1);
            myCollection.Remove(2);
            myCollection.Remove(3);
        }
    }


    public class MyClass<T> where T : struct
    {
        private List<T> MyList = new List<T>();

        public void Add(T MyElement)
        {
            lock (this)
            {
                MyList.Add(MyElement);
            }
        }

        public void Remove(T MyElement)
        {
            lock (this)
            {
                MyList.Remove(MyElement);
            }
        }

        public void Sort()
        {

            MyList.Reverse();
            Console.WriteLine("List in sorted order: ");
            foreach (T MyElement in MyList)
                Console.Write("   {0}", MyElement);

        }
    }

}
