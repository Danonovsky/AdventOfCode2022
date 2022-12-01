var lines = File.ReadLines("input.txt");
var calories = new List<int>();
var currentCalories = 0;
foreach (var line in lines)
{
    if (line.Length is 0)
    {
        calories.Add(currentCalories);
        currentCalories = 0;
        continue;
    }
    currentCalories += int.Parse(line);
}
Console.WriteLine(calories.Max());
