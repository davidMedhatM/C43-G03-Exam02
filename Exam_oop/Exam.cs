public abstract class Exam 
{
    public TimeSpan ExamTime { get; set; }
    public int NumberOfQuestions { get; set; }
    public Subject Subject { get; set; }
    public List<Question> Questions { get; set; }

    public Exam(TimeSpan time, int numQuestions, Subject subject)
    {
        ExamTime = time;
        NumberOfQuestions = numQuestions;
        Subject = subject;
        Questions = new List<Question>();
    }

    public abstract void ShowExam();

}
