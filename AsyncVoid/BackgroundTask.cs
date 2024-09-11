namespace ConsoleApp1;

public class BackgroundTask
{
  public async void RunAsync()
  {
      await Task.Delay(1000);
      Console.WriteLine("wait for a seconds");


    await  AnotherBackgroundTask();
  }


  private async Task AnotherBackgroundTask()
  {
    //do something...
    await Task.Delay(1000);
    try
    {
     // error occurs
      int[] myNumbers = { 1, 2, 3 };
      Console.WriteLine(myNumbers[10]); // error!
    }
    catch (Exception ex)
    {
       throw new Exception("ooops... an error");
    }

  }


}
