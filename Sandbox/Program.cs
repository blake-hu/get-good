namespace Sandbox;

public class Program
{
    private static readonly IEnumerable<IRun> Examples =
    [
        new Yield(),
        new UnityExample(),
        new Generics()
    ];

    internal static void Main(string[] args)
    {
        foreach (var example in Examples)
        {
            Console.WriteLine();
            Console.WriteLine(example.GetName());
            example.Run();
        }
    }
}