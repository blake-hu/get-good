var myList = new List<string> { "Blake", "Diane", "Allen" };

var copiedList = ListExtension.CopyList(myList);

foreach (var elem in copiedList) Console.WriteLine(elem);

internal interface IRenderable
{
    public int Render(object gameObject);
}

internal interface IGameObject
{
    public int Collide(object gameObject);
}

internal class Monster : IRenderable, IGameObject
{
    public int Collide(object gameObject)
    {
        return 1;
    }

    public int Render(object gameObject)
    {
        return 1;
    }
}

internal class ListExtension
{
    public static List<T> CopyList<T>(List<T> from)
    {
        var to = new List<T>();
        foreach (var elem in from) to.Add(elem);
        return to;
    }
}