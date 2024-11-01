using System.Reflection;

Type type = typeof(Human);

ConstructorInfo[] constructorInfos = type.GetConstructors();

Console.WriteLine($"Count: {constructorInfos.Length}");

ConstructorInfo constructorInfo = constructorInfos[0];

Console.WriteLine(constructorInfo.GetParameters().Length);


ParameterInfo[] parameters = constructorInfo.GetParameters();
Console.WriteLine($"Constructor: {constructorInfo.Name}");
Console.WriteLine(parameters.Length);

foreach (var parameter in parameters)
{
    Console.WriteLine($"{parameter.ParameterType.Name} - {parameter.Name}");
}

class Human
{
    private string name = "The Human";

    public Human()
    {

    }

    public Human(string name)
    {
        this.name = name;
    }
}