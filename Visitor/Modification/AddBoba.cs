using VisitorPattern.Drink;
using VisitorPattern.Interface;

namespace Visitor.Modification;

public class AddBoba : IVisitDrinks
{
    public void Visit(MilkTea milkTea)
    {
        milkTea.Recipe.Add("Adding Boba to Milk Tea: Delicious!");
    }

    public void Visit(FruitTea fruitTea)
    {
        fruitTea.Recipe.Add("Adding Boba to Fruit Tea: Yuck!");
    }
}