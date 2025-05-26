namespace design_patterns_console.Builder.Interfaces;

public interface IMealBuilder
{
    IMealBuilder MakeMeal();
    IMealBuilder MakeBeverage();
    IMealBuilder MakeDessert();
}