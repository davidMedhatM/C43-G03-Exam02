public class PracticalExam : Exam
{
    public PracticalExam(TimeSpan time, int numQuestions, Subject subject)
        : base(time, numQuestions, subject)
    {
    }

    public override void ShowExam()
    {
        int totalScore = 0;
        Console.WriteLine($"Practical Exam for {Subject.SubjectName}");
        Console.WriteLine($"Time Allowed: {ExamTime.TotalMinutes} minutes");

        foreach (var question in Questions)
        {
            Console.WriteLine(question.ToString());
            foreach (var answer in question.AnswerList)
            {
                Console.WriteLine($"  {answer.AnswerId}. {answer.AnswerText}");
            }

            Console.Write("Enter your answer (answer ID): ");
            if (int.TryParse(Console.ReadLine(), out int userAnswer))
            {
                if (userAnswer == question.RightAnswerId)
                {
                    Console.WriteLine("Correct!");
                    totalScore += question.Mark;
                }
                else
                {
                    Console.WriteLine($"Wrong!");
                }
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.WriteLine($"Correct Answer: {question.RightAnswerId}"); 

        }
        Console.WriteLine($"Your Grade: {totalScore}");
    }
}