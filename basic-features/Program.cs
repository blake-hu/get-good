var names = new List<string> {"Allen"};
names.Add("Blake");
names.Add("Diane");

// iterating using foreach loop
foreach (var name in names)
{
    Console.WriteLine(name);
}

// iterating using for loop 
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

interface IRenderable
{
    public int Render(object gameObject);
}

interface IGameObject
{
    public int Collide(object gameObject);
}

class Monster : IRenderable, IGameObject
{
    public int Render(object gameObject)
    {
        return 1;
    }
    public int Collide(object gameObject)
    {
        return 1;
    }
}
