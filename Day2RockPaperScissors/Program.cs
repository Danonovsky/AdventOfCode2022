var lines = File.ReadLines("input.txt");
var score = 0;
foreach (var line in lines)
{
    //A rock, B paper, C scissors
    //X rock +1, Y paper +2, Z scissors +3
    //0 lost, 3 draw, 6 win
    score += line switch {
        "A X" => 4,
        "A Y" => 8,
        "A Z" => 3,
        "B X" => 1,
        "B Y" => 5,
        "B Z" => 9,
        "C X" => 7,
        "C Y" => 2,
        "C Z" => 6
    };
}
System.Console.WriteLine(score);
