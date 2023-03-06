using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_Console;

// animals can eat
// animals have names
// dogs can bark
// cats can meow

internal class Animal
{
    public string Name { get; set; }
    public void Eat()
    {

    }
}

internal class Dog { 
    public void Bark() { }
}

internal class Cat {
    public void Meow() { }
}
