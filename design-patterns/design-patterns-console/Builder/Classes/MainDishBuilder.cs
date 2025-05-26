using design_patterns_console.Builder.Interfaces;

namespace design_patterns_console.Builder.Classes;

public class MainDishBuilder : IMealBuilder
{
    private MealBox _mealBox = new MealBox();
    public MainDishBuilder(MealBox mealBox)
    {
        _mealBox = mealBox;
    }
    public IMealBuilder MakeBeverage()
    {
        var beverage = new Beverage("Bebida", 7);
        _mealBox.AddMeal(beverage);
        return this;
    }

    public IMealBuilder MakeDessert()
    {
        var dessert = new Dessert("Sobremesa", 7);
        _mealBox.AddMeal(dessert);
        return this;
    }

    public IMealBuilder MakeMeal()
    {
        var rice = new Rice("Arroz", 5);
        var beans = new Beans("Feijão", 10);
        var meat = new Meat("Carne", 20);
        _mealBox.AddMeal(rice, beans, meat);
        return this;
    }

    public MealBox GetMealBox()
    {
        return _mealBox;
    }

    public int GetPrice()
    {
        return _mealBox.GetPrice();
    }
}

/*
    var mainDishBuilder = new MainDishBuilder();
    mainDishBuilder
        .MakeMeal()
        .MakeBeverage()
        .MakeDessert();
    Console.WriteLine(mainDishBuilder.GetMealBox());
    Console.WriteLine(mainDishBuilder.GetPrice());
*/