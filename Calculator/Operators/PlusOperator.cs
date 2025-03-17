public class PlusOperator : IOperator
{
    public double Calculate(double x, double y)
    {
        return x + y;
    }
    public int GetPrecedence() => 0;
}
