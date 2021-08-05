using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自定义集合
{
    class MyList
    {

        private int[] tempInts;   //数组
        private int capacity = 0;   //容量
        private int count = 0;   //记录个数

        public int Capacity {
            get
            {
                return this.capacity;
            }
            set
            {
                this.capacity = value;
            }
        }
        public int Count
        {
            get
            {
                return this.count;
            }
        }

        //索引器
        public int this[int index]
        {
            set
            {
                if (index >= count || index < 0)
                {
                    Console.WriteLine("溢出");
                }
                else
                {
                    this.tempInts[index] = value;
                }
            }
            get
            {
                if (index >= count || index < 0)
                {
                    Console.WriteLine("溢出");
                    return -9527;
                }
                else
                {
                    return this.tempInts[index];
                }
            }
        }

        //构造方法
        public MyList(int capacity)
        {
            this.Capacity = capacity;
            this.tempInts = new int[Capacity];
        }
        public MyList()
        {
            //
        }

        //添加元素
        public void Add(int ti)
        {
            this.count++;
            //判断当前count是否超过了容量
            if (this.count > this.capacity)
            {
                this.UpdataCapacity();
            }

            this.tempInts[count - 1] = ti;
        }

        //删除
        public bool Remove(int value)
        {
            bool isRemove = false;
            int removeIndex = this.ContainsReturnIndex(value);
            if (removeIndex != -1)
            {
                //在移除了找到的元素后要把后面的内容前置
                for (int i = removeIndex; i < this.count; i++)
                {
                    this.tempInts[i] = this.tempInts[i + 1];
                }
                this.count--;
                isRemove = true;
            }
            return isRemove;
        }
        //基于索引移除
        public bool RemoveAt(int index)
        {
            bool isRemove = false;
            if (index >= 0 && index < count)
            {
                for (int i = index; i < this.count - 1; i++)
                {
                    this.tempInts[i] = this.tempInts[i + 1];
                }
                isRemove = true;
            }
            

            return isRemove;
        }

        //是否包含
        public bool Contains(int value)
        {
            bool isContains = false;
            for (int i = 0; i < this.count; i++)
            {
                if (value == this.tempInts[i])
                {
                    isContains = true;
                    break;
                }
            }

            return isContains;
        }

        #region 私有方法
        //是否包含  返回索引
        private int ContainsReturnIndex(int value)
        {
            int keyContains = -1;
            for (int i = 0; i < this.count; i++)
            {
                if (value == this.tempInts[i])
                {
                    keyContains = i;
                    break;
                }
            }

            return keyContains;
        }

        //扩容
        private void UpdataCapacity()
        {
            Console.WriteLine("我要进行扩容");
            //扩容
            if (capacity == 0)
            {
                this.capacity = 2;
                this.tempInts = new int[Capacity];
            }
            capacity = capacity * 2;
            //对数组进行操作
            int[] tempIntsNew = new int[capacity];
            //拷贝旧的内容到新的数组里面
            int tempIntsLen = this.tempInts.Length;
            for (int i = 0; i < tempIntsLen; i++)
            {
                tempIntsNew[i] = this.tempInts[i];
            }
            this.tempInts = tempIntsNew;
            Console.WriteLine("拷贝旧的内容到新的内容");
        }
        #endregion

        //排序
        public void Sort()
        {
            Array.Sort(this.tempInts);
        }

        //清除
        public void Clear()
        {
            this.count = 0;
            this.tempInts = null;
        }

        //转化成数组
        public int[] ToArray()
        {
            return tempInts;
        }

        //插入
        public void Insert(int value, int index)
        {
            this.count++;
            if (this.count > this.capacity)
            {
                this.UpdataCapacity();
            }
            //在某一个位置插入一个数字 插入完成后当前位置中的元素要向后移动
            if (index >= 0 && index < count)
            {
                for (int i = count; i >= index; i--)
                {
                    this.tempInts[i + 1] = this.tempInts[i]; 
                }
                //插入当前元素
                tempInts[index] = value;
            }
        }



    }
}
