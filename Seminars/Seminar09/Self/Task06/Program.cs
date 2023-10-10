using System;
using System.Runtime.InteropServices;
class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        int ids = 0, idf = 0;
        for (int i = 0; i < s.Length; ++i) {
            if (s[i] == '(') {
                ids = i;
            }
            if (s[i] == ')') {
                idf = i;
            }
        }
        int kol = idf - ids - 1;
        System.Console.WriteLine($"Количество символов = {kol}");
        for (int i = ids + 1; i < idf; ++i) {
            System.Console.Write(s[i]);
        }
    }
}
