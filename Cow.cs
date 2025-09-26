using System;

namespace de_abstrakta_djuren_pratar_ocksa;

public class Cow : Animal
{

  private string farmyard = "";

  public Cow(string name, string farmyard)
  {
    this.name = name;
    this.farmyard = farmyard;
  }

  public override void Speak()
  {
    Console.WriteLine($"At {farmyard}, {name} says Moo!");
  }
}
