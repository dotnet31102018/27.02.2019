using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2702
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Point a = new Point(8, 10);
            Point b = new Point(8, 10);

            if (a == b)
            {
                Console.WriteLine("The same!");
            }
            else
            {
                Console.WriteLine("Not the same!");
            }*/

            Person p1 = new Person("Moshe", "Perez", 37, 1);
            Person p2 = new Person("Moshe", "Perez", 37, 1);

            if (p1.GetHashCode() == p2.GetHashCode())
            {
                Console.WriteLine("Same person!");
            }
        }


    }

}
