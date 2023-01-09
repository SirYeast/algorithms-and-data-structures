Console.WriteLine("Please enter a number:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Please enter {n} words:");
string[] words = new string[n];
int wordCount = 0;

while (wordCount < n)
{
    string? word = Console.ReadLine();

    if (string.IsNullOrEmpty(word))
    {
        Console.WriteLine("No word entered, please enter a word:");
    }
    else if (word.Contains(' '))
    {
        Console.WriteLine("The word contains a space, please enter another word:");
    }
    else
    {
        words[wordCount] = word.ToLower();
        wordCount++;
    }
}

Console.WriteLine();
Console.WriteLine("Please enter a character:");

char character;

while (true)
{
    character = char.ToLower(Console.ReadKey().KeyChar);

    if (!char.IsLetter(character))
    {
        Console.WriteLine("\nPlease enter a letter:");
    }
    else
    {
        break;
    }
}

int charCount = 0;
int charOccurences = 0;

foreach (string word in words)
{
    foreach (char c in word)
    {
        if (character == c)
        {
            charOccurences++;
        }

        charCount++;
    }
}

Console.WriteLine();
Console.Write($"The letter '{character}' appears {charOccurences} times in the array.");

if ((double)charOccurences / charCount > 0.25)
{
    Console.Write(" This letter makes up more than 25% of the total number of characters.");
}