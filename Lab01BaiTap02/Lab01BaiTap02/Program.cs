using System.Text;
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;
Console.WriteLine("GIẢI PHƯƠNG TRÌNH BẬC 2");
Console.WriteLine("A.X^2 + B.X + X = 0");
double A, B, C;

try
{
    Console.Write("Hệ số A: ");
    A = double.Parse(Console.ReadLine());
    Console.Write("Hệ số B: ");
    B = double.Parse(Console.ReadLine());
    Console.Write("Hệ số C: ");
    C = double.Parse(Console.ReadLine());
    double delta = Math.Pow(B, 2) - 4 * A * C;

    if (delta < 0)
    {
        Console.WriteLine("Phương trình vô nghiệm");
    }
    else if (delta == 0)
    {
        Console.WriteLine($"PT có nghiệm kép: x = {-B / (2 * A)}");
    }
    else
    {
        double x1 = (-B - Math.Sqrt(delta) / (2 * A));
        double x2 = (-B + Math.Sqrt(delta) / (2 * A));
        Console.WriteLine($"PT có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Lỗi: {ex.Message}");
}