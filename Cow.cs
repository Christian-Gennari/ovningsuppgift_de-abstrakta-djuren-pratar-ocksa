using System;

namespace de_abstrakta_djuren_pratar_ocksa;

public class Cow : Animal
{
  public Cow(string name)
  {
    this.name = name;
  }

  public override void Speak()
  {
    Console.WriteLine($"{name} says Moo!");
  }
}
