using de_abstrakta_djuren_pratar_ocksa;

List<Animal> animals =
[
    new Dog("Sir Barks-a-Lot"),
    new Dog("Droolius Caesar"),
    new Cat("Waffleton"),
    new Cat("Meowstro"),
    new Cow("Cowabunga"),
    new Cow("Oreo"),
];

foreach (var animal in animals)
{
    animal.Speak();
}
