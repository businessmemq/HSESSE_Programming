using System;
class Program
{
    static void Main()
    {
        int[][] a = new int[7][];
        for (int i = 0; i < 7; ++i) {
            a[i] = new int[7 - i];
            for (int j = 0; j < 7 - i; ++j) {
                a[i][j] = i + 1;
            }
        }
        for (int i = 0; i < 7; ++i) {
            for (int j = 0; j < i; ++j) {
                System.Console.Write("  ");
            }
            for (int j = 0; j < 7 - i; ++j) {
                System.Console.Write(a[i][j] + " ");
            }
            System.Console.WriteLine();
        }
    }
}
