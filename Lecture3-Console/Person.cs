using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_Console;

internal class Person
{
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
    public int Age // readonly
    {
        get
        {
            return DateTime.Now.Year - Birthday.Year;
        }
    }
}

internal class Student : Person
{
    public string StudentId { get; set; }

    // important to know how to use List<T>
    public List<string> Exams { get; set; }
    public void TakeExame(string exam)
    {
        Exams.Add(exam);
        Console.WriteLine(exam);
    }
}

internal class Teacher : Person
{
    public string TeacherId { get; set; }
    public void EvaluateExam()
    {

    }
}
