public abstract class Question
{
    public string Header { get; set; }
    public string Body { get; set; }
    public int Mark { get; set; }
    public Answer[] AnswerList { get; set; }
    public int RightAnswerId { get; set; }

    public Question(string header, string body, int mark) 
    {
        Header = header;
        Body = body;
        Mark = mark;
        AnswerList = new Answer[0];
    }

    public override string ToString()
    {
        return $"{Header}\n{Body} (Mark: {Mark})";
    }
}
