using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thry2
{
    class Student
    {
        //private
        string name;
        string id;
        float cgpa;
        const int NO_OF_CREDIT = 10;
        readonly int NO_OF_COURSE;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Student()
        {
            name = "default";
            id = "XXXXX";
            cgpa = 2.4f;
            NO_OF_COURSE = 3;

        }
        public Student(string name, string id, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
            NO_OF_COURSE = 3;
        }
        public void ShowInfo()
        {

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Cgpa: " + cgpa);
        }

        static void Main(string[] args)
        {
            Student s1 = new Student("Tanvir", "111111", 2.4f);
            s1.ShowInfo();
        }
    }
}