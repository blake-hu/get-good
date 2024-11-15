using VisitorPattern.Interface;

namespace VisitorPattern.Drink;

public class MilkTea : IDrink
{
    public MilkTea()
    {
        Recipe = new List<string> { "Milk Tea Recipe" };
    }

    public IList<string> Recipe { get; set; }

    public void Accept(IVisitDrinks visitor)
    {
        visitor.Visit(this);
    }
}