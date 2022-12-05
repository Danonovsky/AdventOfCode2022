var lines = File.ReadAllLines("input.txt");
var stacks = new List<Stack<char>>();
var stacksAmountIndex = 0;
for (var i = 0; i < lines.Length; i++)
{
    if (lines[i+1].Length == 0)
    {
        stacksAmountIndex = i;
        break;
    }
}

var crates = lines[stacksAmountIndex].Split(" ").Where(_ => _ != "").ToArray();
var cratesAmount = crates.Length;
for (var i = 0; i < cratesAmount; i++)
{
    stacks.Add(new Stack<char>());
    for (var j = stacksAmountIndex-1; j >= 0; j--)
    {
        var charPosition = i * 4 + 1;
        var value = lines[j][charPosition];
        if (value == ' ') continue;
        stacks[i].Push(value);
    }
}

for (var i = stacksAmountIndex+2; i < lines.Length; i++)
{
    var line = lines[i];
    var lineElements = line.Split(" ");
    var amount = int.Parse(lineElements[1]);
    var source = int.Parse(lineElements[3]) - 1;
    var destination = int.Parse(lineElements[5]) - 1;
    for (var j = 0; j < amount; j++)
    {
        var peek = stacks[source].Pop();
        stacks[destination].Push(peek);
    }
}

foreach (var t in stacks)
{
    Console.Write($"{t.Peek()}");
}