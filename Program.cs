class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Number of term first polynomial");
        int n = int.Parse(Console.ReadLine());
        Polynomial poly1 = new()
        {
            N = n,
            term = new Term[n]
        };
        poly1.Create();
        poly1.Display();
        System.Console.WriteLine();
        System.Console.WriteLine("Enter second polynomials");
        System.Console.WriteLine("Number of term second polynomial");
        n = int.Parse(Console.ReadLine());
        Polynomial poly2 = new()
        {
            N = n,
            term = new Term[n]
        }, poly3 = new();
        System.Console.WriteLine("Enter second polynomials");
        poly2.Create();
        poly2.Display();
        System.Console.WriteLine();
        System.Console.WriteLine("Sum of polynomial: ");
        poly3 = poly3.Addition(poly1, poly2);
        poly3.Display();
    }
}