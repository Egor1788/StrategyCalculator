class CalculatorWrapper
{
    private Calculator _calculator = new();

    public double Evaluate(string exp)
    {
        var tokens = Tokenize(exp);
        return EvaluatePostfix(InfixToPostfix(tokens));
    }

    List<string> Tokenize(string expression) =>
        expression.Replace(" ", "").ToCharArray()
                  .Select(c => c.ToString())
                  .ToList();

    List<string> InfixToPostfix(List<string> infix)
    {
        var postfix = new List<string>();
        var stack = new Stack<string>();

        foreach (var token in infix)
        {
            if (double.TryParse(token, out _))
                postfix.Add(token);
            else if (_calculator.IsOperator(token))
            {
                while (stack.Count > 0 && _calculator.IsOperator(stack.Peek()) && _calculator.GetOperator(token).GetPrecedence() <= _calculator.GetOperator(stack.Peek()).GetPrecedence())
                    postfix.Add(stack.Pop());
                stack.Push(token);
            }
        }

        while (stack.Count > 0)
            postfix.Add(stack.Pop());

        return postfix;
    }

    double EvaluatePostfix(List<string> postfix)
    {
        var stack = new Stack<double>();
        foreach (var token in postfix)
        {
            if (double.TryParse(token, out double num))
                stack.Push(num);
            else if (_calculator.IsOperator(token))
            {
                double y = stack.Pop(), x = stack.Pop();
                stack.Push(_calculator.Run(token, x, y));
            }
        }
        return stack.Pop();
    }
}
