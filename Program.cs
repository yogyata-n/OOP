using lab_3;

internal class Program
{
    private static void Main(string[] args)
    {

        MathOperations Op = new MathOperations();
        int add = Op.Add(6, 7);
        double ad = Op.Add(10.08, 10.466);
        int subtract = Op.Sub(9, 7);
        double su = Op.Sub(15.08, 10.466);
        int product = Op.Multiply(8, 2);
        double pro = Op.Multiply(15.05, 20.15);
        int divide = Op.Div(6, 2);
        double div = Op.Div(10, 2.5);
        Console.WriteLine("Int type add:" + add);
        Console.WriteLine("Doubleint type add:" + ad);
        Console.WriteLine("Int type subtract:" + subtract);
        Console.WriteLine("Doubleint type subtract:" + su);
        Console.WriteLine("Int type multiply:" + product);
        Console.WriteLine("Doubleint type multiply:" + pro);
        Console.WriteLine("Int type divide:" + divide);
        Console.WriteLine("Doubleint type divide:" + div);

        Console.ReadKey();
        Console.Clear();

        MathOperation inheritance = new MathOperation();
        double sum = inheritance.Add(7.5, 9);
        double sub = inheritance.Subtract(3.5, 3);
        double mul = inheritance.Multiply(5, 3.5);
        double di = inheritance.Divide(55, 5.5);
        Console.WriteLine($"Add = {sum}, Subtract = {sub}, Multiply = {mul}, Divide = {di}");

        Console.ReadKey();
        Console.Clear();

        Palindrome Pal = new Palindrome();
        Pal.checkPalindrome();

        Console.ReadKey();
        Console.Clear();



    }
}
