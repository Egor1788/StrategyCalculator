public class DivideOperator : IOperator
{
    public double Calculate(double x, double y)
    {
        if (y == 0)
        {
            throw new DivideByZeroException();
        }
        return x / y;
    }
}
