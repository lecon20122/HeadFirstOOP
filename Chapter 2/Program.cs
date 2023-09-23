// See https://aka.ms/new-console-template for more information
using HeadFirstOOP;

DogDoor dogDoor = new();

Remote remote = new(dogDoor);

Console.WriteLine("Fredo need to go outside..");
remote.PreesButton();
Console.WriteLine("\nFredo has gone outside..");
remote.PreesButton();
Console.WriteLine("\nFredo all done");
remote.PreesButton();
Console.WriteLine("\nFredo's back inside");
remote.PreesButton();
