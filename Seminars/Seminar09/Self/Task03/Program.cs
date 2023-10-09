using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        Random rnd = new Random();
        for (int i = 0; i < n; ++i) {
            a[i] = rnd.Next(-2, 8);
        }
        Array.Sort(a, 0, a.Length);
        Array.Reverse(a, 0, a.Length);
        foreach (int x in a) {
            System.Console.WriteLine(x);
        }
    }
}
