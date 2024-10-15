using _03._Validation_of_Data;

var lines = int.Parse(Console.ReadLine());

var people = new List<Person>();

for (int i = 0; i < lines; i++)
{
    string[] personInfo = Console.ReadLine()
        .Split(' ');

	try
	{
        Person person = new Person(personInfo[0], personInfo[1], int.Parse(personInfo[2]), decimal.Parse(personInfo[3]));

        people.Add(person);
    }
	catch (Exception ex)
	{
        Console.WriteLine(ex.Message);
    }
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