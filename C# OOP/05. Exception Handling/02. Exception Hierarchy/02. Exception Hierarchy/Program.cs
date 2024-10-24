string str = Console.ReadLine();

try
{
	Int32.Parse(str);

    Console.WriteLine("Successful Parsing! " + str);
}
catch (FormatException ex)
{
    Console.WriteLine("Hello from FormatException. " + ex.Message);
}
catch (OverflowException ex)
{
    Console.WriteLine("Hello from OverflowException. " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Hello from Exception. " + ex.Message);
}
finally
{
    Console.WriteLine("End.");
}