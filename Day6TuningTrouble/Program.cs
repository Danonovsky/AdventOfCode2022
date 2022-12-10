var input = File.ReadAllLines("input.txt").First();
const int detectSize = 14;
for (var i = 13; i < input.Length; i++)
{
    var letters = new List<char>();
    for (var j = i; j > i-detectSize; j--)
    {
        letters.Add(input[j]);
    }
    if (letters.Distinct().ToArray().Length == detectSize)
    {
        Console.WriteLine($"Signal found at {i+1}");
        break;
    }
}