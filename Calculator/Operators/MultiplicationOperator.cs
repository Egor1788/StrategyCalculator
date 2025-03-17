public class MultiplicationOperator : IOperator
{
    public int GetPrecedence() => 1;
    public double Calculate(double x, double y)
    {
        return x * y;
    }
}
