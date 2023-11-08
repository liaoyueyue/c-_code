using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    // 学生抽象类
    public abstract class Student
    {
        private string name;
        private int age;
        public static int count;

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
            count++;
        }

        public abstract double GetAverage();

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                if (age <= 0)
                {
                    return 0;
                }
                else
                {
                    return age;
                }
            }
        }

    }

    // 小学生
    public class Pupil : Student
    {
        private double chinese;
        private double math;
        public double Chinese
        {
            get
            {
                return chinese;
            }
            set
            {
                chinese = value;
            }
        }

        public double Math
        {
            get
            {
                return math;
            }
            set
            {
                math = value;
            }
        }

        public Pupil(string name, int age, double chinese, double math):base(name, age)
        {
            this.chinese = chinese;
            this.math = math;
        }

        public override double GetAverage()
        {
            return (chinese + math) / 2;
        }
    }

    // 中学生
    public class MiddleStu : Student
    {
        private double chinese;
        private double math;
        private double english;
        public double Chinese
        {
            get
            {
                return chinese;
            }
            set
            {
                chinese = value;
            }
        }

        public double Math
        {
            get
            {
                return math;
            }
            set
            {
                math = value;
            }
        }
        public double English
        {
            get
            {
                return english;
            }
            set
            {
                english = value;
            }
        }

        public MiddleStu(string name, int age, double chinese, double math, double english)
            :base(name, age)
        {
            this.chinese = chinese;
            this.math = math;
            this.english = english;
        }

        public override double GetAverage()
        {
            return (chinese + math + english) / 3;
        }
    }

    public class CollegeStu : Student
    {
        private double requiredCourse;
        private double electiveCourse;
        public double RequiredCourse
        {
            get
            {
                return requiredCourse;
            }
            set
            {
                requiredCourse = value;
            }
        }

        public double ElectiveCourse
        {
            get
            {
                return electiveCourse;
            }
            set
            {
                electiveCourse = value;
            }
        }

        public CollegeStu(string name, int age, double requiredCourse, double electiveCourse)
            :base(name, age)
        {
            this.requiredCourse = requiredCourse;
            this.electiveCourse = electiveCourse;
        }

        public override double GetAverage()
        {
            return (requiredCourse + electiveCourse) / 2;
        }
    }
}
