using de_abstrakta_djuren_pratar_ocksa;

List<Animal> animals =
[
    new Dog("Sir Barks-a-Lot", "pizza"),
    new Dog("Droolius Caesar", "bones"),
    new Cat("Waffleton", "on the windowsill"),
    new Cat("Meowstro", "under the bed"),
    new Cow("Cowabunga", "Hay Fever Farms"),
    new Cow("Oreo", "Hay Fever Farms")
];

foreach (var animal in animals)
{
    animal.Speak();
}
