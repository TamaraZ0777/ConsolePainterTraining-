using System;

namespace ConsolePainter
{
    class Program
    {
        static void Main(string[] args)
        {
            Paint paint = new Paint(40, 20);
            paint.PutRandomNumbers(400);
            //paint.FillFor(20, 10);
            //paint.FillQueue(20, 10);
            //paint.FillStack(20, 10);
            paint.FillDepth(20, 10);
            Console.ReadKey();
        }
    }
}

