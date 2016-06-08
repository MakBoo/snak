using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snak
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 p1 = new Class1();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            p1.Draw();

            Class1 p2 = new Class1();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';
            p2.Draw();

            Console.ReadLine();
        }
    }
}
