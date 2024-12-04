namespace Sandbox;

public class UnityExample : IRun
{
    public string GetName()
    {
        return "Unity example";
    }

    public void Run()
    {
    }
}

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