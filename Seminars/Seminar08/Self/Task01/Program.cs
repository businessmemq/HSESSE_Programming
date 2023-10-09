using System;
class Program
{
    static double PIBeyly(out int it) {
        double res = 0, newres = 0;
        int i = 0;
        do {
            res = newres;
            newres = res + Math.Pow(16, -i) * (4.0 / (8 * i + 1) - 2.0 / (8 * i + 4) - 1.0 / (8 * i + 5) - 1.0 / (8 * i + 6));
            ++i;
        }
        while (Math.Abs(newres - res) > Double.Epsilon);
        it = i;
        return res;
    }
    static double PIRyad(out int it) {
        double res = 0, newres = 0, cnt = 0;
        int k = 1;
        do {
            res = newres;
            cnt += 1d / k;
            newres += 1 / Math.Pow(k + 1, 3) * cnt;
            ++k;
        }
        while (Math.Abs(newres - res) > Double.Epsilon);
        it = k;
        res = Math.Pow(res * 360, 1d / 4);
        return res;
    }
    static void Main()
    {
        do {
            System.Console.Write("Метод вычислениия PI (1 - Бэйли-Боруэйна-Плафф, 2 - кратные ряды): ");
            int type = int.Parse(Console.ReadLine()), it = 0;
            double PI = 0;
            if (type == 1) {
                PI = PIBeyly(out it);
            }
            else {
                PI = PIRyad(out it);
            }
            System.Console.WriteLine($"PI = {PI}\nКоличество итераций = {it}");
            System.Console.WriteLine("Escape - выход\nПродолжить - любая клавиша");
        }
        while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
}
