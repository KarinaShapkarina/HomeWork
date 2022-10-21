Console.WriteLine("Введи коэффициенты:");
double b1 =Convert.ToDouble(Console.ReadLine());
double k1 =Convert.ToDouble(Console.ReadLine());
double b2 =Convert.ToDouble(Console.ReadLine());
double k2 =Convert.ToDouble(Console.ReadLine());
double x = 0;
double y = 0;

void pointIntersection(double x, double y)
{
    y = k1 * x + b1;
    y = k2 * x + b2;
    x = (b1 - b2) / -(k1 - k2);
    y = k2 * x + b2;
    Console.WriteLine($"({x}; {y})");
}

pointIntersection(x, y);