using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace FormApp1402
{
    class MyListItemSorter : IComparer
    {
        public bool asc = true;

        public MyListItemSorter(bool asc)
        {
            this.asc = asc;
        }
        
        public int Compare(object x, object y)
        {
            ListViewItem item1 = x as ListViewItem;
            ListViewItem item2 = (ListViewItem)y;

            //Tag : 每一项关联的数据
            MyListItemTag tag1 = (MyListItemTag)item1.Tag;
            MyListItemTag tag2 = (MyListItemTag)item2.Tag;

            //目录在前, 文件在后
            if (tag1.type != tag2.type)
                return CompareInt(true, tag1.type, tag2.type);

            //按名字比较
            return CompareStringIgnoreCase(asc, tag1.name, tag2.name);
        }

        //两个Bool值的比较
        private int CompareBool(bool asc, bool x, bool y)
        {
            int xx = x ? 1 : 0;
            int yy = y ? 1 : 0;
            return CompareInt(asc, xx, yy);
        }

        //两个Int值得比较
        public int CompareInt(bool asc, int x, int y)
        {
            if (asc)
            {
                return x - y;
            }
            else
            {
                return y - x;
            }
        }

        //两个string值得比较
        public int CompareString(bool asc, string x, string y)
        {
            if (asc)
            {
                return x.CompareTo(y);
            }
            else
            {
                return y.CompareTo(x);
            }
        }

        //两个String值得比较(不区分大小写)
        public int CompareStringIgnoreCase(bool asc, string x, string y)
        {
            return CompareString(asc, x.ToLower(), y.ToLower());
        }

        


    }
}
