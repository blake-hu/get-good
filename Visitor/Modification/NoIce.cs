using VisitorPattern.Drink;
using VisitorPattern.Interface;

namespace Visitor.Modification;

public class NoIce : IVisitDrinks
{
    public void Visit(MilkTea milkTea)
    {
        milkTea.Recipe.Add("Removing all ice from Milk Tea: Good choice!");
    }

    public void Visit(FruitTea fruitTea)
    {
        fruitTea.Recipe.Add("Removing all ice from Fruit Tea: Maybe reconsider? Ice is nice with fruit!");
    }
}