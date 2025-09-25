using System;

namespace de_abstrakta_djuren_pratar_ocksa;

public class Cat : Animal
{

  public Cat(string name)
  {
    this.name = name;
  }

  public override void Speak()
  {
    Console.WriteLine($"{name} says Meow!"); ;
  }
}
