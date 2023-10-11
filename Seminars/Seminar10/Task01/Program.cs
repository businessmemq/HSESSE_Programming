using System;
class Program
{
    static void Fill_Array(double[] a) {
        Random rnd = new Random();
        for (int i = 0; i < a.Length; ++i) {
            a[i] = rnd.NextDouble() * 24.5 - 12.25;
        }
    }
    static void Print_Array(double[] a) {
        for (int i = 0; i < a.Length; ++i) {
            System.Console.WriteLine("{0:F2}", a[i]);
        }
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double[] a = new double[n];
        Fill_Array(a);
        Print_Array(a);
    }
}
