using System;

namespace dz2
{
    class Program
    {
        static void Main(string[] args)
        {

            double y;
            //y = double.Parse(Console.ReadLine());
            for (double x = -9; x <= 5; x++)
            {
                if (x < -5)
                {


                    int R = 4;
                    y = Math.Sqrt(R - x * x);
                    Console.WriteLine(y);

                }
                else if (x >= -5 && x <= -4)
                {
                    y = 2;
                    Console.WriteLine(y);
                }
                else if (x > -4 && x <= 0)
                {
                    y = -x;
                    Console.WriteLine(y);
                }
                else if (x >= 0 && x <= Math.PI)
                {
                    y = Math.Sin(x);
                    Console.WriteLine(y);
                }
                else if (x >= Math.PI)
                {
                    y = x;
                    Console.WriteLine(y);
                }
            }



        }








    }
}
