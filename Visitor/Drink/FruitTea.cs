using VisitorPattern.Interface;

namespace VisitorPattern.Drink;

public class FruitTea : IDrink
{
    public FruitTea()
    {
        Recipe = new List<string> { "Fruit Tea Recipe" };
    }

    public IList<string> Recipe { get; set; }

    public void Accept(IVisitDrinks visitor)
    {
        visitor.Visit(this);
    }
}