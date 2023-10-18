class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        string[] words = s.Split(" ");
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i][0] >= 'a' && words[i][0] <= 'z' || words[i][0] >= 'A' && words[i][0] <= 'Z')
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
