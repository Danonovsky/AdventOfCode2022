var lines = File.ReadLines("input.txt");
var score = 0;
var dictionary = new Dictionary<char, int>();
var i = 1;
foreach (var line in lines)
{
    foreach (var character in line)
    {
        if (dictionary.ContainsKey(character) is false)
        {
            dictionary.Add(character,1);
            continue;
        }
        dictionary.TryGetValue(character, out var value);
        if(value >= i) continue;
        value++;
        dictionary[character]=value;
    }
    i++;
    if (i == 4)
    {
        var character = dictionary.Where(_ => _.Value == 3).Select(_ => _.Key).FirstOrDefault();
        var value = char.IsLower(character) ? character - 96 : character - 38;
        Console.WriteLine($"{character}:{value}");
        score += value;
        i = 1;
        dictionary.Clear();
    }
}
Console.WriteLine(score);

