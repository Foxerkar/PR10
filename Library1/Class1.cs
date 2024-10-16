using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class Class1
    {
        public static (double Area, double Perimeter) Square(double Side)
        {
            double area = Side * Side;
            double perimeter = 4 * Side;
            return (area, perimeter);
        }


        public static (double Area, double Circus) Circle (double radius)
        {
            double area = Math.PI * radius * radius;
            double circus = 2 * Math.PI * radius;
            return (area, circus);
        }

    }
}
