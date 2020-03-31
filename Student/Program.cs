using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
			Student student_1 = new Student("Pesho", 20, 5.5);
			Student student_2 = new Student("Mimi", 18, 4.5);

			ClassRoom myClass = new ClassRoom();
			myClass.Create(student_1);
			myClass.Create(student_2);

			myClass.Show("Mimi");
			myClass.Show("Pesho");
			myClass.Show("Peter");

			Console.ReadLine();
			Console.ReadKey();
		}
    }
}
