namespace RunningBunny;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("PRESS ENTER TO RUN");
        Console.ReadLine();

        using (new RunningBunnyGame().Run()) { }
    }
}