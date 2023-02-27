namespace Lecture2_ClassLibrary;

public class PublicClass
{
    // private field, property, method
}

internal class InternalClass
{

}

public class Person
{
    // field: _camelCase
    private string _name;
    protected string Name { get { return _name; } }
}

public class Student: Person
{
    public string GetName()
    {
        //string n = _name;
        return Name;
    }
}