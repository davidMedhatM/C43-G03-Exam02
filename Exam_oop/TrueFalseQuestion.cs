public class TrueFalseQuestion : Question
{
    public TrueFalseQuestion(string header, string body, int mark, int rightAnswer)
        : base(header, body, mark)
    {
        AnswerList = new Answer[]
        {
            new Answer(1, "True"),
            new Answer(2, "False")
        };
        RightAnswerId = rightAnswer;
    }
}
