Console.WriteLine("Please enter a number:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"\nPlease enter {n} words:");
string[] words = new string[n];
int wordCount = 0;

while (wordCount < n)
{
    Console.Write($"{wordCount + 1}) ");
    string? word = Console.ReadLine();

    if (string.IsNullOrEmpty(word))
    {
        Console.WriteLine("\nNo word entered, please enter a word:");
    }
    else if (word.Contains(' '))
    {
        Console.WriteLine("\nThat word contains a space, please enter another word:");
    }
    else
    {
        words[wordCount] = word.ToLower();
        wordCount++;
    }
}

Console.WriteLine("\nPlease enter a letter:");
char character;

while (true)
{
    character = char.ToLower(Console.ReadKey().KeyChar);

    if (!char.IsLetter(character))
    {
        Console.WriteLine("\n\nPlease enter a letter (no numbers or symbols):");
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

Console.Write($"\n\nThe letter '{character}' appears {charOccurences} times in the array.");

if ((double)charOccurences / charCount > 0.25)
{
    Console.Write(" This letter makes up more than 25% of the total number of characters.");
}