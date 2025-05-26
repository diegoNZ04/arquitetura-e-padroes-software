namespace solid.ISP.Good;

public interface IEmployee
{
    string Name { get; set; }
}

public interface ISalaryCalculator
{
    void CalculateSalary();
}

public interface IBenefitsCalculator
{
    string Name { get; set; }
    void CalculateBenefits();
}

public class FullTimeEmployee : IEmployee, ISalaryCalculator, IBenefitsCalculator
{
    public string Name { get; set; } = null!;

    public void CalculateBenefits()
    {
        Console.WriteLine("Contract benefits.");
    }

    public void CalculateSalary()
    {
        Console.WriteLine("Contract salary.");
    }
}

public class ContractEmployee : IEmployee, ISalaryCalculator
{
    public string Name { get; set; } = null!;

    public void CalculateSalary()
    {
        Console.WriteLine("Contract salary.");
    }
}
