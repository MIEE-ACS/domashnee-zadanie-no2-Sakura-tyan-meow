using System;

namespace dz2
{
    class Program
    {
        static void Main(string[] args)
        {

            double y;
            //y = double.Parse(Console.ReadLine());
            double R = double.Parse(Console.ReadLine());
            for (double x = -9; x <= 5; x = x+0.01)
            {
                @if(R, x);
                
            }
            while (true)
            {
                Console.WriteLine("введите x :");
               double x = double.Parse(Console.ReadLine());
                 @if(R, x);
                
            }


        }

        static void @if(double R, double x)
        {
            double y = 0;
            if (x < -5)
            {

                //int R = Console.ReadLine();


                if (R < 4)
                {
                    Console.WriteLine("функция не определена на данном участке");
                }
                else
                {
                    y = Math.Round(Math.Sqrt(R - x * x), 5);
                    Console.WriteLine($"{y}");
                }

            }
            else if (x >= -5 && x <= -4)
            {
                y = 2;
                Console.WriteLine($"{y}");
            }
            else if (x > -4 && x <= 0)
            {
                y = Math.Round(-x, 5);
                Console.WriteLine($"{y}");
            }
            else if (x >= 0 && x <= Math.PI)
            {
                y = Math.Round(Math.Sin(x), 5);
                Console.WriteLine($"{y}");
            }
            else if (x >= Math.PI)
            {
                y = Math.Round(x, 5);
                Console.WriteLine($"{y}");
            }

           
        }
    }
}
