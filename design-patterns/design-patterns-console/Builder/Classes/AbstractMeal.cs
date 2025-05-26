using design_patterns_console.Builder.Interfaces;

namespace design_patterns_console.Builder.Classes;

public abstract class AbstractMeal : IMealComposite
{
    private string _name;
    private int _price;
    public AbstractMeal(string name, int price)
    {
        _name = name;
        _price = price;
    }
    public int GetPrice()
    {
        return _price;
    }
}
