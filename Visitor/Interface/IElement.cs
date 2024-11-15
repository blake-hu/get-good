namespace VisitorPattern.Interface;

public interface IElement
{
    public void Accept(IVisitDrinks visitor);
}