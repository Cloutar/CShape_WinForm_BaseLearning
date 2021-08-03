using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace P5
{
    class Program
    {

    class MainClass
    {
        public delegate void DelegateTest();   //定义委托类型

        private static void StaticMethod()
        {
            Console.WriteLine("这是静态方法");
        }
        private void InstanceMethod()
        {
            Console.WriteLine("这是实例方法");
        }


        public static void Main(string[] args)
        {
            MainClass mc = new MainClass();

            DelegateTest d1 = new DelegateTest(MainClass.StaticMethod);
            DelegateTest d2 = new DelegateTest(mc.InstanceMethod);

            //委托链
            DelegateTest deleChain = null;

            //添加委托: '+'
            deleChain += d1;
            deleChain += d2;

            deleChain();
            Console.ReadKey();
        }
    }
    }
}
