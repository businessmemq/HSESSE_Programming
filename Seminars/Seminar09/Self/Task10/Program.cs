using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int A = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; ++i) {
            a[i] = A + D * i;
        }
        for (int i = 0; i < n; ++i) {
            System.Console.Write(a[i] + " ");
        }
    }
}
