using System;

namespace question_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7-1
            double[] weights = new double[3];
            Console.WriteLine("-----7-1-----");
            weights[0] = double.Parse(Console.ReadLine());
            weights[1] = double.Parse(Console.ReadLine());
            weights[2] = double.Parse(Console.ReadLine());

            Console.Write("첫 번째 무게: ");
            Console.WriteLine(weights[0]);
            Console.Write("두 번째 무게: ");
            Console.WriteLine(weights[1]);
            Console.Write("세 번째 무게: ");
            Console.WriteLine(weights[2]);

            // 7-2
            int[] scores = { 90, 85, 73, 100 };
            Console.WriteLine("-----7-2-----");
            Console.WriteLine(scores[0]);
            Console.WriteLine(scores[1]);
            Console.WriteLine(scores[2]);
            Console.WriteLine(scores[3]);

            // 7-3
            Console.WriteLine("-----7-3-----");
            string[] subjects = { "국어", "영어", "수학" };
            int[] score = new int[3];

            Console.WriteLine(subjects[0]);
            Console.WriteLine(" 점수를 입력하세요. ");
            score[0] = int.Parse(Console.ReadLine());

            Console.WriteLine(subjects[1]);
            Console.WriteLine(" 점수를 입력하세요. ");
            score[1] = int.Parse(Console.ReadLine());

            Console.WriteLine(subjects[2]);
            Console.WriteLine(" 점수를 입력하세요. ");
            score[2] = int.Parse(Console.ReadLine());

            Console.Write(subjects[0]);
            Console.Write(" 점수: ");
            Console.WriteLine(score[0]);

            Console.Write(subjects[1]);
            Console.Write(" 점수: ");
            Console.WriteLine(score[1]);

            Console.Write(subjects[2]);
            Console.Write(" 점수: ");
            Console.WriteLine(score[2]);

            // 심화 7-1
            Console.WriteLine("-----심화 7-1-----");
            Console.WriteLine("학생 숫자를 입력하세요.");
            int studentCount = int.Parse(Console.ReadLine());

            int[] ages = new int[studentCount];
            string[] names = new string[studentCount];
            double[] heights = new double[studentCount];
            int[] weight = new int[studentCount];

            Console.WriteLine("몇 번째 학생의 정보를 추가할까요? ");
            int studentNumber = int.Parse(Console.ReadLine());

            if (studentNumber >= 0 && studentNumber < studentCount - 1)
            {

                Console.WriteLine("나이를 입력하세요. ");
                ages[studentNumber] = int.Parse(Console.ReadLine());

                Console.WriteLine("이름을 입력하세요. ");
                names[studentNumber] = Console.ReadLine();

                Console.WriteLine("키를 입력하세요. ");
                heights[studentNumber] = double.Parse(Console.ReadLine());

                Console.WriteLine("몸무게를 입력하세요. ");
                weight[studentNumber] = int.Parse(Console.ReadLine());

                Console.Write(studentNumber);
                Console.WriteLine("번째 학생");
                Console.Write("이름: ");
                Console.WriteLine(names[studentNumber]);
                Console.Write("나이: ");
                Console.WriteLine(ages[studentNumber]);
                Console.Write("키: ");
                Console.WriteLine(heights[studentNumber]);
                Console.Write("몸무게: ");
                Console.WriteLine(weight[studentNumber]);
            }
            else
            {
                Console.Write("0에서 ");
                Console.Write(studentCount - 1);
                Console.WriteLine("사이의 숫자를 입력하세요. ");
            }
            // 심화 7-2
            Console.WriteLine("-----심화 7-2-----");
            int[] mean = new int[5];

            Console.WriteLine("국어 점수를 입력해주세요. ");
            mean[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("영어 점수를 입력해주세요. ");
            mean[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("수학 점수를 입력해주세요. ");
            mean[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("과학 점수를 입력해주세요. ");
            mean[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("사회 점수를 입력해주세요. ");
            mean[4] = int.Parse(Console.ReadLine());

            Console.Write("총점: ");
            Console.WriteLine(mean[0] + mean[1] + mean[2] + mean[3] + mean[4]);
            Console.Write("평균: ");
            Console.WriteLine((mean[0] + mean[1] + mean[2] + mean[3] + mean[4]) / mean.Length );
        }
    }
}
