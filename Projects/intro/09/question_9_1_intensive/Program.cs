using System;

namespace DoorkLock_6Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] passcodeNumbers = { 6, 2, 1, 9, 4, 7 };

            int passcodeLength = 6;
            int[] userInput = new int[passcodeLength];

            for (int count = 0; count < 5; count++)
            {
                Console.Write("[" + (count + 1) + "]");
                Console.WriteLine(" 번째 로그인 시도");

                for (int passcodeIndex = 0; passcodeIndex < passcodeLength; passcodeIndex++)
                {
                    Console.Write(passcodeIndex + 1);
                    Console.WriteLine(" 번째 숫자를 넣어주세요. ");
                    userInput[passcodeIndex] = int.Parse(Console.ReadLine());
                }

                bool isPasswordCorrect = true;
                // 틀린 비밀번호가 하나라도 없어야 열린다.
                // 비밀번호를 입력받을 때마다 그 값이 틀린다면 false를 대입하겠다는 의미이다.

                for (int passcodeIndex = 0; passcodeIndex < passcodeLength; passcodeIndex++)
                {
                    if (userInput[passcodeIndex] != passcodeNumbers[passcodeIndex])
                    // 틀린 숫자가 하나라도 나오면 즉시 false로 바꾼다.
                    {
                        isPasswordCorrect = false;
                        Console.WriteLine("비밀번호가 틀렸습니다.");
                        break;
                    }
                }

                if (isPasswordCorrect)
                // 비밀번호를 정확하게 입력했다면 isPasswordCorrect의 값은 true가 된다. 
                {
                    Console.WriteLine("문이 열렸습니다. ");
                    break;
                }
            }
        }
    }
}