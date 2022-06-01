using System;

namespace question_8_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("총 학생 수는?");
            int friendCount = int.Parse(Console.ReadLine());

            int[] koreanScores = new int[friendCount];
            int[] engScores = new int[friendCount];
            int[] mathScores = new int[friendCount];

            int index = 0;

            while (index < friendCount)
            {
                Console.Write(index + 1);
                Console.WriteLine("번째 친구의 국어 성적은?");
                koreanScores[index] = int.Parse(Console.ReadLine());

                Console.Write(index + 1);
                Console.WriteLine("번째 친구의 영어 성적은?");
                engScores[index] = int.Parse(Console.ReadLine());

                Console.Write(index + 1);
                Console.WriteLine("번째 친구의 수학 성적은?");
                mathScores[index] = int.Parse(Console.ReadLine());
                index = index + 1;
            }

            // 이미 index가 총 학생 수 만큼 증가가 되었기 때문에 0으로 
            index = 0;

            while (index < friendCount)
            {
                int total = koreanScores[index] + engScores[index] + mathScores[index];

                Console.Write(index + 1);
                Console.Write("번째 학생의 총점은 ");
                Console.Write(total);
                Console.WriteLine("입니다.");

                Console.Write(index + 1);
                Console.Write("번째 학생의 평균은 ");
                Console.Write(total / 3);
                Console.WriteLine("입니다.");
                Console.WriteLine(">------"); // 구분선
                index = index + 1;
                
            }
        }
    }
}