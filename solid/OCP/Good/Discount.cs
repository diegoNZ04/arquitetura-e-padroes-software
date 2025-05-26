namespace solid.OCP.Good;

public abstract class Discount
{
    public abstract decimal Calculate(decimal price);
}

public class EletronicsDiscount : Discount
{
    public override decimal Calculate(decimal price)
        => price * 0.2M;
}

public class HealthDiscount : Discount
{
    public override decimal Calculate(decimal price)
        => price * 0.5M;
}

public class BeautyDiscount : Discount
{
    public override decimal Calculate(decimal price)
        => price * 0.5M;
}

public class FashionDiscount : Discount
{
    public override decimal Calculate(decimal price)
        => price * 0.5M;
}
