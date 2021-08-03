using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4
{
    //定义委托类型
    public delegate void GreetingDelegate(string name);

    class MainClass
    {
        public void Greeting(string name, GreetingDelegate del)
        {
            del(name);
        }

        public void EnglishGreeting(string name)
        {
            Console.WriteLine("hello" + name);
        }

        public void ChineseGreeting(string name)
        {
            Console.WriteLine("你好" + name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MainClass p = new MainClass();
            //完整写法
            GreetingDelegate del = new GreetingDelegate(p.ChineseGreeting);
            //简单写法, 实现功能与完整写法一样
            GreetingDelegate dell = p.ChineseGreeting;
            del("Test");
            del("Test2");
            dell("Test3");
            dell("Test4");
            p.Greeting("李四", p.ChineseGreeting);
            p.Greeting("Mike", p.EnglishGreeting);

            Console.ReadKey();
        }
    }
}
