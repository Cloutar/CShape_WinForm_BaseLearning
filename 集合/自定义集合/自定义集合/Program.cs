using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自定义集合
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList myList = new MyList(5);
            //MyList myList = new MyList(5);
            Console.WriteLine("capacity: " + myList.Capacity);
            myList.Add(10);
            myList.Add(10);
            myList.Add(10);
            myList.Add(101);
            myList.Add(10);
            myList.Add(10);
            Console.WriteLine("capacity: " + myList.Capacity);
            int myListCount = myList.Count;
            for (int i = 0; i < myListCount; i++)
            {
                Console.WriteLine(myList[i]);
            }
            Console.WriteLine("Contains: " + myList.Contains(101));

            Console.ReadKey();
        }
    }
}
