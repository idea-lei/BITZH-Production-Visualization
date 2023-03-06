using Lecture3_Console;

//var circle = new Circle()
//{
//    Height = 20,
//    Width = 20,
//};

//// public,
//// protected,
//// private,
//// internal



//var student = new Student()
//{
//    Birthday = DateTime.Now,
//    StudentId = "123",
//    Name = "ABC"
//};

//student.Name = "abc";
//Console.WriteLine($"{student.Name} is {student.Age} years old, his student id is {student.StudentId}" );


var a = GenericSample.TakeNumber(1);
var b = GenericSample.TakeNumber(1.1);

var gtype = new GType<int>()
{
    Value = 1
};

Console.WriteLine(gtype.Value);