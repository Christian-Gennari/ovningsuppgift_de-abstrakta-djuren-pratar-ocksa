using System;

namespace de_abstrakta_djuren_pratar_ocksa;

public class Dog : Animal
{
    private string favoriteToy = "";

    public Dog(string name, string favoriteToy)
    {
        this.name = name;
        this.favoriteToy = favoriteToy;
    }

    public override void Speak()
    {
        Console.WriteLine($"{name}, who likes {favoriteToy}, says Woof!");
    }
}
