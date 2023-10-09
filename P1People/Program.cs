Person[] people = new Person[3];

for (var i = 0; i < people.Length; i++)
{
    people[i] = new Person();
}

foreach (Person person in people)
{
    Console.WriteLine(person);
}

public class Person
{
    
}