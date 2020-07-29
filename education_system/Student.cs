using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace education_system
{
    public class Student
    {
        //学生类

        //姓名
        public string Name
        {
            set;
            get;
        }

        //年龄
        public int Age
        {
            set;
            get;
        }

        //性别
        public string Gender
        {
            set;
            get;
        }

        //学号
        public string ID
        {
            set;
            get;
        }

        //专业班级
        public string Class
        {
            set;
            get;
        }

        //缺省构造函数
        public Student()
        {
 
        }

        /// <summary>
        /// 创建学生对象
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="ID"></param>
        public Student(string name, int age, string gender, string ID, string clas)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.ID = ID;
            this.Class = clas;
        }

    }
}
