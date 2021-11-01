using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Calculation
    {
        public static void Calc()
        {
            for (int i = 1; i <= TransformStoM.M; i++)
            {
                Init.c1 = Init.c1 * i;
                Init.c2 = Init.c2 + i;
                if (i % 2 == 0)
                {
                    Init.c3 = i;
                }
            }
        }
    }
}
