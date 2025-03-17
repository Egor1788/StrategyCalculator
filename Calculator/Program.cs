



internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an example:");
        string inp = Console.ReadLine();


        var wrapper = new CalculatorWrapper(); 

        double result = wrapper.Evaluate(inp);
        Console.WriteLine($"Result: {result}");
    }
}