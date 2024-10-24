try
{
    int number = int.Parse(Console.ReadLine());

    Console.WriteLine(number);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Finally!");
}