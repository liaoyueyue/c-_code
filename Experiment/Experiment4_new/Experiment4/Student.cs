using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment4
{
    class Student
    {
        

        private string id;
        private string name;
        private string sex;
        private string age;
        private string major;

        public Student(string id, string name, string sex, string age, string major)
        {
            this.id = id;
            this.name = name;
            this.sex = sex;
            this.age = age;
            this.major = major;
        }

        public string toString()
        {
            return string.Format("学生信息显示\n编号:{0}\n姓名:{1}\n性别:{2}\n年龄:{3}\n专业:{4}", id, name, sex, age, major);
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        

        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        

        public string Major
        {
            get { return major; }
            set { major = value; }
        }
    }
}
