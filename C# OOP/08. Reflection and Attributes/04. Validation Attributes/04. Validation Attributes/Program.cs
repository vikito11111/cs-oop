using _04._Validation_Attributes.Models.Person;
using _04._Validation_Attributes.Utils;

var person = new Person(null, -1);

bool isValidEntity = Validator.IsValid(person);

Console.WriteLine(isValidEntity);