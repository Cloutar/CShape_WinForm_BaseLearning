using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp1501
{
    class Student
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public bool Sex { get; set; }
        public string Phone { get; set; }

        public Student() { }

        public Student(int code, string name, bool sex, string phone)
        {
            this.Code = code;
            this.Name = name;
            this.Sex = sex;
            this.Phone = phone;
        }
    }
}
