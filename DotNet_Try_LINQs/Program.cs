using DotNet_Try_LINQs;

internal class Program
{
    private static void Main(string[] args)
    {
        Restriction_Operators restriction_Operators = new Restriction_Operators();
        //restriction_Operators.Test03();

        Projection_Operators projection_Operators = new Projection_Operators();
        projection_Operators.selectClause();

        Console.ReadLine();
    }
}