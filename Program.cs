// See https://aka.ms/new-console-template for more information

using AdventOfCode2024._01;
using AdventOfCode2024._02;

Console.WriteLine("Advent of Code 2024");
Console.WriteLine("");
Console.WriteLine("======================");
Console.WriteLine("December, 1st 2024");
Console.WriteLine("======================");
Console.WriteLine("");
Console.WriteLine($"The Total Distance between all the locations is: {Locateur.TotalDistance()}");
Console.WriteLine($"The Similarity Score is: {Locateur.SimilarityScore()}");
Console.WriteLine("");
Console.WriteLine("======================");
Console.WriteLine("December, 2nd 2024");
Console.WriteLine("======================");
Console.WriteLine("");
Console.WriteLine($"There are {Saviour.SafeReports()} safe report files");
Console.ReadKey();