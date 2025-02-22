
using System.Diagnostics;


Subject subject = new Subject(10, "C#");
subject.CreateExam();

Console.Write("Do You Want To Start The Exam (y | n): ");
if (char.Parse(Console.ReadLine()) == 'y')
{
    Stopwatch sw = new Stopwatch();
    sw.Start();
    subject.Exam.ShowExam();
    sw.Stop();
    Console.WriteLine($"The Elapsed Time = {sw.Elapsed}");
}

