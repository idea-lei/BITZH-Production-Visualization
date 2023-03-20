using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture4_console;

internal class Student
{
    public static int Count { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
    List<string> Exams { get; set; } = new List<string>();
    public int Age { get; set; }

    public Student()
    {
        Count++;
    }
}
