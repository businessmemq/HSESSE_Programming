using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        Random rnd = new Random();
        for (int i = 0; i < n; ++i) {
            a[i] = int.Parse(Console.ReadLine());
        }
        foreach (int x in a) {
            System.Console.WriteLine(x);
        }
    }
}
