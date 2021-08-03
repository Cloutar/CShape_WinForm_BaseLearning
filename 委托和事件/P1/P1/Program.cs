using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
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

        public void ReceiveMsg(string msg)
        {
            Console.WriteLine("收到信息, 会准时参加: " + msg);
        }
    }

    class Program
    {
        //事件定义
        public event EventHandler birthday;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }

    }
}
