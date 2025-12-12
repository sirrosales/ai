namespace SourceAi.Demo;

public static class Program
{
    [Ai]
    static extern int Sum(int a, int b);

    [Ai("Prints all numbers 1..n")]
    static extern void MyMethod(int n);
    
    public static void Main(string[] args)
    {
        Console.WriteLine($"10+5={Sum(10, 5)}");  
        MyMethod(10);
    }
}