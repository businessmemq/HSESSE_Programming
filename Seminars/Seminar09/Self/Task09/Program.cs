using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; ++i) {
            a[i] = i * 2 + 1;
        }
        for (int i = 0; i < n; ++i) {
            System.Console.Write(a[i] + " ");
        }
    }
}
