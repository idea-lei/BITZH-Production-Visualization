using leecture4_Delegate_event;

delegate void TestDelegate(string input);

public class Program
{
    public static void Main(string[] args)
    {
        var student = new Student();
        student.ExamDelegate = WriteExam;
        student.ExamDelegate();
    }

    public static void WriteExam()
    {
        Console.WriteLine("writing exam");
    }

    public static void WriteExamUpper(string msg)
    {
        Console.WriteLine(msg.ToUpper());
    }
}