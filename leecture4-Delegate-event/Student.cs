using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leecture4_Delegate_event;

internal class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Action ExamDelegate { get; set; }
}
