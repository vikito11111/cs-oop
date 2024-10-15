using _02._Salary_Increase;

var lines = int.Parse(Console.ReadLine());

var people = new List<Person>();

for (int i = 0; i < lines; i++)
{
    string[] personInfo = Console.ReadLine()
        .Split(' ');

    Person person = new Person(personInfo[0], personInfo[1], int.Parse(personInfo[2]), decimal.Parse(personInfo[3]));

    people.Add(person);
}

decimal percentage = decimal.Parse(Console.ReadLine());

foreach (var person in people)
{
    person.IncreaseSalary(percentage);
}

foreach (Person person in people.OrderBy(x => x.Salary).ThenBy(x => x.Age))
{
    Console.WriteLine(person.ToString());
}