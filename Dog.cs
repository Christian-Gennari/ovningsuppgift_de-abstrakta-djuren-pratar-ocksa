using System;

namespace de_abstrakta_djuren_pratar_ocksa;

public class Dog : Animal
{
  public Dog(string name)
  {
    this.name = name;
  }
  public override void Speak()
  {
    Console.WriteLine($"{name} says Woof!");
  }

}
