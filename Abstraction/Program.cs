﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point_1 = new Point(1, 1);
            Point point_2 = new Point(5, 3);

            Rectangle rectangle = new Rectangle(-2, 3, 3, 1);

            Console.WriteLine(rectangle.Contains(point_1)); // Return true
            Console.WriteLine(rectangle.Contains(point_2)); // Return false

            Console.ReadLine();
        }
    }
}
