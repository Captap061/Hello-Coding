using System;

namespace question_9_2_intensive
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] schoolScores = new int[5];

			int schoolClass = 5;
			int schoolStudent = 10;

			for ( int i = 0; i < schoolClass; i++)
			{
				Console.Write(i + 1);
				Console.WriteLine("반의 성적을 입력합니다. ");

				for ( int j = 0; j < schoolStudent; j++)
				{
					Console.Write(j + 1);
					Console.Write("번째 학생의 성적을 입력해주세요.");
					schoolScores[i] = schoolScores[i] + int.Parse(Console.ReadLine());
				}

			}
			for (int i=0; i < schoolClass; i++)
            {
				Console.Write(i + 1);
				Console.Write("반의 평균은");
				Console.WriteLine(schoolScores[i] / schoolStudent);
			}
		}
	}
}
