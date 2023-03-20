// Generic
//namespace lecture4_console;

//using Newtonsoft.Json;

//List<string> stringList = new List<string>();

//IEnumerable<string> strings = new List<string>();

////stringList.Add(string.Empty);

////string[] stringArr = new string[10];

//var student = new Student() { Id = 1, Name ="ABC" };

//string str = JsonConvert.SerializeObject(student);
//Console.WriteLine(str);

//var newStudent = JsonConvert.DeserializeObject<Student>(str);
//Console.WriteLine(newStudent.Name);



// Delegate - event
// delegate is type-safe pointer towards method(s)

// static property
using lecture4_console;

var stud1 = new Student();
var stud2 = new Student();
var stud3 = new Student();

stud1.Name = "Test";

Console.WriteLine(Student.Count);

void TestFunction(Action action)
{
    Console.WriteLine("before action invoke");
    action();
    Console.WriteLine("after action invoke");
}

void Act1()
{
    Console.WriteLine("This is the action 1");
}

void Act2()
{
    Console.WriteLine("This is the action 2");
}

TestFunction(Act1);

TestFunction(Act2);