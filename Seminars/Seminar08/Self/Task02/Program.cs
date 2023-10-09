using System;
class Program
{
    public static bool Triangle(double x, double y, double z, out double p, out double s) {
        if (Math.Max(Math.Max(x, y), z) >= x + y + z - Math.Max(Math.Max(x, y), z)) {
            p = 0;
            s = 0;
            return false;
        }
        p = x + y + z;
        s = Math.Sqrt(p / 2 * (p / 2 - x) * (p / 2 - y) * (p / 2 - z));
        return true;
    }
    static void Main() {
        double x = Double.Parse(Console.ReadLine());
        double y = Double.Parse(Console.ReadLine());
        double z = Double.Parse(Console.ReadLine());
        double p = 0, s = 0;
        if (Triangle(x, y, z, out p, out s)) {
            System.Console.WriteLine($"Периметр = {p}\nПлощадь = {s}");
        }
        else {
            System.Console.WriteLine("Такого треугольника не существует");
        }
    }
}
