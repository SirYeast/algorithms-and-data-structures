// 1. Complexity is O(n)
static char[] GetRepeatingChars(string input)
{
    input = input.ToLower();

    List<char> chars = new();

    for (int i = 0; i < input.Length; i++)
    {
        int lastIndex = input.LastIndexOf(input[i]);

        if (lastIndex != -1 && i != lastIndex)
        {
            chars.Add(input[i]);
        }
    }

    return chars.ToArray();
}

// 2. Complexity is O(n)
static string[] GetUniqueWords(string input)
{
    string[] words = input.ToLower().Split(' ');

    List<string> uniqueWords = new();

    foreach (string word in words)
    {
        if (uniqueWords.IndexOf(word) == -1)
        {
            uniqueWords.Add(word);
        }
    }

    return uniqueWords.ToArray();
}

// 3. Complexity is O(log n)
static string ReverseString(string input)
{
    char[] chars = input.ToCharArray();

    for (int i = 0; i < chars.Length / 2; i++)
    {
        (chars[i], chars[^(i + 1)]) = (chars[^(i + 1)], chars[i]);
    }

    return new string(chars);
}

// 4. Complexity is O(n)
static string FindLongestWord(string input)
{
    string[] words = input.Split(' ');

    int longestWordIndex = 0;

    for (int i = 1; i < words.Length; i++)
    {
        if (words[i].Length >= words[longestWordIndex].Length)
        {
            longestWordIndex = i;
        }
    }

    return words[longestWordIndex];
}

Console.Write("Enter a string: ");
Console.WriteLine($"Repeating characters: {string.Join(',', GetRepeatingChars(Console.ReadLine()))}");

Console.Write("\nEnter a sentence: ");
Console.WriteLine($"Unqiue words: {string.Join(' ', GetUniqueWords(Console.ReadLine()))}");

Console.Write("\nEnter a string: ");
Console.WriteLine($"Reversed string: {ReverseString(Console.ReadLine())}");

Console.Write("\nEnter a sentence: ");
Console.WriteLine($"Longest word: {FindLongestWord(Console.ReadLine())}");