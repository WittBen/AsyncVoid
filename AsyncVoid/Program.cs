using ConsoleApp1;

var process = new BackgroundTask();

Console.WriteLine("Start");

try
{
  process.RunAsync();
}
catch(Exception ex)
{
  Console.WriteLine(ex.ToString()); 
}

Console.WriteLine("End");

Console.ReadKey();