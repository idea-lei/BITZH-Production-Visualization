// async await

public class Program
{
    public static async Task Main(string[] args)
    {
        string result = await AsyncMethod();
        Console.WriteLine(result);
    }

    static async Task<string> AsyncMethod()
    {
        Console.WriteLine("task start");
        await Task.Delay(5000);
        Console.WriteLine("task finished");
        return "return value";
    }
}
