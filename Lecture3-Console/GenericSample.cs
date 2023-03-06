using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_Console;

internal class GenericSample
{
    public static T TakeNumber<T>(T number)
    {
        return number;
    }
}

public class GType<T>
{
    public T Value;
}
