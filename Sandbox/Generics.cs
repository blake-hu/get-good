namespace Sandbox;

public class Generics : IRun
{
    public string GetName()
    {
        return "Extension Class example";
    }

    public void Run()
    {
        var myList = new List<string> { "Blake", "Diane", "Allen" };

        var copiedList = ListExtension.CopyList(myList);

        foreach (var elem in copiedList)
            Console.WriteLine(elem);
    }
}

internal static class ListExtension
{
    // Generic type binding occurrence happens in CopyList<T>
    // Bound occurrences which reference generic type T:
    // - List<T> return type
    // - List<T> parameter
    public static List<T> CopyList<T>(List<T> from)
    {
        var to = new List<T>();
        foreach (var elem in from) to.Add(elem);
        return to;
    }
}