using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    public class Brigeroom
    {
        //1. 定义委托
        public delegate void MarryHandler(string msg);
        //2. 定义事件: 为什么事件里面包装委托, 因为事件得统一调用的方法
        public event MarryHandler marryEvent;

        public void OnMarrayComing(string msg)
        {
            //3. 触发事件
            if (marryEvent != null)
            {
                marryEvent(msg);
            }
        }
    }

    class Friend
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Friend(string name)
        {
            this.name = name;
        }

        public void ReceiveMsg(string msg)
        {
            Console.WriteLine("{0}收到信息{1}, 会准时参加", this.name, msg);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Brigeroom room = new Brigeroom();
            Friend f1 = new Friend("张三");
            Friend f2 = new Friend("李四");
            Friend f3 = new Friend("王五");
            room.marryEvent += f1.ReceiveMsg;
            room.marryEvent += f2.ReceiveMsg;
            room.marryEvent += f3.ReceiveMsg;

            room.OnMarrayComing("同学们, 我要结婚了.");

            Console.ReadKey();
        }
    }
}
