using System;

namespace de_abstrakta_djuren_pratar_ocksa;

public class Cat : Animal
{

  private string sleepingPlace = "";

  public Cat(string name, string sleepingPlace)
  {
    this.name = name;
    this.sleepingPlace = sleepingPlace;
  }

  public override void Speak()
  {
    Console.WriteLine($"{name} says Meow! while lounging {sleepingPlace}"); ;
  }
}
