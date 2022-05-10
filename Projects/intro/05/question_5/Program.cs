using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4-1
            int number1 = 10;
            int number2 = 5;
            Console.WriteLine(number1 + number2);

            int number3 = 20;
            int number4 = 10;
            Console.WriteLine(number3 - number4);

            int number5 = 4;
            int number6 = 7;
            Console.WriteLine(number5 * number6);

            int number7 = 20;
            int number8 = 7;
            Console.WriteLine(number7 / number8);
            Console.WriteLine(number7 % number8);

            // 4-2
            Console.WriteLine("\"안녕\" + \"하세요\"");

            // 4-3
            // 25, 16, 1, 12, 4
            int num1 = 20;
            int num2 = 5;
            int num3 = 3;
            int num4 = 13;
            int num5;

            num1 = num1 + num2;
            // 20 + 5 = 25

            num2 = num3 + num4;
            // 3 + 13 = 16

            num4 = num1 - num4;
            // 25 - 13 = 12

            num3 = num2 / num4;
            // 16 / 12 = 1

            num5 = num2 % num4;
            // 16 % 12 = 4

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);

            // 4-4
            int number10 = 4 - 2;
            number10 = number10 * 16;
            number10 = number10 + 2;

            Console.WriteLine("(4-2) * 16 + 2");
            Console.WriteLine(number10);


            // 심화 4-1 
            int number = 2;
            number = number * 3; // 6
            number = number - 4; // 2
            number = number % 2; // 0
            Console.WriteLine(number);

            // 심화 4-2
            int pocket1 = 10;
            int pocket2 = pocket1 / 2; // 절반을 가져가서 5개
            int pocket3 = pocket2 + 1; // 죄책감에 1개 도로 넣어서 6개
            int aram = pocket1 - pocket3; // 10-6 = 4
            int uram = 2; // 10 - 6 - 2 = 2
            int pocket4 = pocket3 - uram; // 우람이가 충분하지 못해서 다시 2개 꺼냄 4개

            Console.WriteLine("아람의 개수: " + aram);
            Console.WriteLine("우람의 개수: " + uram);
            Console.WriteLine("주머니 상태: " + pocket4);
        }
    }
}
