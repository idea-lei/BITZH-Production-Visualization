using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_Console;

// interface : what do you have (has)
public interface IDrawable
{
    public void Draw();
}

// class : what are you (is)
public class Shape
{
    public static void StaticMethod()
    {

    }
    // A few example members
    public int X { get; protected set; } // access modifier
    public int Y { get; protected set; }
    public int Height { get; set; }
    public int Width { get; set; }

    protected int protectedInt { get; set; }

    // Virtual method
    public virtual void Draw()
    {
        Console.WriteLine("Performing base class drawing tasks");
    }
}

public sealed class Circle : Shape, IDrawable
{
    public Circle()
    {

    }

    public Circle(int x, int y) : base()
    {
        this.X = x;
        this.Y = y;
    }

    public override void Draw()
    {
        // Code to draw a circle...
        Console.WriteLine("Drawing a circle");
        base.Draw();
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        // Code to draw a rectangle...
        Console.WriteLine("Drawing a rectangle");
        base.Draw();
    }
}
public class Triangle : Shape
{
    public override void Draw()
    {
        // Code to draw a triangle...
        Console.WriteLine("Drawing a triangle");
        base.Draw();
    }

    public void Method()
    {

    }

    public void Method(string a)
    {

    }
}
