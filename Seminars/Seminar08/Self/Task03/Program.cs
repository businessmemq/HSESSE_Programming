using System;
class Program
{
    static bool f(ref char c, int x) {
        char beg = '1';
        int sdvig = 0;
        if (c >= 'a' && c <= 'z') {
            beg = 'a';
            sdvig = (c - beg + x + 26 * 1000) % 26;
        }
        else if (c >= 'A' && c <= 'Z') {
            beg = 'A';
            sdvig = (c - beg + x + 26 * 1000) % 26;
        }
        else if (c >= 'а' && c <= 'я') {
            beg = 'а';
            sdvig = (c - beg + x + 32 * 1000) % 32;
        }
        else if (c >= 'А' && c <= 'Я') {
            beg = 'А';
            sdvig = (c - beg + x + 32 * 1000) % 32;
        }
        else {
            return false;
        }
        c = Convert.ToChar(beg + sdvig);
        if (c > 'е' && c <= 'я' || c > 'Е' && c <= 'Я') {
            c--;
        }
        return true;
    }
    static void Main()
    {
        string s = Console.ReadLine();
        int sdvig = int.Parse(Console.ReadLine());
        char c = s[0];
        if (f(ref c, sdvig)) {
            System.Console.WriteLine(c);
        }
        else {
            System.Console.WriteLine("wrong input");
        }
    }
}
