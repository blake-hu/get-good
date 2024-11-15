namespace VisitorPattern.Interface;

public interface IDrink : IElement
{
    IList<string> Recipe { get; set; }
}