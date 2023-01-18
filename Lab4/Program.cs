// 1. Complexity is O(n)
List<List<int>> nums = new()
{
    new() { 1, 5, 3 },
    new() { 9, 7, 3, -2 },
    new() { 2, 1, 2 }
};

List<int> maximums = new();

foreach (List<int> list in nums)
{
    int max = 0;

    foreach (int num in list)
    {
        if (max < num)
        {
            max = num;
        }
    }

    maximums.Add(max);
}

for (int i = 0; i < nums.Count; i++)
{
    Console.Write($"List {i + 1} has a maximum of {maximums[i]}. ");
}

Console.WriteLine();

// 2. Complexity is O(n)
List<List<int>> grades = new()
{
    new() { 85, 92, 67, 94, 94 },
    new() { 50, 100, 57, 95 },
    new() { 95 }
};

int highestGrade = 0;
int courseIndex = 0;
int it = 0;

foreach (List<int> course in grades)
{
    bool found100 = false;

    foreach (int grade in course)
    {
        if (highestGrade < grade)
        {
            highestGrade = grade;
            courseIndex = it;

            if (highestGrade == 100)
            {
                found100 = true;
                break;
            }
        }
    }

    if (found100)
        break;

    it++;
}

Console.WriteLine($"The highest grade is {highestGrade}. This grade was found in class {courseIndex + 1}");

// 3. Complexity is O(n^2)
List<int> unsortedList = new() { 5, -2, 6, 3, 1, 2 };

for (int i = 0; i < unsortedList.Count - 1; i++)
{
    for (int j = 0; j < unsortedList.Count - i - 1; j++)
    {
        if (unsortedList[j] > unsortedList[j + 1])
        {
            (unsortedList[j], unsortedList[j + 1]) = (unsortedList[j + 1], unsortedList[j]);
        }
    }
}

Console.WriteLine(string.Join(',', unsortedList));