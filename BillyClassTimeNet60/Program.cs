using Model;
using System.IO;
using static System.Console;

var person = new Person //Con el comentario de Person, sería totalmente de tipo anónimo
{
	FirstName = "Billy",
	LastName = "Vanegas"
};

var otherPerson = person with { LastName = "Brotons"};

WriteLine(person);
WriteLine(otherPerson);

var originalPerson = otherPerson with { LastName = "Espitia" };

WriteLine(originalPerson);
WriteLine($"Equals: {Equals(person, originalPerson)}");
WriteLine($"== operator: {person == originalPerson}");

// Asignar los valores de la estructura

Person p1 = default;
Person p2 = new();
