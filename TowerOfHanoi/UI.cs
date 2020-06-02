using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    class UI
    {
        public static void MoveDisk(int high, int colFrom, int colTo)
        {
            Console.WriteLine($"Move disk {high} from column {colFrom} to column {colTo}");
        }
    }
}
