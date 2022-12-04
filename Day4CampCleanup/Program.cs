var lines = File.ReadAllLines("input.txt");
var sum = 0;
foreach (var line in lines)
{
    var firstSection = line.Split(",").First();
    var secondSection = line.Split(",").Last();
    var firstSectionStart = int.Parse(firstSection.Split("-").First());
    var firstSectionEnd = int.Parse(firstSection.Split("-").Last());
    var secondSectionStart = int.Parse(secondSection.Split("-").First());
    var secondSectionEnd = int.Parse(secondSection.Split("-").Last());
    if (ShouldAdd(firstSectionStart, firstSectionEnd, secondSectionStart, secondSectionEnd)) sum++;
}
Console.WriteLine(sum);
bool ShouldAdd(int start1, int end1, int start2, int end2)
{
    if (start1 >= start2 && end1 <= end2) return true;
    if (start2 >= start1 && end2 <= end1) return true;
    if (end1 >= start2 && start1 <= end2) return true;
    if (end2 >= start1 && start2 <= end1) return true;
    return false;
}