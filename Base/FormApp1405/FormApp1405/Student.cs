using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp1405
{
    class Student
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public Student()
        {
            //
        }

        public Student(int code, string name, string phone)
        {
            this.Code = code;
            this.Name = name;
            this.Phone = phone;
        }
    }
}
