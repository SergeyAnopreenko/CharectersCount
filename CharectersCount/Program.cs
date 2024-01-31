using CountCharacters;

Console.WriteLine("Enter the letters you want to count:");

var userInput = Console.ReadLine();

if (string.IsNullOrEmpty(userInput))
{ 
    Console.WriteLine("You didn't enter any symbols, try again");
    return;
}

CounterCharacter characterCounter = new CounterCharacter(userInput);

Dictionary<char, int> sorter = characterCounter.SorterLetters();

foreach (var (letter, repeats) in sorter)
{
    Console.WriteLine($"{letter} : {repeats}");
}