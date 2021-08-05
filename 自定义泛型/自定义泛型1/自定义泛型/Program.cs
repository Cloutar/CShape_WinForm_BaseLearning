using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自定义泛型
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<string> mc = new MyClass<string>();
            mc.SayHi("你们好吗? 狗子");

            MyClass2<string, int, double> mc2 = new MyClass2<string, int, double>();
            mc2.SayHi("你们好吗? 狗子");

            Console.ReadKey();

        }
    }


    /**
     * 泛型类
     */

    // T 可以是A\b\cc..... 只要是合法的变量名就行
    public class MyClass<T>
    {
        public void SayHi(T arg)
        {
            Console.WriteLine(arg);
        }
    }

    public class MyClass2<T, X, ZZ>
    {
        public void SayHi(T arg)
        {
            Console.WriteLine(arg);
        }
    }


    /**
     * 泛型方法
     */

    public class Class1
    {
        public void SayHello<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }

    /**
     * 泛型接口
     */
    public interface IFace<T>
    {
        T SayHi();
        void SayHello(T msg);
    }

    //实现泛型接口的时候有两种情况:
    //1. 普通类来实现泛型接口
    public class Class2 : IFace<string>
    {

        public string SayHi()
        {
            throw new NotImplementedException();
        }

        public void SayHello(string msg)
        {
            throw new NotImplementedException();
        }
    }

    //2.泛型类, 实现泛型接口
    public class Class3<U> : IFace<U>
    {

        public U SayHi()
        {
            throw new NotImplementedException();
        }

        public void SayHello(U msg)
        {
            throw new NotImplementedException();
        }
    }
}
