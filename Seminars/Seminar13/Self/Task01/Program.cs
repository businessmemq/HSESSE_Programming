class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        string[] words = s.Split(" ");
        words = words.Distinct().ToArray();
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}
