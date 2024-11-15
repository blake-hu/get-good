// Problem: Mr Hu wants to start selling boba at his restaurant.
// - There are many types of boba drinks
// - Each drink can have many modifications: toppings, ice level, sugar level, etc
// - How can we design software that matches drinks to modifications in an extensible way?
//
// Solution: This is a classic double dispatch problem, so we use the Visitor pattern.
// - All Drinks inherit from the Element interface, which declares Accept() method
// - All modifications inherit from the Visitor interface, which declares the Visit() method

using Visitor.Modification;
using VisitorPattern.Drink;
using VisitorPattern.Interface;

namespace Visitor;

internal class Program
{
    private static void Main(string[] args)
    {
        var drinks = new List<IDrink> { new FruitTea(), new MilkTea() };
        var mods = new List<IVisitDrinks> { new AddBoba(), new NoIce() };

        foreach (var drink in drinks)
        foreach (var mod in mods)
            drink.Accept(mod);

        foreach (var drink in drinks)
        {
            foreach (var step in drink.Recipe)
                Console.WriteLine(step);
            Console.WriteLine();
        }
    }
}