using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        Random rnd = new Random();
        for (int i = 0; i < n; ++i) {
            a[i] = rnd.Next(1, 6);
        }
        System.Console.Write("A =\t");
        for (int i = 0; i < n; ++i) {
            System.Console.Write(a[i] + " ");
        }
        System.Console.WriteLine();
        bool[] used = new bool[n];
        for (int i = 0; i < n; ++i) {
            if (!used[a[i]]) {
                used[a[i]] = true;
            }
            else {
                a[i] = 0;
            }
        }
        System.Console.Write("modA =\t");
        for (int i = 0; i < n; ++i) {
            System.Console.Write(a[i] + " ");
        }
        System.Console.WriteLine();
    }
}
