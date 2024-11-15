using VisitorPattern.Drink;

namespace VisitorPattern.Interface;

public interface IVisitDrinks
{
    public void Visit(MilkTea milkTea);

    public void Visit(FruitTea fruitTea);
}