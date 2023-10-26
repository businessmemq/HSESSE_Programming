using System.Text;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        int b = 0;
        bool ok = true;
        foreach (char c in s)
        {
            if (c == '(')
            {
                ++b;
            }
            else if (c == ')')
            {
                --b;
            }
            if (b < 0)
            {
                ok = false;
                Console.WriteLine("Есть закрывающаяся скобка без парной для нее открывающейся.");
                break;
            }
        }
        if (b != 0)
        {
            ok = false;
        }
        if (ok)
        {
            Console.WriteLine("Баланс скобок соблюден.");
        }
        else
        {
            Console.WriteLine("Баланс скобок не соблюден.");
        }
    }
}
