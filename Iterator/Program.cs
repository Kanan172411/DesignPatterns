using Iterator;

Console.Title = "Iterator";

PeopleCollection people = new();

people.Add(new Person("Brandon Stark", "Winterfell"));
people.Add(new Person("Tywin Lannister", "Casterly Rock"));
people.Add(new Person("Robert Baratheon", "Hornhill"));
people.Add(new Person("Margery Tyrell", "HighGarden"));

var peopleIterator = people.CreateIterator();

for (Person person = peopleIterator.First(); !peopleIterator.IsDone; person = peopleIterator.Next())
{
    Console.WriteLine(person?.Name);
}