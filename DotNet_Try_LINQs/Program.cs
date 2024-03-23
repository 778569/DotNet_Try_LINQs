internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        var lowNums = from num in numbers
                      where num < 5
                      select num;

        var MethodSyntax = numbers.Where(x => x < 5);

        Console.WriteLine("Numbers < 5:");
        foreach (var x in lowNums)
        {
            Console.WriteLine(x);
        }
        Console.WriteLine();
        foreach (var x in MethodSyntax)
        {
            Console.WriteLine(x);
        }
    }
}