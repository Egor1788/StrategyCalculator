


public class Calculator
{
    private readonly Dictionary<string, IOperator> _operators;
    public Calculator()
    {
        _operators = new Dictionary<string, IOperator>
            {
                { "+", new PlusOperator() },
                { "-", new MinusOperator() },
                { "*", new MultiplicationOperator() },
                { "/", new DivideOperator() },
            };
    }
    public double Run(string op, double i, double j)
    {
        if (!_operators.ContainsKey(op))
            throw new InvalidOperationException($"Invalid operation: '{op}'");

        return _operators[op].Calculate(i, j);
    }
}