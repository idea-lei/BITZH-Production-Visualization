﻿// Ctrl + K + C comment
// Ctrl + K + U uncomment

// int
// float / double
// string
// bool

//int a = 0;
//if (a > 100)
//{
//    // do something
//    return;
//}

//if (a > 50)
//{
//    // do something else
//    return;
//}

//switch (a)
//{
//    case > 100:
//        break;
//    case > 50:
//        break;
//    default: break;
//}

// loops
//while (true)
//{
//    continue;
//    break;
//}

//for(int a = 0; a < 100; a++) // a++ == a += 1 == a=a+1
//{
//    continue;
//    break;
//}

//int[] array = new int[3] { 1, 2, 3 };
//foreach(int i in array)
//{
//    Console.WriteLine(i);
//}

//int?[] a = null;
//int[]? b = null;

int[] values = new int[100];
var rnd = new Random();
for (int i = 0; i < 100; i++)
{
    values[i] = rnd.Next(1000);
}


// find max value
int max(int[] val)
{
    int max1 = 0;
    foreach (int i in val)
    {
        if (max1 < i)
            max1 = i;
    }
    for (int ii = 0; ii < val.Length; ii++)
    {
        if (max1 == val[ii])
        {
            val[ii] = 0;
            break;
        }
    }
    return max1;
}

Console.WriteLine();
// sort
for (int i = 0; i < 100; i++)
{
    Console.WriteLine(max(values));
}

