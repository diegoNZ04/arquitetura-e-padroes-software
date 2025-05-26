
using design_patterns_console.Builder.Interfaces;

namespace design_patterns_console.Builder.Classes;

public class MealBox : IMealComposite
{
    private readonly List<IMealComposite> _children;
    public int GetPrice()
    {
        return _children.Sum(child => child.GetPrice());
    }
    public void AddMeal(params IMealComposite[] meals)
    {
        meals.ToList().ForEach(meal => _children.Add(meal));
    }
}

/*
var rice = new Rice('Arroz', 5);
var beans = new Beans('Feijão', 10);
var meat = new Meat('Carne', 20);
var mealBox = new MealBox();
mealBox.AddMeal(rice, beans, meat);
Console.WriteLine(mealBox.GetPrice());
*/