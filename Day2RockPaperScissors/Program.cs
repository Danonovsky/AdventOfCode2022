﻿var lines = File.ReadLines("input.txt");
var score = lines.Sum(line => line switch
{
    "A X" => 3,
    "A Y" => 4,
    "A Z" => 8,
    "B X" => 1,
    "B Y" => 5,
    "B Z" => 9,
    "C X" => 2,
    "C Y" => 6,
    "C Z" => 7,
    _ => 0
});
Console.WriteLine(score);
