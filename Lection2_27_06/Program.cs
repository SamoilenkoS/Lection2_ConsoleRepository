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

        static void SwapMain()
        {
            string a = "Hello";
            string b = "World";

            Swap(ref a, ref b);

            Console.WriteLine(a + b);
        }

        static void IfElseDemo()
        {
            int kilometers = -5;
            if (kilometers > 0)
            {
                Console.WriteLine(kilometers * 1000);
            }
            else
            {
                Console.WriteLine("Invalid kilometers amount!");
            }
        }

        static void SwitchCaseDemo()
        {
            Console.WriteLine("Enter 1 to task 1");
            Console.WriteLine("Enter 2 to task 2");
            Console.WriteLine("Enter 0 to exit");
            int menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.WriteLine("Task 1 called!");
                    break;
                case 2:
                    Console.WriteLine("Task 2 called!");
                    break;
                case 0:
                    Console.WriteLine("Bye bye!");
                    break;
                default:
                    Console.WriteLine("Incorrect input!");
                    break;
            }
        }

        static (int x, int y) CalculateSomething()
        {
            return (10, 20);
        }

        //В переменной min лежит число от 0 до 59.
        //Определите в какую четверть часа попадает это число
        //(в первую, вторую, третью или четвертую).
        static int GetHourQuater(int min)
        {//&& and
            // || or
            int result = 0;
            if (min >= 0 && min <= 14)
            {
                result = 1;
            }
            else if (min >= 15 && min <= 29)
            {
                result = 2;
            }
            else if (min >= 30 && min <= 44)
            {
                result = 3;
            }
            else if (min >= 45 && min <= 59)
            {
                result = 4;
            }

            return result;
            //0-14
            //15-29
            //30-44
            //45-59
        }

        //Найти среднее из трёх чисел (для 2, 1, 5 это 2)
        static int MiddleNumber(int a, int b, int c)
        {
            int result;
            if(a == b || a == c || b == c)
            {
                return -1;
            }

            if((a > b && a < c) || (a < b && a > c))
            {
                result = a;
            }
            else if((b > a && b < c) || (b < a && b > c))
            {
                result = b;
            }
            else
            {
                result = c;
            }

            return result;
        }

        static bool IsHighYear(int year)
        {
            return year % 4 == 0;
        }

        static int TestResponse(int input)
        {
            return input % 10 == 0 ? 100 : 50;
        }

        //Пользователь вводит целое число.
        //Если оно является четным и при этом не находится между 10 и 20,
        //то вывести на экран его квадрат.
        //В противном случае напечатать исходное число.

        static bool Check1(int number)
        {
            Console.WriteLine("Checking that number is greater than 10");

            return number > 10;
        }

        static bool Check2(int number)
        {
            Console.WriteLine("Checking that number is lower than 20");

            return number < 20;
        }

        static int TestTask(int number)
        {
            return
                (Check1(number) && Check2(number) && number % 2 == 0)
                ? number * number
                : number;
        }

        static void Main(string[] args)
        {
            TestTask(5);

            //int a = 10;
            //int b;
            //if(a % 2 == 0)
            //{
            //    b = 5;
            //}
            //else
            //{
            //    b = 123;
            //}

            //b = (a % 2 == 0) ? 5 : 123;

            //a = a * 2;
            //a *= 2;
            //a /= 2;
            //a -= 10;
            //a += 5;
            //a = a + 1;

            //a = 5;
            //++a;//equivalent to 171//6
            //a++;//=>//7
            //int c = ++a;//c = 8; a = 8;
            //int d = a++;//a = 9; d = 8;

            //int e = --a;//a = 8; e = 8;
            //int f = a--;//a = 7; f = 8;


            //Console.WriteLine(MiddleNumber(1, 2, 3));
            //Console.WriteLine(MiddleNumber(1, 3, 2));
            //Console.WriteLine(MiddleNumber(3, 2, 1));
            //Console.WriteLine(MiddleNumber(3, 1, 2));
            //Console.WriteLine(MiddleNumber(2, 1, 3));
            //Console.WriteLine(MiddleNumber(2, 3, 1));
            //Console.WriteLine(MiddleNumber(3, 2, 3));
            //Console.WriteLine(MiddleNumber(3, 3, 2));
            //Console.WriteLine(MiddleNumber(2, 3, 3));
            //(int x, int y) = CalculateSomething();

            //Console.WriteLine(x + " " + y);

            //Console.WriteLine(GetHourQuater(-55));
        }
    }
}
