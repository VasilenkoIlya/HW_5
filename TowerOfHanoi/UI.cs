using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    class UI
    {
        public static void TrivialOccasion(int colFrom, int colTo)
        {
            Console.WriteLine("Move disk 1 from column {0} to column {1}", colFrom, colTo);
        }

        public static void MoveDisk(int high, int colFrom, int colTo)
        {
            Console.WriteLine("Move disk {0} from column {1} to column {2}", high, colFrom, colTo);
        }
    }
}
