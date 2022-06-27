using System;

namespace Lection2_27_06
{
    class Program
    {
        static int ConvertHoursToMinutes(int numberOfHours)
        {
            return numberOfHours * 60;
        }

        static float CalculateEquation(int a, int b)
        {
            return (float)(5 * a + b * b) / (b - a);
        }

        static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        static void Test(ref int a)
        {
            a = 100;
        }

        static void AnotherTest(out int a)
        {
            a = 10;
        }

        static void Main(string[] args)
        {
            string a = "Hello";
            string b = "World";

            Swap(ref a, ref b);

            Console.WriteLine(a + b);
        }
    }
}
