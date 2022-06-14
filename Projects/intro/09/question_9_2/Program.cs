using System;

namespace question_9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];

            for (int index = 0; index < scores.Length; index++)
            {
                Console.Write(index);
                Console.WriteLine("번째 과목의 성적을 입력하세요.");
                scores[index] = int.Parse(Console.ReadLine());
            }
            Console.Write("총점은");
            Console.Write(scores[0] + scores[1] + scores[2] + scores[3] + scores[4]);
            Console.WriteLine("점입니다.");
        }
    }
}
