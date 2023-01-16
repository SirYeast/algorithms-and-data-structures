// 1.
List<int> nums = new() { 1, 2, 3, 4, 5, 7, 9, 2, 4 };
List<int> repeatingNums = new();

for (int i = 0; i < nums.Count; i++)
{
    int lastIndex = nums.LastIndexOf(nums[i]);

    if (lastIndex != -1 && i != lastIndex)
    {
        repeatingNums.Add(nums[i]);
    }
}

Console.WriteLine(string.Join(',', repeatingNums));

// 2.
int[] first = { 1, 2, 3, 4, 6, 7, 10 };
int[] second = { 2, 5, 8, 9, 9, 11 };
int[] merged = new int[first.Length + second.Length];

int j = 0;
int k = 0;
int l = 0;

while (j < first.Length && k < second.Length)
{
    merged[l++] = first[j] < second[k] ? first[j++] : second[k++];
}

while (j < first.Length)
{
    merged[l++] = first[j++];
}

while (k < second.Length)
{
    merged[l++] = second[k++];
}

Console.WriteLine(string.Join(',', merged));

// 3. Complexity is O(n)
int input = 1234;
int reverse = 0;

while (input != 0)
{
    reverse = (reverse * 10) + input % 10;
    input /= 10;
}

Console.WriteLine($"Reverse number: {reverse}");