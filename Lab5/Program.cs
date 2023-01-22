// Complexity is O(1)

Queue<string> playlist = new();
Stack<string> history = new();

while (true)
{
    Console.WriteLine("1. Add a song to your playlist");
    Console.WriteLine("2. Play the next song in your playlist");
    Console.WriteLine("3. Skip the next song");
    Console.WriteLine("4. Rewind one song");
    Console.WriteLine("5. Exit");

    char c = Console.ReadKey().KeyChar;

    if (char.IsNumber(c))
    {
        int action = c - '0';
        Console.WriteLine('\n');

        switch (action)
        {
            case 1:
                Console.WriteLine("Enter song name:");
                string? song = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(song))
                {
                    playlist.Enqueue(song);
                    Console.WriteLine($"\"{song}\" has been added to your playlist");
                    Console.WriteLine($"Next song: {playlist.Peek()}");
                }
                break;
            case 2:
                if (playlist.Count > 0)
                {
                    string newSong = playlist.Dequeue();
                    string nextSong = playlist.Count > 0 ? playlist.Peek() : "none queued";

                    history.Push(newSong);

                    Console.WriteLine($"Now playing: {newSong}");
                    Console.WriteLine($"Next song: {nextSong}");
                }
                else
                {
                    Console.WriteLine("There are no songs in your playlist");
                }
                break;
            case 3:
                if (playlist.Count > 0)
                {
                    playlist.Dequeue();
                    string nextSong = playlist.Count > 0 ? playlist.Peek() : "none queued";

                    Console.WriteLine($"Now playing: {history.Peek()}");
                    Console.WriteLine($"Next song: {nextSong}");
                }
                else
                {
                    Console.WriteLine("There are no songs in your playlist");
                }
                break;
            case 4:
                playlist.Enqueue(history.Pop());

                Console.WriteLine($"Now playing: {history.Peek()}");
                break;
            case 5:
                Environment.Exit(0);
                break;
        }

        Console.WriteLine();
    }
    else
    {
        Console.Clear();
    }
}