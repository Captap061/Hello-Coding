using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
         // 5-1
        Console.WriteLine("5-1) 첫 번째 숫자를 입력하세요.");
        string userInput1 = Console.ReadLine();
        int number1 = int.Parse(userInput1);
        Console.WriteLine("5-1) 두 번째 숫자를 입력하세요.");
        string userInput2 = Console.ReadLine();
        int number2 = int.Parse(userInput2);
        Console.Write(number1);
        Console.Write(" + ");
        Console.Write(number2);
        Console.Write(" = ");
        Console.WriteLine(number1 + number2);

        // 5-2
        Console.WriteLine("5-2) 첫 번째 숫자를 입력하세요.");
        string userInput3 = Console.ReadLine();
        Console.WriteLine("5-2) 두 번째 숫자를 입력하세요.");
        string userInput4 = Console.ReadLine();
        int number3 = int.Parse(userInput3);
        int number4 = int.Parse(userInput4);
        Console.WriteLine("5-2) 빼기 결과");
        Console.WriteLine(number3 - number4);

        // 5-3
        Console.WriteLine("5-3) 첫 번째 숫자를 입력하세요.");
        double number = double.Parse(Console.ReadLine());
        Console.Write("5-3) 입력한 숫자는   ");
        Console.WriteLine(number);

        // 심화 5-1
        Console.WriteLine("심화 5-1) 첫 번째 실수를 입력하세요.");
        double userInput6 = double.Parse(Console.ReadLine());
        Console.WriteLine("심화 5-1) 두 번째 실수를 입력하세요.");
        double userInput7 = double.Parse(Console.ReadLine());
        Console.WriteLine("더하기");
        Console.WriteLine(userInput6 + userInput7);
        Console.WriteLine("빼기");
        Console.WriteLine(userInput6 - userInput7);
        Console.WriteLine("곱하기");
        Console.WriteLine(userInput6 * userInput7);
        Console.WriteLine("나누기");
        Console.WriteLine(userInput6 / userInput7);
        /* 
        심화 5-2
            분모가 되는 값에 0을 넣으면 무한대가 나온다.
            1을 1로 나누면 1, 1을 0.1으로 나누면 10, 1을 0.01로 나누면 100이 된다.
            분모가 작아지면 작아질수록 최종값은 커진다.
            결과적으로 0으로 나누면 무한히 커져버려서 무한이 나오게 된다.

            double이 아닌 int로 하면 안된다. 
            0과 1 사이에는 끝도 없이 많은 수가 있다.
            그래서 무제한 이라는 것도 double이 표현할 수 있는 수의 범위에 들어간다.

            하지만 정수라는 것은 그 세계가 무제한이 아니다.
            double에서 int로 바꿔주고 실행해주면 무제한이 아니라 에러가 난다.
         */

        // 심화 5-3
        Console.WriteLine("주머니에는 동전이 10개 들어 있습니다. ");
        int pocket = 10;
        Console.WriteLine("어머니는 몇 개의 동전을 주머니에 넣었나요? ");
        int userInput8 = int.Parse(Console.ReadLine());
        Console.WriteLine("아람이는 몇 개의 동전을 꺼냈나요? ");
        int userInput9 = int.Parse(Console.ReadLine());
        Console.WriteLine("우람이는 몇 개의 동전을 꺼냈나요? ");
        int userInput10 = int.Parse(Console.ReadLine());
        int sum = pocket + userInput8 - userInput9 - userInput10;
        Console.WriteLine("주머니에 남아 있는 동전의 개수는" + sum + "개 입니다.");
        }
    }
}
