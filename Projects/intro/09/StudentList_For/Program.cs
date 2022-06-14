using System;

namespace StudentList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("학생 숫자를 입력하세요.");
            int studentCount = int.Parse(Console.ReadLine());

            int[] ages = new int[studentCount];
            string[] names = new string[studentCount];
            double[] heights = new double[studentCount];

            for ( int studentNumber = 0; studentNumber < studentCount; studentNumber++ )
            // 초기화 코드는 0으로 초기화
            // 조건식 studentNumber가 studentCount보다 작은동안 반복하라는 의미 
            // 증간문 studentNumber++ 반복문 회차가 한 번 끝날 때마다 실행된다
            {
                Console.Write(studentNumber);
                Console.WriteLine("번째 학생의 정보를 입력할 차례입니다. ");

                Console.WriteLine("나이를 입력하세요. ");
                ages[studentNumber] = int.Parse(Console.ReadLine());

                Console.WriteLine("이름을 입력하세요. ");
                names[studentNumber] = Console.ReadLine();

                Console.WriteLine("키를 입력하세요. ");
                heights[studentNumber] = double.Parse(Console.ReadLine());

            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("입력된 학생정보를 출력할 차례입니다.");
            
            for (int studentNumber = 0; studentNumber < studentCount; studentNumber++ ) 
            {
                Console.Write(studentNumber);
                Console.WriteLine("번째 학생");
                Console.Write("이름: ");
                Console.WriteLine(names[studentNumber]);
                Console.Write("나이: ");
                Console.WriteLine(ages[studentNumber]);
                Console.Write("키: ");
                Console.WriteLine(heights[studentNumber]);

            }
        }
    }
}