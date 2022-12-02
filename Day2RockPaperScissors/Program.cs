var lines = File.ReadLines("input.txt");
var score = 0;
foreach (var line in lines)
{
    //A rock, B paper, C scissors
    //X rock +1, Y paper +2, Z scissors +3
    //X lose 0, Y draw 3, Z win 6
    score += line switch {
        "A X" => 3,
        "A Y" => 4,
        "A Z" => 8,
        "B X" => 1,
        "B Y" => 5,
        "B Z" => 9,
        "C X" => 2,
        "C Y" => 6,
        "C Z" => 7
    };
}
System.Console.WriteLine(score);
