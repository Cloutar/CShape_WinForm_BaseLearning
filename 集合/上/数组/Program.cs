using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 数组 Array
            int[] names = {1, 3, 5, 7, 8};
            //三种初始化方式
            names = new int[9];
            names = new int[3]{1, 5, 9};
            //排序
            Array.Sort(names);
            //增删改查
            //如果要增加一个数组
            //创建一个新的数组 新的数组要比之前的数组多一个 然后复制旧的信息到新数组里面
            //麻烦: Array在初始化的时候限定了长度
            names[2] = 50;
            //遍历
            int tempW = 0, nameLen = names.Length;
            while (tempW < nameLen)
            {
                Console.WriteLine("while value: " + names[tempW]);
                tempW++;
            }
            for (int i = 0; i < nameLen; i++)
            {
                Console.WriteLine("for:{0}", names[i]);
            }
            foreach (var item in names)
            {
                Console.WriteLine("Foreach: " + item);
            }
            #endregion

            //之后所有的集合都是基于Array完成的

            #region List
            List<int> nameList = new List<int>();
            //增加
            nameList.Add(15);
            nameList.Add(115);
            nameList.Add(175);
            nameList.Add(1785);
            nameList.Add(157);
            //遍历
            int nameListLen = nameList.Count;
            for (int i = 0; i < nameListLen; i++)
            {
                Console.WriteLine("NameList item value: " + nameList[i]);
            }
            //删除
            //直接移除对象
            Console.WriteLine(nameList.Remove(15));
            Console.WriteLine(nameList.Remove(145645));
            //通过索引来做移除
            nameList.RemoveAt(1);
            foreach (int item in nameList)
            {
                Console.WriteLine("Foreach NameList value: " + item);
            }
            #endregion

            #region ArrayList
            ArrayList nameArrayList = new ArrayList();
            nameArrayList.Add("GaoJinjin");
            nameArrayList.Add(16);
            nameArrayList.Add(123456789.45f);
            //遍历
            int nameArrayListLen = nameArrayList.Count;
            for (int i = 0; i < nameArrayListLen; i++)
            {
                Console.WriteLine(nameArrayList[i]);
            }
            //delete
            nameArrayList.Remove(16);
            foreach (var item in nameArrayList)
            {
                Console.WriteLine("Foreach: " + item);
            }
            //查找
            Console.WriteLine(nameArrayList.Contains(16));
            #endregion

            #region Hashtable
            Hashtable nameHash = new Hashtable();
            //键值对中 键是不可以重复的 但是值是可以重复的 身份证号-姓名
            nameHash.Add("Name_", "LiuPIaopiao");
            nameHash.Add("Name", "LiuPIaopiao");
            nameHash.Add("Age", 18);
            nameHash.Add("Money", 12345678f);
            //遍历
            foreach (var item in nameHash.Keys)
            {
                //.netframework4.7才支持$
                //Console.WriteLine($"Hashtable key is {item}, value is {nameHash[item]}");
                Console.WriteLine("Hashtable key is {0}, value is {1}", item, nameHash[item]);
            }
            //删除
            nameHash.Remove("Name_");
            //其他遍历
            foreach (var item in nameHash.Values)
            {
                Console.WriteLine("item is value: {0}", item);
            }
            foreach (DictionaryEntry item in nameHash)
            {
                Console.WriteLine("key is {0}, value is {1}", item.Key, item.Value);
            }
            IDictionaryEnumerator tempID = nameHash.GetEnumerator();
            while (tempID.MoveNext())
            {
                Console.WriteLine(tempID.Value + "------" + tempID.Key);
            }
            ICollection keys = nameHash.Keys;
            #endregion

            #region SortedList
            SortedList nameSort = new SortedList();
            nameSort.Add("001", "zara");
            nameSort.Add("002", "java");
            nameSort.Add("003", "html");
            nameSort.Add("004", "php");
            nameSort.Add("005", "golang");
            ICollection keysSort = nameSort.Keys;
            foreach (var item in keysSort)
            {
                Console.WriteLine("key {0}, vlaue {1}", item, nameSort[item]);
            }
            //删除
            nameSort.RemoveAt(4);
            //修改
            nameSort["002"] = "modification";
            foreach (DictionaryEntry item in nameSort)
            {
                Console.WriteLine("key {0}, vlaue {1}", item.Key, item.Value);
            }
            //判断是否包含 确定后再去修改
            if (nameSort.Contains("008"))
            {
                Console.WriteLine("替换");
                nameSort["008"] = "LiuPIaopiao";
            }
            else
            {
                nameSort.Add("008", "LiuPiaopiao");
            }
            //数据会自动排序?  文档中的索引 就是指 数据可以自动排序
            nameSort.Add("007", "LiuPiaopiao");
            ICollection key2 = nameSort.Keys;
            foreach (string item in key2)
            {
                Console.WriteLine("ICollection key6 {0}, value6 {1}", item, nameSort[item]);
            }
            #endregion

            #region Dictionary
            Dictionary<string, string> nameDic = new Dictionary<string,string>();
            nameDic.Add("Name", "LiuKeSHUI");
            nameDic.Add("Age", 18.ToString());
            nameDic.Add("XName", "XiaoCHeng");
            foreach (KeyValuePair<string, string> item in nameDic)
	        {
		        Console.WriteLine("nameDic key {0}, value {1}", item.Key, item.Value);
	        }
            //删除
            nameDic.Remove("XName");
            Dictionary<string, string>.KeyCollection dicKey = nameDic.Keys;
            foreach (string item in dicKey)
            {
                Console.WriteLine("key {0} value {1}", item, nameDic[item]);
            }
            Dictionary<string, string>.ValueCollection dicValues = nameDic.Values;
            foreach (var item in dicValues)
            {
                Console.WriteLine(item);
            }
            #endregion

            Console.ReadKey();
        }
    }
}
