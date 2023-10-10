using System;
class Program
{
    static void Main()
    {
        int[] a = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
        int [] b = new int[10];
        Random rnd = new Random();
        for (int i = 0; i < b.Length; ++i) {
            b[i] = rnd.Next(-12, 15);
        }
        int cnt = 0;
        System.Console.Write("A = ");
        for (int i = 0; i < a.Length; ++i) {
            System.Console.Write(a[i] + " ");
            if (a[i] % 2 == 0) {
                ++cnt;
            }
        }
        System.Console.WriteLine();
        System.Console.Write("B = ");
        for (int i = 0; i < b.Length; ++i) {
            System.Console.Write(b[i] + " ");
        }
        System.Console.WriteLine();
        int[] c = new int[b.Length + cnt];
        Array.Copy(b, 0, c, 0, b.Length);
        int idc = b.Length;
        for (int i = 0; i < a.Length; ++i) {
            if (a[i] % 2 == 0) {
                c[idc] = a[i];
                ++idc;
            }
        }
        Console.Write("C = ");
        for (int i = 0; i < c.Length; ++i) {
            Console.Write(c[i] + " ");
        }
    }
}
