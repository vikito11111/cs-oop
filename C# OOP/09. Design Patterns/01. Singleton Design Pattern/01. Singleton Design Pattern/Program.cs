using _01._Singleton_Design_Pattern;

for (int i = 0; i < 10000; i++)
{
    new Thread(() =>
    {
        var test = UserSingleton.Instance.Name;
    }).Start();
}

Console.WriteLine("Before initializing singleton");

UserSingleton loggedUser = UserSingleton.Instance;

loggedUser.Name = "Pesho";
loggedUser.Password = "12345";

loggedUser.ChangePassword("pesho12345");