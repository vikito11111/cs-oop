using _02._Demo_1;
using System.Reflection;

Type type = typeof(Person);

PropertyInfo propertyInfo = type.GetProperty("Age");

MethodInfo methodInfo = type.GetMethod("GetName");

FieldInfo fieldInfo = type.GetField("name", BindingFlags.Instance | BindingFlags.NonPublic);

Person instance = (Person)Activator.CreateInstance(type, ["Pesho", 19]);  // as Person;

Console.WriteLine(instance.GetName());

fieldInfo.SetValue(instance, "Ivan");

Console.WriteLine(instance.GetName());

object result = methodInfo.Invoke(instance, null);

Console.WriteLine(result);

MemberInfo[] memberInfo = type.GetMembers();