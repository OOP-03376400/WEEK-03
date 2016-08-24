using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_public_Modifier
{
    class PointTest
    {
        public int x;
        public int y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            PointTest p = new PointTest();
            p.x = 10;
            p.y = 15;
            Console.WriteLine("x = {0}, y = {1}", p.x, p.y);
        }
    }
}
