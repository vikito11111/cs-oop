List<Animal> zoo = new List<Animal>();

zoo.Add(new Dog());
zoo.Add(new Bird());
zoo.Add(new Cat());
zoo.Add(new Snake());


public class Animal
{
    public string Name { get; set; }
}

public class Cat : Animal
{

}

public class Dog : Animal
{

}

public class Bird : Animal
{

}

public class Snake : Animal
{

}