using System;
using System.Security.Authentication;
using System.Text;
class Program
{
    static void Main()
    {
        string path = "C:\\..\\..\\" + Console.ReadLine();
        string[] sRead = File.ReadAllLines(path);
        int it = 1;
        bool ok = false;
        foreach (string s in sRead)
        {
            if (s.Contains("ABCD"))
            {
                Console.WriteLine($"ABCD найдено в {it}-ой строке");
                ok = true;
            }
            ++it;
        }
        if (!ok)
        {
            Console.WriteLine("ABCD не найдено");
        }
    }
}
