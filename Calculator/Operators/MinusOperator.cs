public class MinusOperator : IOperator
{

    public int GetPrecedence() => 0;
    public double Calculate(double x, double y)
    {
        return x - y;
    }
}
