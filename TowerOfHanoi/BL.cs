using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    class BL
    {
        public static void MoveTower(int high, int colFrom, int colTo)
        {
            if (high == 1)//Тривиальный случай
            {
                UI.TrivialOccasion(colFrom, colTo);
            }
            else
            {
                int tmp = 6 - colFrom - colTo;//вычисление номера временного столбца
                MoveTower(high - 1, colFrom, tmp);//перекладываем диск с начального столбца на временный
                UI.MoveDisk(high, colFrom, colTo);
                MoveTower(high - 1, tmp, colTo);//перекладываем диск с временного столбца на конечный
            }
        }
    }
}
