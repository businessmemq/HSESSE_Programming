class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        string[] words = s.Split(" ");
        for (int i = 0; i < words.Length; i++)
        {
            for (int j = i + 1; j < words.Length; j++)
            {
                if (words[i].Length > words[j].Length)
                {
                    (words[i], words[j]) = (words[j], words[i]);
                }
            }
        }
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}
