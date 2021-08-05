using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自定义泛型2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc[0] = "第一";
            mc[1] = "第二";

            Console.WriteLine(mc[0]);
            Console.WriteLine(mc[1]);


            MyClass2<string> mc2 = new MyClass2<string>();
            mc2[0] = "第一";
            mc2[1] = "第二";

            Console.WriteLine(mc2[0]);
            Console.WriteLine(mc2[1]);


            MyClass2<int> mc3 = new MyClass2<int>();
            mc3[0] = 1;
            mc3[1] = 2;

            Console.WriteLine(mc3[0]);
            Console.WriteLine(mc3[1]);

            Console.ReadKey();
        }
    }



    /**
     * 泛型的意义:
     * 使用泛型可以是"算法"重用. 只是数据类型发生了改变.
     */


    public class MyClass
    {
        private string[] _data = new string[5];

        public string this[int index]
        {
            get
            {
                return _data[index];
            }
            set
            {
                _data[index] = value;
            }
        }
    }

    public class MyClass2<T>
    {
        private T[] _data = new T[5];

        public T this[int index]
        {
            get
            {
                return _data[index];
            }
            set
            {
                _data[index] = value;
            }
        }
    }


    /**
     * 限制类型
     * struct -- 限制只能是值类型
     * class -- 限制只能是引用类型
     * 例子IComparable -- 限制必须是实现了IComparable接口的类型
     * 例子K -- 限制必须是K类型或者是K类型的子类
     * 例子class, new() -- 限制必须是应用类型, 并且具有一个无参构造函数
     * 
     */
    public class MyClass3<T, K, V, W, X, Y, Z> 
        where T : struct
        where K : class
        where V : IComparable
        where W : K 
        where X : class, new()   //当有多个类型约束与new()一起使用时, new()约束必须写在后面
    {
        private T[] _data = new T[5];

        public T this[int index]
        {
            get
            {
                return _data[index];
            }
            set
            {
                _data[index] = value;
            }
        }
    }

    /**
     * todo 泛型委托~
     */
}
