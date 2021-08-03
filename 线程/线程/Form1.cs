using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 线程
{
    public partial class Form1 : Form
    {

        /**
         * 每一个进程都是由多个线程组成
         * 
         * 单线程带来的问题
         *      创建一个窗口就是系统分配了一个线程
         *      所以,
         *      Test()不完成, 窗口不能拖动
         *      
         *      解决:
         *      创建一个线程去执行这个方法
         *      
         * 线程分为两种: 
         * 前台线程 
         *  只有所有的前台线程都关闭才能完成程序关闭.
         * 
         * 后台线程
         *  只有所有的前台线程结束, 后台县城自动结束.
         * 
         * 多线程编程有一个坑爹的地方
         *  时而异常, 时而不抛异常
         *  解决办法: 退出时候关闭线程
         * 
         */
        Thread th;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Test();

            //创建一个线程去执行这个方法
            //Thread th = new Thread(Test);
            th = new Thread(Test);

            //将线程设置为后台线程
            th.IsBackground = true;

            //标记这个线程准备就绪了, 可以随时被执行. 具体什么时候执行这个线程由cpu决定

            /**
             * 计算机组成原理:
             * 线程什么时候执行, 由cpu决定, 而不是由我们决定, 
             * 我们最多只能告诉cpu, 这个线程已经准备完毕, 您可以去执行它了
             * 所以
             * 这样就不是实时了, 什么时候执行还不可控
             */
            th.Start();
            //报错: 线程被Abort就不能再Start
            //th.Abort();
            //th.Start();
        }

        private void Test()
        {
            for (int i = 0; i < 10000; i++)
            {
                //Console.WriteLine(i);

                //新线程去访问主线程资源
                //报错: 线程间操作无效.
                //原因: 在.Net下, 是不允许跨线程的访问
                //解决: 取消跨线程的访问
                textBox1.Text = i.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //取消跨线程的访问
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        /// <summary>
        /// Closing关闭前
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //当你点击关闭窗体的时候, 判断新线程是否为null
            if (this.th != null)
            {
                //结束这个线程
                th.Abort();
            }
        }
    }
}
