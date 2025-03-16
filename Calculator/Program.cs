
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an example:");
        string[] parts = Console.ReadLine().Split(" ");
        if (parts.Length != 3)
        {
            throw new Exception("Invalid input!");
        }
        Calculator calculator = new Calculator();
        double result = calculator.Run(parts[1], Convert.ToDouble(parts[0]), Convert.ToDouble(parts[2]));
        Console.WriteLine($"Result: {result}");
    }
}