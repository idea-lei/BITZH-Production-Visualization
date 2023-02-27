// a project is also known as "Assembly"




// using Packages
//using System;
//using MiniResult;
//Console.WriteLine(Math.Sin(Math.PI * 2));

//Result Operation()
//{
//    return Result.Ok();
//}




// Debugging
//void Delay()
//{
//    int i = 0;
//    int ii = 0;
//    int iii = 0;
//}
//int[] values = new int[100];
//var rnd = new Random();
//for (int i = 0; i < 100; i++)
//{
//    values[i] = rnd.Next(1, 1000);
//}


// find max value
//int max(int[] val)
//{
//    int max1 = 0;
//    foreach (int i in val)
//    {
//        if (max1 < i)
//        {
//            Delay();
//            max1 = i;
//        }
//    }
//    for (int ii = 0; ii < val.Length; ii++)
//    {
//        if (max1 == val[ii])
//        {
//            val[ii] = 0;
//            break;
//        }
//    }
//    return max1;
//}

//Console.WriteLine();
//// sort
//for (int i = 0; i < 100; i++)
//{
//    Console.WriteLine(max(values));
//}




// core syntax 
//int i = 0;
//int a;
//// a = 0;
//int b = a;


//void EmptyMethod()
//{

//}
//bool boolValue = true;
//if (boolValue)
//{
//    EmptyMethod();
//}

//string str = boolValue ? "true" : "false";

//if (boolValue)
//{
//    str = "true";
//}
//else
//{
//    str = "false";
//}

//string Function(string a)
//{
//    return a;
//}

//Function("a");

// ref, out, in

//int a = 5;
////void TempMethod(ref int i)
////{
////    i++;
////}
////TempMethod(ref a);

//void TempMethod(int ii)
//{
//    ii++;
//}
//TempMethod(a);
//Console.WriteLine(a);




// value type, reference type
// int a = 5;

//using lecture2_CSharp_Basic;

//void TempMethod(A a)
//{
//    a.a++;
//}

//var instanceOfA = new A();
//var newInstanceOfA = instanceOfA;
//TempMethod(instanceOfA);
//Console.WriteLine(instanceOfA.a);

// class -> object, reference type
// struct -> value type
