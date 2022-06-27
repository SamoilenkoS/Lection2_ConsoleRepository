using System;

namespace Lection2_27_06
{
    class Program
    {
        static void Task3()
        {
            Console.WriteLine("enter number A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number B");
            int B = Convert.ToInt32(Console.ReadLine());

            (A, B) = (B, A);

            Console.WriteLine(
                $"number A = {A}{Environment.NewLine}" +
                $"number B = {B}");
        }

        static void Task6()
        {
            Console.WriteLine("enter coordinates x1");
            float X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter coordinates y1");
            float Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter coordinates x2");
            float X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter coordinates y2");
            float Y2 = Convert.ToInt32(Console.ReadLine());

            float A = (Y1 - Y2) / (X1 - X2);
            float B = Y2 - A * X2;

            Console.WriteLine("\nPoint A coordinates: " + "x1: " + X1 + "  y1: " + Y1 +
                               "\nPoint B coordinates: " + "x2: " + X2 + " y2: " + Y2 +
                       "\n\nStraight line equation: y = " + A + "x + " + B);
        }

        static void Main(string[] args)
        {
            Task6();
        }
    }
}
