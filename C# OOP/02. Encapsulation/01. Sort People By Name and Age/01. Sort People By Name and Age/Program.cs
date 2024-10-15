using _01._Sort_People_By_Name_and_Age;

var lines = int.Parse(Console.ReadLine());

var people = new List<Person>();

for (int i = 0; i < lines; i++)
{
    string[] personInfo = Console.ReadLine()
        .Split(' ');

    Person person = new Person(personInfo[0], personInfo[1], int.Parse(personInfo[2]));

    people.Add(person);
}

foreach (Person person in people.OrderBy(x => x.FirstName).ThenBy(x => x.Age))
{
    Console.WriteLine(person.ToString());
}