var lines = File.ReadLines("input.txt");
var score = 0;
var dictionary = new Dictionary<char, int>();
var i = 1;
foreach (var line in lines)
{
    var distinctLine = line.Distinct().ToList();
    foreach (var character in distinctLine)
    {
        var value = dictionary.ContainsKey(character) ? dictionary[character] : 0;
        if(value >= i) continue;
        value++;
        dictionary[character]=value;
    }
    i++;
    if (i == 4)
    {
        var character = dictionary.Where(_ => _.Value == 3).Select(_ => _.Key).FirstOrDefault();
        var value = char.IsLower(character) ? character - 96 : character - 38;
        score += value;
        i = 1;
        dictionary.Clear();
    }
}
Console.WriteLine(score);//2697