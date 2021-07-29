using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp0705
{
    class Student
    {
        private string name;
        private string code;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public Student() { }

        public Student(string code, string name)
        {
            this.code = code;
            this.name = name;
        }

        public override string ToString()
        {
            return string.Format("({0}) {1}", this.code, this.name);
        }
    }
}
