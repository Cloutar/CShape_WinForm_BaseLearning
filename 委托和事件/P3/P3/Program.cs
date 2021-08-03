using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    //1. 声明委托
    public delegate void MyMethod(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            //2.声明委托变量
            MyMethod my_del;

            //3.初始化
            my_del = new MyMethod(new Program().Add);   //实例方法
            my_del = new MyMethod(Program.Add1);   //静态方法

            my_del(10, 30);
            Console.ReadKey();
        }

        public void Add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("sum = " + sum);
        }

        public static void Add1(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("sum1 = " + sum);
        }
    }
}
