using System.Text;

class Program
{
    static void Main()
    {
        char[] sep = " qwertyuiopasdfghjklzxcvbnmйцукенгшщзхъфывапролджэячсмитьбю".ToCharArray();
        string s = Console.ReadLine();
        string[] words = s.Split(sep, StringSplitOptions.RemoveEmptyEntries);
        int mx = 0;
        foreach (string word in words)
        {
            if (int.Parse(word) > mx)
            {
                mx = int.Parse(word);
            }
        }
        Console.WriteLine(mx);
    }
}
