namespace design_patterns_console.UML.Examples;

public abstract class Animal
{
    protected abstract string MakeNoise();

    public void MakeSound()
    {
        Console.WriteLine(this.MakeNoise());
    }
}

public class Dog : Animal
{
    protected override string MakeNoise()
    {
        return "Woof!";
    }
}
