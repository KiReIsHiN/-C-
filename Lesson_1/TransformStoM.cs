using System;

namespace Lesson_1
{
    class TransformStoM
    {
        public static int M;

        public void TransformMtoS()
        {
            if (Greet.S == "q")
            {
                return;
            }

            M = Int32.Parse(Greet.S);
        }
    }
}
