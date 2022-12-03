var lines = File.ReadLines("input.txt");
var score = 0;
foreach (var line in lines)
{
    var firstCompartment = line[..(line.Length / 2)];
    var secondCompartment = line[(line.Length / 2)..];
    
    foreach (var character in firstCompartment)
    {
        if (secondCompartment.Contains(character) is false) continue;
        var value = char.IsLower(character) ? character - 96 : character - 38;
        score += value;
        break;
    }
}
Console.WriteLine(score);