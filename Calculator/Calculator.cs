


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


    public IOperator GetOperator(string op)
    {
        return _operators[op];
    }

    public bool IsOperator(string op) => _operators.ContainsKey(op);

    public double Run(string op, double i, double j)
    {
        if (!_operators.ContainsKey(op))
            throw new InvalidOperationException($"Invalid operation: '{op}'");



        return GetOperator(op).Calculate(i, j);
    }
}