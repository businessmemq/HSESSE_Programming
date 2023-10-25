using System.Text;

class Program
{
    static void ArrPrint(string[] arr)
    {
        foreach (string str in arr)
        {
            Console.WriteLine(str);
        }
    }
    static void Main()
    {
        string s = Console.ReadLine();
        string[] words = s.Split();
        for (int i  = 0; i < words.Length; i++)
        {
            for (int j = 0; j < words[i].Length; j++)
            {
                if (words[i][j] == '7')
                {
                    words[i] = words[i].Remove(j, 1);
                }
            }
        }
        ArrPrint(words);
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i].Insert(0, "222");
        }
        ArrPrint(words);
        for (int i = 0;i < words.Length; i++)
        {
            words[i] = words[i].Insert(words[i].Length, "5");
        }
        ArrPrint(words);
    }
}
