public class Triangle
{
    public static void Main(string[] args)
    {
        double baseLength = 5.0;
        double height = 8.0;
        double area = TriangleArea(baseLength, height);
        Console.WriteLine("Triangle area: " + area);
    }

    public static double TriangleArea(double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }
}
