using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n], b = new int[n], c = new int[n];
        Random rnd = new Random();
        for (int i = 0; i < n; ++i) {
            a[i] = rnd.Next(-2, 8);
        }
        int idb = 0, idc = 0;
        for (int i = 0; i < n; ++i) {
            if (a[i] % 2 == 0) {
                Array.Copy(a, i, b, idb, 1);
                ++idb;
            }
            else {
                Array.Copy(a, i, c, idc, 1);
                ++idc;
            }
        }
        System.Console.Write("B = ");
        for (int i = 0; i < b.Length; ++i) {
            System.Console.Write(b[i] + " ");
        }
        System.Console.WriteLine();
        System.Console.Write("C = ");
        for (int i = 0; i < c.Length; ++i) {
            System.Console.Write(c[i] + " ");
        }
    }
}
