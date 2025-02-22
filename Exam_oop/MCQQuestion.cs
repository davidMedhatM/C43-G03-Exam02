public class MCQQuestion : Question
{
    public MCQQuestion(string header, string body, int mark, List<Answer> answers, int rightAnswer)
        : base(header, body, mark)
    {
        AnswerList = answers.ToArray();
        RightAnswerId = rightAnswer;
    }
}
