using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] a = new int[n, n];
        for (int i = 0; i < n; ++i) {
            for (int j = 0; j < n; ++j) {
                a[i,j] = (i + j) % n + 1;
            }
        }
        for (int i = 0; i < n; ++i) {
            for (int j = 0; j < n; ++j) {
                System.Console.Write(a[i, j] + " ");
            }
            System.Console.WriteLine();
        }
    }
}
