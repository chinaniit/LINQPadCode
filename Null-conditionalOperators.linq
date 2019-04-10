<Query Kind="Program" />

void Main()
{
	Person person = null;
	var first = person?.FirstName;
	person.Dump();
	first.Dump();
}

public class Person
{
	public string FirstName { get; set; }
}