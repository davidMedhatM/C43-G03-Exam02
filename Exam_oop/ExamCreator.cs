using System;

public static class ExamCreator
{
    public static Exam CreateExam(Subject subject)
    {
        Console.WriteLine("Please Enter The Type Of Exam You Want To Create (1 for Practical and 2 for Final): ");
        int examType = int.Parse(Console.ReadLine());

        Console.WriteLine("Please Enter The Time Of Exam In Minutes: ");
        int minutes = int.Parse(Console.ReadLine());

        Console.WriteLine("Please Enter The Number of Questions You Wanted To Create: ");
        int numberOfQuestions = int.Parse(Console.ReadLine());

        Exam exam;
        if (examType == 1)
            exam = new PracticalExam(TimeSpan.FromMinutes(minutes), numberOfQuestions, subject);
        else
            exam = new FinalExam(TimeSpan.FromMinutes(minutes), numberOfQuestions, subject);


        for (int i = 0; i < numberOfQuestions; i++)
        {
            if (examType == 1)
            {
                Console.WriteLine("MCQ only valid for  Practical Exam: ");

                Console.WriteLine("Please Enter The Body of Question: ");
                string body = Console.ReadLine();

                Console.WriteLine("Please Enter The Marks of Question: ");
                int marks = int.Parse(Console.ReadLine());

                List<Answer> answers = new List<Answer>();
                Console.WriteLine("Please Enter The Choices of Question: ");
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Please Enter The Choice Number {j + 1}: ");
                    string choice = Console.ReadLine();
                    answers.Add(new Answer(j + 1, choice));
                }
                Console.WriteLine("Please Specify The Right Choice of Question: ");
                int rightChoice = int.Parse(Console.ReadLine());
                exam.Questions.Add(new MCQQuestion($"Choose One Answer Question", body, marks, answers, rightChoice));
            }
            else
            {
                Console.WriteLine("Please Choose The Type Of Question (1 for True OR False | 2 for MCQ): ");

                int questionType = int.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter The Body of Question: ");
                string body = Console.ReadLine();

                Console.WriteLine("Please Enter The Marks of Question: ");
                int marks = int.Parse(Console.ReadLine());

                if (questionType == 1)
                {
                    Console.WriteLine("Please Enter The Right Answer of Question (1 for True and 2 for False): ");
                    int rightAnswer = int.Parse(Console.ReadLine());
                    exam.Questions.Add(new TrueFalseQuestion($"True | False Question", body, marks, rightAnswer));
                }
                else
                {
                    List<Answer> answers = new List<Answer>();
                    Console.WriteLine("Please Enter The Choices of Question: ");
                    for (int j = 0; j < 3; j++) 
                    {
                        Console.WriteLine($"Please Enter The Choice Number {j + 1}: ");
                        string choice = Console.ReadLine();
                        answers.Add(new Answer(j + 1, choice));
                    }
                    Console.WriteLine("Please Specify The Right Choice of Question: ");
                    int rightChoice = int.Parse(Console.ReadLine());
                    exam.Questions.Add(new MCQQuestion($"Choose One Answer Question", body, marks, answers, rightChoice));
                }
            }
        }

        return exam;
    }
}
