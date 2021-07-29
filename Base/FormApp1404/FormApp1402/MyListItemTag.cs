using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp1402
{
    public class MyListItemTag
    {
        public int type = 0;   //0, 目录; 1, 文件
        public string path;
        public string name;
        public DateTime time;
        public long size = -1;
        public string ext;
    }
}
