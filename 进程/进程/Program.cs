using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 进程
{
    class Program
    {
        static void Main(string[] args)
        {
            //alt + shift + f10 自动引入命名空间

            //获得当前程序中所有正在运行的进程
            //Process[] pros = Process.GetProcesses();
            //foreach (var item in pros)
            //{
            //    //item.Kill();
            //    Console.WriteLine(item);
            //}

            //通过进程打开一些应用程序
            //Process.Start("calc");
            //Process.Start("mspaint");
            //Process.Start("notepad");
            //Process.Start("iexplore", "http://www.baidu.com");

            //通过一个进程打开指定的文件
            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\fcrit\Desktop\test.txt");
            //第一: 创建进程对象
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();

            Console.ReadKey();
        }
    }
}
