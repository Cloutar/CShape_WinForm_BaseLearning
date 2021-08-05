using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 下
{
    class Program
    {
        static void Main(string[] args)
        {
            #region stack 后进先出
            Stack nameStack = new Stack();
            nameStack.Push("liu");
            nameStack.Push("piao");
            nameStack.Push("da");
            nameStack.Push("nao");
            foreach (string item in nameStack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(nameStack.Pop());
            foreach (string item in nameStack)
            {
                Console.WriteLine(item);
            }
            nameStack.Push("gao");
            foreach (string item in nameStack)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region queue 先进先出
            Queue nameQ = new Queue();
            nameQ.Enqueue("Liu");
            nameQ.Enqueue("Xiao");
            nameQ.Enqueue("Yu");
            nameQ.Enqueue("Gao");
            nameQ.Enqueue("mei");
            nameQ.Enqueue("Nan");
            foreach (var item in nameQ)
            {
                Console.WriteLine("item: {0}", item);
            }
            nameQ.Dequeue();
            nameQ.Dequeue();
            foreach (var item in nameQ)
            {
                Console.WriteLine("item: {0}", item);
            }
            #endregion

            #region BitArray
            BitArray ba1 = new BitArray(8);
            BitArray ba2 = new BitArray(8);
            byte[] a = { 60 };
            byte[] b = { 13 };
            //把值60和13存储到点阵列中
            ba1 = new BitArray(a);
            ba2 = new BitArray(b);
            //ba1的内容
            Console.WriteLine("Bit array ba1: 60");
            for (int i = 0; i < ba1.Count; i++)
            {
                Console.Write("{0, -6}", ba1[i]);
            }
            Console.WriteLine();
            //ba2的内容
            Console.WriteLine("Bit array ba2: 13");
            for (int i = 0; i < ba2.Count; i++)
            {
                Console.Write("{0, -6}", ba2[i]);
            }
            Console.WriteLine();

            BitArray ba3 = new BitArray(8);
            ba3 = ba1.And(ba2);
            //ba3的内容
            Console.WriteLine("Bit array ba3 after AND operation: 12");
            for (int i = 0; i < ba3.Count; i++)
            {
                Console.Write("{0, -6}", ba3[i]);
            }
            Console.WriteLine();

            ba3 = ba1.Or(ba2);
            //ba3的内容
            Console.WriteLine("Bit array ba3 after OR operation: 61");
            for (int i = 0; i < ba3.Count; i++)
            {
                Console.Write("{0, -6}", ba3[i]);
            }
            Console.WriteLine();
            #endregion

            Console.ReadKey();
        }
    }
}
