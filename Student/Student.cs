using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        public string studentName ;
        public int studentAge;
        public double studentGrage;

        public Student(string name,int age,double grage)
        {
            studentName = name;
            studentAge = age;
            studentGrage = grage;
        }
        public void Show()
        {
            string gradeStatus = studentGrage > 5.00 ? "Excellent Student" : "Average Student";
            Console.WriteLine(studentName+"is"+studentAge+"year old."+gradeStatus);
        }
    }
}
