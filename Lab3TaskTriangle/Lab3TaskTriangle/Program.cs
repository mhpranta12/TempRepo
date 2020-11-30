using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3TaskTriangle
{
    class Triangle
    {

        private int x;
        private int y;
        private int z;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        public void ShowInfo()
        {
            if (x==y && y==z && z==x)
            {
                Console.WriteLine(" The triangle  is equilateral");
            }
            else if (x == y || y == z || z == x)
            {
                Console.WriteLine(" The triangle  is isosceles");
            }
            else if (x != y &&  y != z && z != x)
            {
                Console.WriteLine(" The triangle  is scalene");
            }

        }
        public Triangle(int x, int y,int z)
        {
            this.x =x;
            this.y = y;
            this.z = z;
           
        }

        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(3,3,3);
            t1.ShowInfo();
            Triangle t2 = new Triangle(3, 3, 2);
            t2.ShowInfo();
            Triangle t3 = new Triangle(3, 2, 1);
            t3.ShowInfo();
        }
    }
}
